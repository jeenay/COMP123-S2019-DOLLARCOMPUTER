﻿namespace COMP123_S2019_DOLLARCOMPUTER
{
	partial class SelectForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectForm));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dollarComputersDataSet = new COMP123_S2019_DOLLARCOMPUTER.DollarComputersDataSet();
			this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productsTableAdapter = new COMP123_S2019_DOLLARCOMPUTER.DollarComputersDataSetTableAdapters.productsTableAdapter();
			this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rAMtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rAMsizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.displaytypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.screensizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.resolutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cPUClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cPUbrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cPUtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cPUspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cPUnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.oSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.platformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hDDsizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hDDspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gPUTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.opticaldriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.audiotypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.wIFIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.depthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mousttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.powerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.webcamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.rAMtypeDataGridViewTextBoxColumn,
            this.rAMsizeDataGridViewTextBoxColumn,
            this.displaytypeDataGridViewTextBoxColumn,
            this.screensizeDataGridViewTextBoxColumn,
            this.resolutionDataGridViewTextBoxColumn,
            this.cPUClassDataGridViewTextBoxColumn,
            this.cPUbrandDataGridViewTextBoxColumn,
            this.cPUtypeDataGridViewTextBoxColumn,
            this.cPUspeedDataGridViewTextBoxColumn,
            this.cPUnumberDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.oSDataGridViewTextBoxColumn,
            this.platformDataGridViewTextBoxColumn,
            this.hDDsizeDataGridViewTextBoxColumn,
            this.hDDspeedDataGridViewTextBoxColumn,
            this.gPUTypeDataGridViewTextBoxColumn,
            this.opticaldriveDataGridViewTextBoxColumn,
            this.audiotypeDataGridViewTextBoxColumn,
            this.lANDataGridViewTextBoxColumn,
            this.wIFIDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.depthDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.mousttypeDataGridViewTextBoxColumn,
            this.powerDataGridViewTextBoxColumn,
            this.webcamDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.productsBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 33);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(741, 441);
			this.dataGridView1.TabIndex = 0;
			// 
			// dollarComputersDataSet
			// 
			this.dollarComputersDataSet.DataSetName = "DollarComputersDataSet";
			this.dollarComputersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// productsBindingSource
			// 
			this.productsBindingSource.DataMember = "products";
			this.productsBindingSource.DataSource = this.dollarComputersDataSet;
			// 
			// productsTableAdapter
			// 
			this.productsTableAdapter.ClearBeforeFill = true;
			// 
			// productIDDataGridViewTextBoxColumn
			// 
			this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
			this.productIDDataGridViewTextBoxColumn.HeaderText = "productID";
			this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
			this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
			this.productIDDataGridViewTextBoxColumn.Width = 98;
			// 
			// costDataGridViewTextBoxColumn
			// 
			this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
			this.costDataGridViewTextBoxColumn.HeaderText = "cost";
			this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
			this.costDataGridViewTextBoxColumn.ReadOnly = true;
			this.costDataGridViewTextBoxColumn.Width = 63;
			// 
			// manufacturerDataGridViewTextBoxColumn
			// 
			this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer";
			this.manufacturerDataGridViewTextBoxColumn.HeaderText = "manufacturer";
			this.manufacturerDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
			this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
			this.manufacturerDataGridViewTextBoxColumn.Width = 121;
			// 
			// modelDataGridViewTextBoxColumn
			// 
			this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
			this.modelDataGridViewTextBoxColumn.HeaderText = "model";
			this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
			this.modelDataGridViewTextBoxColumn.ReadOnly = true;
			this.modelDataGridViewTextBoxColumn.Width = 75;
			// 
			// rAMtypeDataGridViewTextBoxColumn
			// 
			this.rAMtypeDataGridViewTextBoxColumn.DataPropertyName = "RAM_type";
			this.rAMtypeDataGridViewTextBoxColumn.HeaderText = "RAM_type";
			this.rAMtypeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.rAMtypeDataGridViewTextBoxColumn.Name = "rAMtypeDataGridViewTextBoxColumn";
			this.rAMtypeDataGridViewTextBoxColumn.ReadOnly = true;
			this.rAMtypeDataGridViewTextBoxColumn.Width = 102;
			// 
			// rAMsizeDataGridViewTextBoxColumn
			// 
			this.rAMsizeDataGridViewTextBoxColumn.DataPropertyName = "RAM_size";
			this.rAMsizeDataGridViewTextBoxColumn.HeaderText = "RAM_size";
			this.rAMsizeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.rAMsizeDataGridViewTextBoxColumn.Name = "rAMsizeDataGridViewTextBoxColumn";
			this.rAMsizeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// displaytypeDataGridViewTextBoxColumn
			// 
			this.displaytypeDataGridViewTextBoxColumn.DataPropertyName = "displaytype";
			this.displaytypeDataGridViewTextBoxColumn.HeaderText = "displaytype";
			this.displaytypeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.displaytypeDataGridViewTextBoxColumn.Name = "displaytypeDataGridViewTextBoxColumn";
			this.displaytypeDataGridViewTextBoxColumn.ReadOnly = true;
			this.displaytypeDataGridViewTextBoxColumn.Width = 108;
			// 
			// screensizeDataGridViewTextBoxColumn
			// 
			this.screensizeDataGridViewTextBoxColumn.DataPropertyName = "screensize";
			this.screensizeDataGridViewTextBoxColumn.HeaderText = "screensize";
			this.screensizeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.screensizeDataGridViewTextBoxColumn.Name = "screensizeDataGridViewTextBoxColumn";
			this.screensizeDataGridViewTextBoxColumn.ReadOnly = true;
			this.screensizeDataGridViewTextBoxColumn.Width = 105;
			// 
			// resolutionDataGridViewTextBoxColumn
			// 
			this.resolutionDataGridViewTextBoxColumn.DataPropertyName = "resolution";
			this.resolutionDataGridViewTextBoxColumn.HeaderText = "resolution";
			this.resolutionDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.resolutionDataGridViewTextBoxColumn.Name = "resolutionDataGridViewTextBoxColumn";
			this.resolutionDataGridViewTextBoxColumn.ReadOnly = true;
			this.resolutionDataGridViewTextBoxColumn.Width = 99;
			// 
			// cPUClassDataGridViewTextBoxColumn
			// 
			this.cPUClassDataGridViewTextBoxColumn.DataPropertyName = "CPU_Class";
			this.cPUClassDataGridViewTextBoxColumn.HeaderText = "CPU_Class";
			this.cPUClassDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.cPUClassDataGridViewTextBoxColumn.Name = "cPUClassDataGridViewTextBoxColumn";
			this.cPUClassDataGridViewTextBoxColumn.ReadOnly = true;
			this.cPUClassDataGridViewTextBoxColumn.Width = 107;
			// 
			// cPUbrandDataGridViewTextBoxColumn
			// 
			this.cPUbrandDataGridViewTextBoxColumn.DataPropertyName = "CPU_brand";
			this.cPUbrandDataGridViewTextBoxColumn.HeaderText = "CPU_brand";
			this.cPUbrandDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.cPUbrandDataGridViewTextBoxColumn.Name = "cPUbrandDataGridViewTextBoxColumn";
			this.cPUbrandDataGridViewTextBoxColumn.ReadOnly = true;
			this.cPUbrandDataGridViewTextBoxColumn.Width = 110;
			// 
			// cPUtypeDataGridViewTextBoxColumn
			// 
			this.cPUtypeDataGridViewTextBoxColumn.DataPropertyName = "CPU_type";
			this.cPUtypeDataGridViewTextBoxColumn.HeaderText = "CPU_type";
			this.cPUtypeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.cPUtypeDataGridViewTextBoxColumn.Name = "cPUtypeDataGridViewTextBoxColumn";
			this.cPUtypeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// cPUspeedDataGridViewTextBoxColumn
			// 
			this.cPUspeedDataGridViewTextBoxColumn.DataPropertyName = "CPU_speed";
			this.cPUspeedDataGridViewTextBoxColumn.HeaderText = "CPU_speed";
			this.cPUspeedDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.cPUspeedDataGridViewTextBoxColumn.Name = "cPUspeedDataGridViewTextBoxColumn";
			this.cPUspeedDataGridViewTextBoxColumn.ReadOnly = true;
			this.cPUspeedDataGridViewTextBoxColumn.Width = 112;
			// 
			// cPUnumberDataGridViewTextBoxColumn
			// 
			this.cPUnumberDataGridViewTextBoxColumn.DataPropertyName = "CPU_number";
			this.cPUnumberDataGridViewTextBoxColumn.HeaderText = "CPU_number";
			this.cPUnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.cPUnumberDataGridViewTextBoxColumn.Name = "cPUnumberDataGridViewTextBoxColumn";
			this.cPUnumberDataGridViewTextBoxColumn.ReadOnly = true;
			this.cPUnumberDataGridViewTextBoxColumn.Width = 121;
			// 
			// conditionDataGridViewTextBoxColumn
			// 
			this.conditionDataGridViewTextBoxColumn.DataPropertyName = "condition";
			this.conditionDataGridViewTextBoxColumn.HeaderText = "condition";
			this.conditionDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
			this.conditionDataGridViewTextBoxColumn.ReadOnly = true;
			this.conditionDataGridViewTextBoxColumn.Width = 94;
			// 
			// oSDataGridViewTextBoxColumn
			// 
			this.oSDataGridViewTextBoxColumn.DataPropertyName = "OS";
			this.oSDataGridViewTextBoxColumn.HeaderText = "OS";
			this.oSDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.oSDataGridViewTextBoxColumn.Name = "oSDataGridViewTextBoxColumn";
			this.oSDataGridViewTextBoxColumn.ReadOnly = true;
			this.oSDataGridViewTextBoxColumn.Width = 57;
			// 
			// platformDataGridViewTextBoxColumn
			// 
			this.platformDataGridViewTextBoxColumn.DataPropertyName = "platform";
			this.platformDataGridViewTextBoxColumn.HeaderText = "platform";
			this.platformDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.platformDataGridViewTextBoxColumn.Name = "platformDataGridViewTextBoxColumn";
			this.platformDataGridViewTextBoxColumn.ReadOnly = true;
			this.platformDataGridViewTextBoxColumn.Width = 88;
			// 
			// hDDsizeDataGridViewTextBoxColumn
			// 
			this.hDDsizeDataGridViewTextBoxColumn.DataPropertyName = "HDD_size";
			this.hDDsizeDataGridViewTextBoxColumn.HeaderText = "HDD_size";
			this.hDDsizeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.hDDsizeDataGridViewTextBoxColumn.Name = "hDDsizeDataGridViewTextBoxColumn";
			this.hDDsizeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// hDDspeedDataGridViewTextBoxColumn
			// 
			this.hDDspeedDataGridViewTextBoxColumn.DataPropertyName = "HDD_speed";
			this.hDDspeedDataGridViewTextBoxColumn.HeaderText = "HDD_speed";
			this.hDDspeedDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.hDDspeedDataGridViewTextBoxColumn.Name = "hDDspeedDataGridViewTextBoxColumn";
			this.hDDspeedDataGridViewTextBoxColumn.ReadOnly = true;
			this.hDDspeedDataGridViewTextBoxColumn.Width = 114;
			// 
			// gPUTypeDataGridViewTextBoxColumn
			// 
			this.gPUTypeDataGridViewTextBoxColumn.DataPropertyName = "GPU_Type";
			this.gPUTypeDataGridViewTextBoxColumn.HeaderText = "GPU_Type";
			this.gPUTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.gPUTypeDataGridViewTextBoxColumn.Name = "gPUTypeDataGridViewTextBoxColumn";
			this.gPUTypeDataGridViewTextBoxColumn.ReadOnly = true;
			this.gPUTypeDataGridViewTextBoxColumn.Width = 107;
			// 
			// opticaldriveDataGridViewTextBoxColumn
			// 
			this.opticaldriveDataGridViewTextBoxColumn.DataPropertyName = "optical_drive";
			this.opticaldriveDataGridViewTextBoxColumn.HeaderText = "optical_drive";
			this.opticaldriveDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.opticaldriveDataGridViewTextBoxColumn.Name = "opticaldriveDataGridViewTextBoxColumn";
			this.opticaldriveDataGridViewTextBoxColumn.ReadOnly = true;
			this.opticaldriveDataGridViewTextBoxColumn.Width = 117;
			// 
			// audiotypeDataGridViewTextBoxColumn
			// 
			this.audiotypeDataGridViewTextBoxColumn.DataPropertyName = "Audio_type";
			this.audiotypeDataGridViewTextBoxColumn.HeaderText = "Audio_type";
			this.audiotypeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.audiotypeDataGridViewTextBoxColumn.Name = "audiotypeDataGridViewTextBoxColumn";
			this.audiotypeDataGridViewTextBoxColumn.ReadOnly = true;
			this.audiotypeDataGridViewTextBoxColumn.Width = 108;
			// 
			// lANDataGridViewTextBoxColumn
			// 
			this.lANDataGridViewTextBoxColumn.DataPropertyName = "LAN";
			this.lANDataGridViewTextBoxColumn.HeaderText = "LAN";
			this.lANDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.lANDataGridViewTextBoxColumn.Name = "lANDataGridViewTextBoxColumn";
			this.lANDataGridViewTextBoxColumn.ReadOnly = true;
			this.lANDataGridViewTextBoxColumn.Width = 64;
			// 
			// wIFIDataGridViewTextBoxColumn
			// 
			this.wIFIDataGridViewTextBoxColumn.DataPropertyName = "WIFI";
			this.wIFIDataGridViewTextBoxColumn.HeaderText = "WIFI";
			this.wIFIDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.wIFIDataGridViewTextBoxColumn.Name = "wIFIDataGridViewTextBoxColumn";
			this.wIFIDataGridViewTextBoxColumn.ReadOnly = true;
			this.wIFIDataGridViewTextBoxColumn.Width = 64;
			// 
			// widthDataGridViewTextBoxColumn
			// 
			this.widthDataGridViewTextBoxColumn.DataPropertyName = "width";
			this.widthDataGridViewTextBoxColumn.HeaderText = "width";
			this.widthDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
			this.widthDataGridViewTextBoxColumn.ReadOnly = true;
			this.widthDataGridViewTextBoxColumn.Width = 69;
			// 
			// heightDataGridViewTextBoxColumn
			// 
			this.heightDataGridViewTextBoxColumn.DataPropertyName = "height";
			this.heightDataGridViewTextBoxColumn.HeaderText = "height";
			this.heightDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
			this.heightDataGridViewTextBoxColumn.ReadOnly = true;
			this.heightDataGridViewTextBoxColumn.Width = 76;
			// 
			// depthDataGridViewTextBoxColumn
			// 
			this.depthDataGridViewTextBoxColumn.DataPropertyName = "depth";
			this.depthDataGridViewTextBoxColumn.HeaderText = "depth";
			this.depthDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.depthDataGridViewTextBoxColumn.Name = "depthDataGridViewTextBoxColumn";
			this.depthDataGridViewTextBoxColumn.ReadOnly = true;
			this.depthDataGridViewTextBoxColumn.Width = 73;
			// 
			// weightDataGridViewTextBoxColumn
			// 
			this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
			this.weightDataGridViewTextBoxColumn.HeaderText = "weight";
			this.weightDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
			this.weightDataGridViewTextBoxColumn.ReadOnly = true;
			this.weightDataGridViewTextBoxColumn.Width = 77;
			// 
			// mousttypeDataGridViewTextBoxColumn
			// 
			this.mousttypeDataGridViewTextBoxColumn.DataPropertyName = "moust_type";
			this.mousttypeDataGridViewTextBoxColumn.HeaderText = "moust_type";
			this.mousttypeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.mousttypeDataGridViewTextBoxColumn.Name = "mousttypeDataGridViewTextBoxColumn";
			this.mousttypeDataGridViewTextBoxColumn.ReadOnly = true;
			this.mousttypeDataGridViewTextBoxColumn.Width = 110;
			// 
			// powerDataGridViewTextBoxColumn
			// 
			this.powerDataGridViewTextBoxColumn.DataPropertyName = "power";
			this.powerDataGridViewTextBoxColumn.HeaderText = "power";
			this.powerDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.powerDataGridViewTextBoxColumn.Name = "powerDataGridViewTextBoxColumn";
			this.powerDataGridViewTextBoxColumn.ReadOnly = true;
			this.powerDataGridViewTextBoxColumn.Width = 75;
			// 
			// webcamDataGridViewTextBoxColumn
			// 
			this.webcamDataGridViewTextBoxColumn.DataPropertyName = "webcam";
			this.webcamDataGridViewTextBoxColumn.HeaderText = "webcam";
			this.webcamDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.webcamDataGridViewTextBoxColumn.Name = "webcamDataGridViewTextBoxColumn";
			this.webcamDataGridViewTextBoxColumn.ReadOnly = true;
			this.webcamDataGridViewTextBoxColumn.Width = 88;
			// 
			// SelectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(782, 553);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SelectForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Select your computer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectForm_FormClosing);
			this.Load += new System.EventHandler(this.SelectForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private DollarComputersDataSet dollarComputersDataSet;
		private System.Windows.Forms.BindingSource productsBindingSource;
		private DollarComputersDataSetTableAdapters.productsTableAdapter productsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rAMtypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rAMsizeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn displaytypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn screensizeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn resolutionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cPUClassDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cPUbrandDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cPUtypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cPUspeedDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cPUnumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn oSDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn platformDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hDDsizeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hDDspeedDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn gPUTypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn opticaldriveDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn audiotypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lANDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn wIFIDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn depthDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn mousttypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn webcamDataGridViewTextBoxColumn;
	}
}