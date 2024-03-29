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
	public partial class SplashScreen : Form
	{
		public SplashScreen()
		{
			InitializeComponent();
		}

		private void Splastimer_Tick(object sender, EventArgs e)
		{
			Splashtimer.Enabled = false;
			Program.startscreen.Show();
			this.Hide();
		}

		private void SplashScreen_Load(object sender, EventArgs e)
		{
			Splashtimer.Enabled = true;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
