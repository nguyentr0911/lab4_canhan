namespace MD5Hash
{
	partial class Form2
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHashMatKhau = new System.Windows.Forms.TextBox();
            this.btnsha1 = new System.Windows.Forms.Button();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHashLuong = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Tên ĐN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Lương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã NV";
            // 
            // txtHashMatKhau
            // 
            this.txtHashMatKhau.Enabled = false;
            this.txtHashMatKhau.Location = new System.Drawing.Point(227, 171);
            this.txtHashMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHashMatKhau.Name = "txtHashMatKhau";
            this.txtHashMatKhau.Size = new System.Drawing.Size(435, 22);
            this.txtHashMatKhau.TabIndex = 24;
            // 
            // btnsha1
            // 
            this.btnsha1.Location = new System.Drawing.Point(108, 167);
            this.btnsha1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsha1.Name = "btnsha1";
            this.btnsha1.Size = new System.Drawing.Size(100, 28);
            this.btnsha1.TabIndex = 23;
            this.btnsha1.Text = "Hash";
            this.btnsha1.UseVisualStyleBackColor = true;
            this.btnsha1.Click += new System.EventHandler(this.btnsha1_Click);
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(453, 113);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(184, 22);
            this.txtMatkhau.TabIndex = 22;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(453, 32);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(184, 22);
            this.txtLuong.TabIndex = 21;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(453, 71);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(184, 22);
            this.txtTenDN.TabIndex = 20;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(108, 68);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(171, 22);
            this.txtHoten.TabIndex = 18;
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(108, 28);
            this.txtManv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(171, 22);
            this.txtManv.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(108, 113);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(171, 22);
            this.txtEmail.TabIndex = 34;
            // 
            // txtHashLuong
            // 
            this.txtHashLuong.Enabled = false;
            this.txtHashLuong.Location = new System.Drawing.Point(227, 203);
            this.txtHashLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHashLuong.Name = "txtHashLuong";
            this.txtHashLuong.Size = new System.Drawing.Size(319, 22);
            this.txtHashLuong.TabIndex = 35;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 252);
            this.Controls.Add(this.txtHashLuong);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHashMatKhau);
            this.Controls.Add(this.btnsha1);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtManv);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtHashMatKhau;
		private System.Windows.Forms.Button btnsha1;
		private System.Windows.Forms.TextBox txtMatkhau;
		private System.Windows.Forms.TextBox txtLuong;
		private System.Windows.Forms.TextBox txtTenDN;
		private System.Windows.Forms.TextBox txtHoten;
		private System.Windows.Forms.TextBox txtManv;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtHashLuong;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}