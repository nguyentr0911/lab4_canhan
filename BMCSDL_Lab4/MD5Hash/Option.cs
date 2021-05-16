using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD5Hash
{
	public partial class Option : Form
	{
		public Option()
		{
			InitializeComponent();
		}

		private void btnAddSV_Click(object sender, EventArgs e)
		{
			Form1 frm1 = new Form1();
			frm1.Show();
		}

		private void btnAddNV_Click(object sender, EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.Show();
		}
	}
}
