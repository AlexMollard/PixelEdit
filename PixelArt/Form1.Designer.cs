namespace PixelArt
{
	partial class PixelEdit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PixelEdit));
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.EditingSpace = new System.Windows.Forms.Panel();
			this.TestingLabel = new System.Windows.Forms.Label();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.SelectedColourIndicator = new System.Windows.Forms.Panel();
			this.ZoomInButton = new System.Windows.Forms.Button();
			this.ZoomOutButton = new System.Windows.Forms.Button();
			this.BrushSizeBar = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.SizeIndicator = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BrushSizeBar)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(632, 361);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "Scale Up";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(713, 361);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 12;
			this.button2.Text = "Scale Down";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(642, 13);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(83, 40);
			this.button3.TabIndex = 13;
			this.button3.Text = "Colour";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// EditingSpace
			// 
			this.EditingSpace.BackColor = System.Drawing.Color.AliceBlue;
			this.EditingSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.EditingSpace.Location = new System.Drawing.Point(192, 13);
			this.EditingSpace.Name = "EditingSpace";
			this.EditingSpace.Size = new System.Drawing.Size(434, 371);
			this.EditingSpace.TabIndex = 14;
			this.EditingSpace.Click += new System.EventHandler(this.panel1_Click);
			this.EditingSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.EditingSpace_Paint);
			this.EditingSpace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EditingSpace_MouseDown);
			// 
			// TestingLabel
			// 
			this.TestingLabel.AutoSize = true;
			this.TestingLabel.Location = new System.Drawing.Point(721, 198);
			this.TestingLabel.Name = "TestingLabel";
			this.TestingLabel.Size = new System.Drawing.Size(67, 13);
			this.TestingLabel.TabIndex = 15;
			this.TestingLabel.Text = "Testing label";
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox6.BackgroundImage = global::PixelArt.Properties.Resources.PixelEditLOAD;
			this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox6.Location = new System.Drawing.Point(374, 402);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(175, 36);
			this.pictureBox6.TabIndex = 10;
			this.pictureBox6.TabStop = false;
			this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox5.BackgroundImage = global::PixelArt.Properties.Resources.PixelEditNEW;
			this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox5.Location = new System.Drawing.Point(11, 402);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(175, 36);
			this.pictureBox5.TabIndex = 9;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox4.BackgroundImage = global::PixelArt.Properties.Resources.PixelEditSAVE;
			this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox4.Location = new System.Drawing.Point(193, 402);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(175, 36);
			this.pictureBox4.TabIndex = 8;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackgroundImage = global::PixelArt.Properties.Resources.PixelEdit_LOGO;
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox3.Location = new System.Drawing.Point(555, 402);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(233, 36);
			this.pictureBox3.TabIndex = 7;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox2.BackgroundImage = global::PixelArt.Properties.Resources.PixelEditBanner;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Location = new System.Drawing.Point(11, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(175, 372);
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// SelectedColourIndicator
			// 
			this.SelectedColourIndicator.Location = new System.Drawing.Point(731, 13);
			this.SelectedColourIndicator.Name = "SelectedColourIndicator";
			this.SelectedColourIndicator.Size = new System.Drawing.Size(57, 40);
			this.SelectedColourIndicator.TabIndex = 16;
			this.SelectedColourIndicator.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
			// 
			// ZoomInButton
			// 
			this.ZoomInButton.Location = new System.Drawing.Point(632, 332);
			this.ZoomInButton.Name = "ZoomInButton";
			this.ZoomInButton.Size = new System.Drawing.Size(75, 23);
			this.ZoomInButton.TabIndex = 17;
			this.ZoomInButton.Text = "Zoom In";
			this.ZoomInButton.UseVisualStyleBackColor = true;
			this.ZoomInButton.Click += new System.EventHandler(this.ZoomInButton_Click);
			// 
			// ZoomOutButton
			// 
			this.ZoomOutButton.Location = new System.Drawing.Point(713, 332);
			this.ZoomOutButton.Name = "ZoomOutButton";
			this.ZoomOutButton.Size = new System.Drawing.Size(75, 23);
			this.ZoomOutButton.TabIndex = 18;
			this.ZoomOutButton.Text = "Zoom Out";
			this.ZoomOutButton.UseVisualStyleBackColor = true;
			this.ZoomOutButton.Click += new System.EventHandler(this.ZoomOutButton_Click);
			// 
			// BrushSizeBar
			// 
			this.BrushSizeBar.Location = new System.Drawing.Point(642, 60);
			this.BrushSizeBar.Maximum = 20;
			this.BrushSizeBar.Minimum = 1;
			this.BrushSizeBar.Name = "BrushSizeBar";
			this.BrushSizeBar.Size = new System.Drawing.Size(146, 45);
			this.BrushSizeBar.TabIndex = 19;
			this.BrushSizeBar.Value = 1;
			this.BrushSizeBar.Scroll += new System.EventHandler(this.BrushSizeBar_Scroll);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(653, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 17);
			this.label1.TabIndex = 20;
			this.label1.Text = "Size:";
			// 
			// SizeIndicator
			// 
			this.SizeIndicator.AutoSize = true;
			this.SizeIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SizeIndicator.Location = new System.Drawing.Point(694, 91);
			this.SizeIndicator.Name = "SizeIndicator";
			this.SizeIndicator.Size = new System.Drawing.Size(17, 17);
			this.SizeIndicator.TabIndex = 21;
			this.SizeIndicator.Text = "1";
			// 
			// PixelEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DodgerBlue;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.SizeIndicator);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BrushSizeBar);
			this.Controls.Add(this.ZoomOutButton);
			this.Controls.Add(this.ZoomInButton);
			this.Controls.Add(this.SelectedColourIndicator);
			this.Controls.Add(this.TestingLabel);
			this.Controls.Add(this.EditingSpace);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "PixelEdit";
			this.Text = "Pixel Edit";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BrushSizeBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Panel EditingSpace;
		private System.Windows.Forms.Label TestingLabel;
		private System.Windows.Forms.Panel SelectedColourIndicator;
		private System.Windows.Forms.Button ZoomInButton;
		private System.Windows.Forms.Button ZoomOutButton;
		private System.Windows.Forms.TrackBar BrushSizeBar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label SizeIndicator;
	}
}

