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
	public partial class SelectForm : Form
	{
		public SelectForm()
		{
			InitializeComponent();
		}

		private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void SelectForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
			this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

		}
	}
}
