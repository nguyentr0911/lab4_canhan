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

namespace Lab4_DangNhap
{
	public partial class Form2 : Form
	{
		string conString = ConfigurationManager.ConnectionStrings["QLSV"].ConnectionString;

		public Form2()
		{
			InitializeComponent();
		}

		private string tendn;
		public string TenDN
		{
			get { return tendn; }
			set { tendn = value; }
		}
		private string matkhau;
		public string MatKhau
		{
			get { return matkhau; }
			set { matkhau = value; }
		}
		
		static string DecryptAES(byte[] cipherTextCombined, byte[] Key)
		{
			// Declare the string used to hold  the decrypted text. 
			string plaintext = null;

			// Create an Aes object with the specified key and IV. 
			using (Aes aesAlg = Aes.Create())
			{
				aesAlg.Key = Key;
				byte[] IV = new byte[aesAlg.BlockSize / 8];
				byte[] cipherText = new byte[cipherTextCombined.Length - IV.Length];

				Array.Copy(cipherTextCombined, IV, IV.Length);
				Array.Copy(cipherTextCombined, IV.Length, cipherText, 0, cipherText.Length);

				aesAlg.IV = IV;

				aesAlg.Mode = CipherMode.CBC;

				// Create a decrytor to perform the stream transform.
				ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

				// Create the streams used for decryption. 
				using (var msDecrypt = new MemoryStream(cipherText))
				{
					using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
					{
						using (var srDecrypt = new StreamReader(csDecrypt))
						{
							// Read the decrypted bytes from the decrypting stream and place them in a string
							plaintext = srDecrypt.ReadToEnd();
						}
					}
				}
			}
			return plaintext;
		}

		private void dtgNV_SelectionChanged(object sender, EventArgs e)
		{
			try
			{
				if (dtgNV.SelectedRows.Count == 1)
				{
					DataGridViewRow r = dtgNV.SelectedRows[0];
					txtManv.Text = r.Cells["MANV"].Value.ToString();
					txtEmail.Text = r.Cells["EMAIL"].Value.ToString();
					txtTenDN.Text = tendn;
					txtHoten.Text = r.Cells["HOTEN"].Value.ToString();
					txtMatkhau.Text = matkhau;

					openFileDialog1.Filter = "RichText Box File | *.rtf; *.txt";
					MessageBox.Show("Vui lòng mở khóa của nhân viên này để xem lương!");
					openFileDialog1.InitialDirectory = Application.StartupPath;
					
					if (openFileDialog1.ShowDialog() == DialogResult.OK)
					{
						Stream myStream = openFileDialog1.OpenFile();
						StreamReader reader = new StreamReader(myStream);
						byte[] doc = Convert.FromBase64String(reader.ReadToEnd());
						byte[] tmp = Convert.FromBase64String(r.Cells["LUONGCB"].Value.ToString());

						r.Cells["LUONGCB"].Value = DecryptAES(tmp, doc);
						reader.Close();
						myStream.Close();
					}
					txtLuong.Text = r.Cells["LUONGCB"].Value.ToString();
				}
			}
			catch
			{
				MessageBox.Show("Bạn không có quyền được xem lương của nhân viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			txtManv.Enabled = txtHoten.Enabled = txtEmail.Enabled = txtLuong.Enabled = txtMatkhau.Enabled = txtTenDN.Enabled = false;
			CapNhatGUI();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			txtManv.Enabled = txtHoten.Enabled = txtEmail.Enabled = txtLuong.Enabled = txtMatkhau.Enabled = txtTenDN.Enabled = true;
		}

		private void btnLuu_Click(object sender, EventArgs e)
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
			cmd.Parameters.Add("@matkhau", SqlDbType.VarChar).Value = kq;

			//Xử lý lương
			using (var random = new RNGCryptoServiceProvider())
			{
				var key = new byte[16];
				random.GetBytes(key);

				// Encrypt the string to an array of bytes. 
				byte[] encrypted = EncryptAES(txtLuong.Text, key);

				saveFileDialog1.Filter = "RichText Box File | *.rtf; *.txt";
				MessageBox.Show("Vui lòng lưu khóa của nhân viên này!");
				saveFileDialog1.InitialDirectory = Application.StartupPath;
				
				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					Stream myStream = saveFileDialog1.OpenFile();
					StreamWriter writer = new StreamWriter(myStream);
					writer.Write(Convert.ToBase64String(key));
					writer.Close();
					myStream.Close();
				}

				cmd.Parameters.Add("@luong", SqlDbType.VarChar).Value = Convert.ToBase64String(encrypted);
				cmd.ExecuteScalar();
			}
			CapNhatGUI();
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

		private void CapNhatGUI()
		{
			SqlConnection conn = new SqlConnection(conString);
			conn.Open();
			SqlCommand cmd = new SqlCommand("SP_SEL_ENCRYPT_NHANVIEN", conn);
			cmd.CommandType = System.Data.CommandType.StoredProcedure;
			SqlDataAdapter adap = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();

			adap.Fill(dt); //Đổ dữ liệu
			dtgNV.DataSource = dt;
			conn.Close();

			//Lấy dữ liệu dòng đầu tiên đổ xuống các control textbox
			txtManv.Text = dtgNV.CurrentRow.Cells[0].Value.ToString();
			txtHoten.Text = dtgNV.CurrentRow.Cells[1].Value.ToString();
			txtEmail.Text = dtgNV.CurrentRow.Cells[2].Value.ToString();
			txtLuong.Text = dtgNV.CurrentRow.Cells[3].Value.ToString();
			txtTenDN.Text = tendn;
			txtMatkhau.Text = matkhau;
		}

		private void btnKhong_Click(object sender, EventArgs e)
		{
			txtManv.Enabled = txtHoten.Enabled = txtEmail.Enabled = txtLuong.Enabled = txtMatkhau.Enabled = txtTenDN.Enabled = false;
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			string maNV = dtgNV.SelectedRows[0].Cells[0].Value.ToString();
			SqlConnection conn = new SqlConnection(conString);
			conn.Open();

			SqlCommand cmd = new SqlCommand();
			cmd.Connection = conn;
			cmd.CommandText = "DeleteNV";
			cmd.CommandType = System.Data.CommandType.StoredProcedure;

			SqlTransaction tran = null;
			try
			{
				tran = conn.BeginTransaction("XoaLopTransaction");
				cmd.Transaction = tran;
				if (MessageBox.Show(null, "Bạn có muốn xóa MANV=" + maNV, "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					SqlParameter pa1 = new SqlParameter("@Manv", maNV);
					cmd.Parameters.Add(pa1);
					cmd.ExecuteNonQuery();
					tran.Commit(); //kết thúc transaction
				}
			}
			catch (Exception ex)
			{
				tran.Rollback();
				MessageBox.Show(ex.Message);
				throw;
			}
			finally
			{
				CapNhatGUI();
				conn.Close();
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (txtManv.Enabled = txtHoten.Enabled = txtEmail.Enabled = txtLuong.Enabled = txtMatkhau.Enabled = txtTenDN.Enabled == false)
			{
				txtManv.Enabled = txtHoten.Enabled = txtEmail.Enabled = txtLuong.Enabled = txtMatkhau.Enabled = txtTenDN.Enabled = true;
			}
			else
			{
				SqlTransaction tran = null;
				SqlConnection conn = new SqlConnection(conString);
				conn.Open(); //Mở kết nối
				try
				{
					SqlCommand cmd = new SqlCommand("SP_UPD_ENCRYPT_NHANVIEN", conn);
					cmd.CommandType = System.Data.CommandType.StoredProcedure;

					//đánh dấu điểm bắt đầu
					tran = conn.BeginTransaction("SuaNVTransaction");
					cmd.Transaction = tran;
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
					cmd.Parameters.Add("@matkhau", SqlDbType.VarChar).Value = kq;

					//Xử lý lương
					using (var random = new RNGCryptoServiceProvider())
					{
						var key = new byte[16];
						random.GetBytes(key);

						// Encrypt the string to an array of bytes. 
						byte[] encrypted = EncryptAES(txtLuong.Text, key);

						saveFileDialog1.Filter = "RichText Box File | *.rtf; *.txt";
						MessageBox.Show("Vui lòng lưu khóa cho nhân viên này!");
						saveFileDialog1.InitialDirectory = Application.StartupPath;
						
						if (saveFileDialog1.ShowDialog() == DialogResult.OK)
						{
							Stream myStream = saveFileDialog1.OpenFile();
							StreamWriter writer = new StreamWriter(myStream);
							writer.Write(Convert.ToBase64String(key));
							writer.Close();
							myStream.Close();
						}

						cmd.Parameters.Add("@luong", SqlDbType.VarChar).Value = Convert.ToBase64String(encrypted);
						cmd.ExecuteScalar();
						tran.Commit(); //kết thúc transaction
					}
				}
				catch (Exception ex)
				{
					tran.Rollback();
					MessageBox.Show(ex.Message);
					throw;
				}
				finally
				{
					CapNhatGUI();
					conn.Close();
				}
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}