﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_DOLLARCOMPUTER
{
	public partial class StartScreen : Form
	{
		public StartScreen()
		{
			InitializeComponent();
		}

		private void StartScreen_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void BtnStartneworder_Click(object sender, EventArgs e)
		{
			Program.selectform.Show();
			this.Hide();
		}
	}
}
