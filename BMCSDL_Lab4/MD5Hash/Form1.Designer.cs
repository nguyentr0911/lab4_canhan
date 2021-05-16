namespace MD5Hash
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtMasv = new System.Windows.Forms.TextBox();
			this.txtHoten = new System.Windows.Forms.TextBox();
			this.txtMalop = new System.Windows.Forms.TextBox();
			this.txtTenDN = new System.Windows.Forms.TextBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.txtMatkhau = new System.Windows.Forms.TextBox();
			this.btnmd5 = new System.Windows.Forms.Button();
			this.txtHashValue = new System.Windows.Forms.TextBox();
			this.datetimeNS = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtMasv
			// 
			this.txtMasv.Location = new System.Drawing.Point(81, 26);
			this.txtMasv.Name = "txtMasv";
			this.txtMasv.Size = new System.Drawing.Size(129, 20);
			this.txtMasv.TabIndex = 0;
			// 
			// txtHoten
			// 
			this.txtHoten.Location = new System.Drawing.Point(81, 58);
			this.txtHoten.Name = "txtHoten";
			this.txtHoten.Size = new System.Drawing.Size(129, 20);
			this.txtHoten.TabIndex = 1;
			// 
			// txtMalop
			// 
			this.txtMalop.Location = new System.Drawing.Point(307, 61);
			this.txtMalop.Name = "txtMalop";
			this.txtMalop.Size = new System.Drawing.Size(133, 20);
			this.txtMalop.TabIndex = 2;
			// 
			// txtTenDN
			// 
			this.txtTenDN.Location = new System.Drawing.Point(312, 94);
			this.txtTenDN.Name = "txtTenDN";
			this.txtTenDN.Size = new System.Drawing.Size(128, 20);
			this.txtTenDN.TabIndex = 3;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(307, 29);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(133, 20);
			this.txtDiaChi.TabIndex = 5;
			// 
			// txtMatkhau
			// 
			this.txtMatkhau.Location = new System.Drawing.Point(543, 65);
			this.txtMatkhau.Name = "txtMatkhau";
			this.txtMatkhau.PasswordChar = '*';
			this.txtMatkhau.Size = new System.Drawing.Size(139, 20);
			this.txtMatkhau.TabIndex = 6;
			// 
			// btnmd5
			// 
			this.btnmd5.Location = new System.Drawing.Point(543, 97);
			this.btnmd5.Name = "btnmd5";
			this.btnmd5.Size = new System.Drawing.Size(75, 23);
			this.btnmd5.TabIndex = 7;
			this.btnmd5.Text = "MD5 Hash";
			this.btnmd5.UseVisualStyleBackColor = true;
			this.btnmd5.Click += new System.EventHandler(this.btnmd5_Click);
			// 
			// txtHashValue
			// 
			this.txtHashValue.Enabled = false;
			this.txtHashValue.Location = new System.Drawing.Point(170, 142);
			this.txtHashValue.Name = "txtHashValue";
			this.txtHashValue.Size = new System.Drawing.Size(327, 20);
			this.txtHashValue.TabIndex = 8;
			// 
			// datetimeNS
			// 
			this.datetimeNS.CustomFormat = "mm/dd/yyyy";
			this.datetimeNS.Location = new System.Drawing.Point(81, 91);
			this.datetimeNS.Name = "datetimeNS";
			this.datetimeNS.Size = new System.Drawing.Size(129, 20);
			this.datetimeNS.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Mã SV";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Họ tên";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Ngày sinh";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(261, 29);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "Địa chỉ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(261, 65);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Mã lớp";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(261, 97);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "Tên ĐN";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(485, 68);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Mật khẩu";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(694, 186);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.datetimeNS);
			this.Controls.Add(this.txtHashValue);
			this.Controls.Add(this.btnmd5);
			this.Controls.Add(this.txtMatkhau);
			this.Controls.Add(this.txtDiaChi);
			this.Controls.Add(this.txtTenDN);
			this.Controls.Add(this.txtMalop);
			this.Controls.Add(this.txtHoten);
			this.Controls.Add(this.txtMasv);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtMasv;
		private System.Windows.Forms.TextBox txtHoten;
		private System.Windows.Forms.TextBox txtMalop;
		private System.Windows.Forms.TextBox txtTenDN;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.TextBox txtMatkhau;
		private System.Windows.Forms.Button btnmd5;
		private System.Windows.Forms.TextBox txtHashValue;
		private System.Windows.Forms.DateTimePicker datetimeNS;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
	}
}

