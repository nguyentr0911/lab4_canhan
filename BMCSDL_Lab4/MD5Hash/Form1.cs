using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD5Hash
{
	public partial class Form1 : Form
	{
		string conString = ConfigurationManager.ConnectionStrings["QLSV"].ConnectionString;
		public Form1()
		{
			InitializeComponent();
		}

		private void btnmd5_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(conString);
			conn.Open(); //Mở kết nối
			SqlCommand cmd = new SqlCommand("SP_INS_ENCRYPT_SINHVIEN", conn);
			cmd.CommandType = System.Data.CommandType.StoredProcedure;
			cmd.Parameters.Add("@masv", SqlDbType.VarChar).Value = txtMasv.Text;
			cmd.Parameters.Add("@hoten", SqlDbType.VarChar).Value = txtHoten.Text;
			cmd.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = datetimeNS.Text;
			cmd.Parameters.Add("@diachi", SqlDbType.VarChar).Value = txtDiaChi.Text;
			cmd.Parameters.Add("@malop", SqlDbType.VarChar).Value = txtMalop.Text;
			cmd.Parameters.Add("@tendn", SqlDbType.VarChar).Value = txtTenDN.Text;
			using (MD5 md5Hash = MD5.Create())
			{
				txtHashValue.Text = GetMd5Hash(md5Hash, txtMatkhau.Text);
				cmd.Parameters.Add("@matkhau", SqlDbType.VarChar).Value = txtHashValue.Text;
			}
			cmd.ExecuteScalar();
			conn.Close();
		}
		static string GetMd5Hash(MD5 md5Hash, string input)
		{
			// Convert the input string to a byte array and compute the hash.
			byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

			// Create a new Stringbuilder to collect the bytes
			// and create a string.
			StringBuilder sBuilder = new StringBuilder();

			// Loop through each byte of the hashed data and format each one as a hexadecimal string.
			for (int i = 0; i < data.Length; i++)
				sBuilder.Append(data[i].ToString("x2"));
			// Return the hexadecimal string.
			return sBuilder.ToString();
		}
	}
}