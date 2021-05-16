using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using Lab4_DangNhap;
using System.Security.Cryptography;

namespace Lab3_DangNhap
{
	public partial class Form1 : Form
	{
        string conString = ConfigurationManager.ConnectionStrings["QLSVDG1"].ConnectionString;
		public Form1()
		{
			InitializeComponent();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//public static byte[] StrToByteArray(string strValue)
		//{
		//	System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
		//	return encoding.GetBytes(strValue);
		//}

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection conn = new SqlConnection(conString);
				conn.Open(); //Mở kết nối
				string tk = txtTenDN.Text;
				string mk = txtMatKhau.Text;
				
				SqlCommand cmd = new SqlCommand("LoginNV",conn);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = txtTenDN.Text;

				//Xử lý mật khẩu
				byte[] result;
				byte[] bytes = Encoding.ASCII.GetBytes(txtMatKhau.Text);

				SHA1 sha = new SHA1CryptoServiceProvider();
				// This is one implementation of the abstract class SHA1.
				result = sha.ComputeHash(bytes);
				string kq = System.Text.Encoding.UTF8.GetString(result);
				cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = kq;
				int IsValidNV = Convert.ToInt32(cmd.ExecuteScalar());

				if (tk.Length == 0 || mk.Length == 0)
					MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

				if (IsValidNV == 1) {
					Form2 frm2 = new Form2();
					frm2.TenDN = txtTenDN.Text;
					frm2.MatKhau = txtMatKhau.Text;
					frm2.Show();
				}
				else
					MessageBox.Show("Tên đăng nhập và mật khẩu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				conn.Close(); //Đóng kết nối
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}