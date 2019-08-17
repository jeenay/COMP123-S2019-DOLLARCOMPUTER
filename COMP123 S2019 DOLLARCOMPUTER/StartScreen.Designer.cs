namespace COMP123_S2019_DOLLARCOMPUTER
{
	partial class StartScreen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
			this.lblWelcome = new System.Windows.Forms.Label();
			this.btnStartneworder = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.Picture1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Picture1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblWelcome
			// 
			this.lblWelcome.AutoSize = true;
			this.lblWelcome.BackColor = System.Drawing.Color.LightSteelBlue;
			this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.lblWelcome.Location = new System.Drawing.Point(12, 21);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(359, 29);
			this.lblWelcome.TabIndex = 1;
			this.lblWelcome.Text = "Welcome to Dollar Computers !!!";
			// 
			// btnStartneworder
			// 
			this.btnStartneworder.BackColor = System.Drawing.Color.LightSlateGray;
			this.btnStartneworder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStartneworder.Location = new System.Drawing.Point(82, 362);
			this.btnStartneworder.Name = "btnStartneworder";
			this.btnStartneworder.Size = new System.Drawing.Size(217, 49);
			this.btnStartneworder.TabIndex = 1;
			this.btnStartneworder.Text = "Start New Order";
			this.btnStartneworder.UseVisualStyleBackColor = false;
			this.btnStartneworder.Click += new System.EventHandler(this.BtnStartneworder_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightSlateGray;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(82, 431);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(217, 49);
			this.button2.TabIndex = 1;
			this.button2.Text = "View Orders";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.LightSlateGray;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(82, 492);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(217, 49);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "Exit Application";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// Picture1
			// 
			this.Picture1.Image = ((System.Drawing.Image)(resources.GetObject("Picture1.Image")));
			this.Picture1.Location = new System.Drawing.Point(12, 63);
			this.Picture1.Name = "Picture1";
			this.Picture1.Size = new System.Drawing.Size(356, 276);
			this.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Picture1.TabIndex = 0;
			this.Picture1.TabStop = false;
			// 
			// StartScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(381, 553);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.lblWelcome);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnStartneworder);
			this.Controls.Add(this.Picture1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "StartScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StartScreen";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartScreen_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.Picture1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblWelcome;
		private System.Windows.Forms.Button btnStartneworder;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.PictureBox Picture1;
	}
}