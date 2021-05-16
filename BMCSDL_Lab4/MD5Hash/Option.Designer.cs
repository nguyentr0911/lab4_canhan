namespace MD5Hash
{
	partial class Option
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
			this.btnAddSV = new System.Windows.Forms.Button();
			this.btnAddNV = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAddSV
			// 
			this.btnAddSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddSV.Location = new System.Drawing.Point(12, 50);
			this.btnAddSV.Name = "btnAddSV";
			this.btnAddSV.Size = new System.Drawing.Size(144, 47);
			this.btnAddSV.TabIndex = 0;
			this.btnAddSV.Text = "Thêm sinh viên";
			this.btnAddSV.UseVisualStyleBackColor = true;
			this.btnAddSV.Click += new System.EventHandler(this.btnAddSV_Click);
			// 
			// btnAddNV
			// 
			this.btnAddNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddNV.Location = new System.Drawing.Point(179, 50);
			this.btnAddNV.Name = "btnAddNV";
			this.btnAddNV.Size = new System.Drawing.Size(153, 47);
			this.btnAddNV.TabIndex = 1;
			this.btnAddNV.Text = "Thêm nhân viên";
			this.btnAddNV.UseVisualStyleBackColor = true;
			this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
			// 
			// Option
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 133);
			this.Controls.Add(this.btnAddNV);
			this.Controls.Add(this.btnAddSV);
			this.Name = "Option";
			this.Text = "Option";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAddSV;
		private System.Windows.Forms.Button btnAddNV;
	}
}