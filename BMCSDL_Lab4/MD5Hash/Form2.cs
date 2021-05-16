using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD5Hash
{
	public partial class Form2 : Form
	{
		string conString = ConfigurationManager.ConnectionStrings["QLSV"].ConnectionString;
		public Form2()
		{
			InitializeComponent();
		}

		private void btnsha1_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(conString);
			conn.Open(); //Mở kết nối
			SqlCommand cmd = new SqlCommand("SP_INS_ENCRYPT_NHANVIEN", conn);
			cmd.CommandType = System.Data.CommandType.StoredProcedure;
			cmd.Parameters.Add("@manv", SqlDbType.VarChar).Value = txtManv.Text;
			cmd.Parameters.Add("@hoten", SqlDbType.VarChar).Value = txtHoten.Text;
			cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text;
			cmd.Parameters.Add("@tendn", SqlDbType.VarChar).Value = txtTenDN.Text;

			//Xử lý mật khẩu
			byte[] result;
			byte[] bytes = Encoding.ASCII.GetBytes(txtMatkhau.Text);

			SHA1 sha = new SHA1CryptoServiceProvider();
			// This is one implementation of the abstract class SHA1.
			result = sha.ComputeHash(bytes);
			string kq = System.Text.Encoding.UTF8.GetString(result);
			txtHashMatKhau.Text = kq;
			cmd.Parameters.Add("@matkhau", SqlDbType.VarChar).Value = kq;


			//Xử lý lương
			using (var random = new RNGCryptoServiceProvider())
			{
				var key = new byte[16];
				random.GetBytes(key);

				// Encrypt the string to an array of bytes. 
				byte[] encrypted = EncryptAES(txtLuong.Text, key);

				saveFileDialog1.Filter = "RichText Box File | *.rtf; *.txt";
				saveFileDialog1.InitialDirectory = Application.StartupPath;
				MessageBox.Show("Vui lòng lưu khóa!");
				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					Stream myStream = saveFileDialog1.OpenFile();
					StreamWriter writer = new StreamWriter(myStream);
					writer.Write(Convert.ToBase64String(key));
					writer.Close();
					myStream.Close();
				}

				txtHashLuong.Text = Convert.ToBase64String(encrypted);
				cmd.Parameters.Add("@luong", SqlDbType.VarChar).Value = txtHashLuong.Text;
				cmd.ExecuteScalar();
			}
			conn.Close();
		}
		
		static byte[] EncryptAES(string plainText, byte[] Key)
		{
			byte[] encrypted;
			byte[] IV;

			// Create a new Aes
			using (Aes aesAlg = Aes.Create())
			{
				aesAlg.Key = Key;
				aesAlg.GenerateIV();
				IV = aesAlg.IV;
				aesAlg.Mode = CipherMode.CBC;
				// Create encryptor 
				var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

				// Create the streams used for encryption. 
				using (var msEncrypt = new MemoryStream())
				{
					using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
					{
						using (var swEncrypt = new StreamWriter(csEncrypt))
						{
							//Write all data to the stream.
							swEncrypt.Write(plainText);
						}
						encrypted = msEncrypt.ToArray();
					}
				}
			}
			var combinedIvCt = new byte[IV.Length + encrypted.Length];
			Array.Copy(IV, 0, combinedIvCt, 0, IV.Length);
			Array.Copy(encrypted, 0, combinedIvCt, IV.Length, encrypted.Length);

			// Return the encrypted bytes from the memory stream. 
			return combinedIvCt;
		}
	}
}
