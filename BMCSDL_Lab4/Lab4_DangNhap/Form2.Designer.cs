namespace Lab4_DangNhap
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
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtHoten = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMatkhau = new System.Windows.Forms.TextBox();
			this.txtLuong = new System.Windows.Forms.TextBox();
			this.txtTenDN = new System.Windows.Forms.TextBox();
			this.txtManv = new System.Windows.Forms.TextBox();
			this.dtgNV = new System.Windows.Forms.DataGridView();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnKhong = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgNV)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(240, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(273, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "DANH SÁCH NHÂN VIÊN";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtHoten);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtMatkhau);
			this.groupBox1.Controls.Add(this.txtLuong);
			this.groupBox1.Controls.Add(this.txtTenDN);
			this.groupBox1.Controls.Add(this.txtManv);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 67);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(686, 148);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin nhân viên";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(101, 63);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(224, 24);
			this.txtEmail.TabIndex = 46;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(382, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 18);
			this.label2.TabIndex = 41;
			this.label2.Text = "Họ tên";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(381, 99);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(77, 18);
			this.label7.TabIndex = 44;
			this.label7.Text = "Mật khẩu";
			// 
			// txtHoten
			// 
			this.txtHoten.Location = new System.Drawing.Point(460, 27);
			this.txtHoten.Name = "txtHoten";
			this.txtHoten.Size = new System.Drawing.Size(220, 24);
			this.txtHoten.TabIndex = 36;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(32, 100);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 18);
			this.label6.TabIndex = 43;
			this.label6.Text = "Tên ĐN";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 18);
			this.label3.TabIndex = 45;
			this.label3.Text = "Email";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(381, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 18);
			this.label4.TabIndex = 42;
			this.label4.Text = "Lương";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(32, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 18);
			this.label5.TabIndex = 40;
			this.label5.Text = "Mã NV";
			// 
			// txtMatkhau
			// 
			this.txtMatkhau.Location = new System.Drawing.Point(460, 96);
			this.txtMatkhau.Name = "txtMatkhau";
			this.txtMatkhau.PasswordChar = '*';
			this.txtMatkhau.Size = new System.Drawing.Size(220, 24);
			this.txtMatkhau.TabIndex = 39;
			// 
			// txtLuong
			// 
			this.txtLuong.Location = new System.Drawing.Point(460, 62);
			this.txtLuong.Name = "txtLuong";
			this.txtLuong.Size = new System.Drawing.Size(220, 24);
			this.txtLuong.TabIndex = 38;
			// 
			// txtTenDN
			// 
			this.txtTenDN.Location = new System.Drawing.Point(101, 100);
			this.txtTenDN.Name = "txtTenDN";
			this.txtTenDN.Size = new System.Drawing.Size(224, 24);
			this.txtTenDN.TabIndex = 37;
			// 
			// txtManv
			// 
			this.txtManv.Location = new System.Drawing.Point(101, 28);
			this.txtManv.Name = "txtManv";
			this.txtManv.Size = new System.Drawing.Size(224, 24);
			this.txtManv.TabIndex = 35;
			// 
			// dtgNV
			// 
			this.dtgNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgNV.Location = new System.Drawing.Point(12, 240);
			this.dtgNV.Name = "dtgNV";
			this.dtgNV.Size = new System.Drawing.Size(686, 158);
			this.dtgNV.TabIndex = 2;
			this.dtgNV.SelectionChanged += new System.EventHandler(this.dtgNV_SelectionChanged);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(31, 415);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 3;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(139, 415);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 4;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(245, 415);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 5;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.Location = new System.Drawing.Point(355, 415);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(75, 23);
			this.btnLuu.TabIndex = 6;
			this.btnLuu.Text = "Ghi/Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnKhong
			// 
			this.btnKhong.Location = new System.Drawing.Point(461, 415);
			this.btnKhong.Name = "btnKhong";
			this.btnKhong.Size = new System.Drawing.Size(75, 23);
			this.btnKhong.TabIndex = 7;
			this.btnKhong.Text = "Không";
			this.btnKhong.UseVisualStyleBackColor = true;
			this.btnKhong.Click += new System.EventHandler(this.btnKhong_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(566, 415);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 23);
			this.btnThoat.TabIndex = 8;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(726, 462);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnKhong);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.dtgNV);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgNV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtHoten;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMatkhau;
		private System.Windows.Forms.TextBox txtLuong;
		private System.Windows.Forms.TextBox txtTenDN;
		private System.Windows.Forms.TextBox txtManv;
		private System.Windows.Forms.DataGridView dtgNV;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnKhong;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}

