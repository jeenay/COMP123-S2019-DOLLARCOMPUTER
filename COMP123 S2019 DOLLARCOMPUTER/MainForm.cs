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
	public partial class lblMainForm : Form
	{
		public lblMainForm()
		{
			InitializeComponent();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

	}
}
