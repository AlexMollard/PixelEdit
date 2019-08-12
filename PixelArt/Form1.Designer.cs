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
            this.EditingSpace = new System.Windows.Forms.Panel();
            this.SelectedColourIndicator = new System.Windows.Forms.Panel();
            this.ZoomInButton = new System.Windows.Forms.Button();
            this.ZoomOutButton = new System.Windows.Forms.Button();
            this.BrushSizeBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SizeIndicator = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.GridButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BrushSizeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1264, 694);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Scale Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1426, 694);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 44);
            this.button2.TabIndex = 12;
            this.button2.Text = "Scale Down";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditingSpace
            // 
            this.EditingSpace.AllowDrop = true;
            this.EditingSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditingSpace.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EditingSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditingSpace.Location = new System.Drawing.Point(22, 25);
            this.EditingSpace.Margin = new System.Windows.Forms.Padding(6);
            this.EditingSpace.Name = "EditingSpace";
            this.EditingSpace.Size = new System.Drawing.Size(1230, 713);
            this.EditingSpace.TabIndex = 14;
            this.EditingSpace.DragDrop += new System.Windows.Forms.DragEventHandler(this.EditingSpace_DragDrop);
            this.EditingSpace.DragEnter += new System.Windows.Forms.DragEventHandler(this.EditingSpace_DragEnter);
            this.EditingSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.EditingSpace_Paint);
            this.EditingSpace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EditingSpace_MouseDown);
            this.EditingSpace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EditingSpace_MouseMove);
            this.EditingSpace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EditingSpace_MouseUp);
            // 
            // SelectedColourIndicator
            // 
            this.SelectedColourIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedColourIndicator.Location = new System.Drawing.Point(1264, 25);
            this.SelectedColourIndicator.Margin = new System.Windows.Forms.Padding(6);
            this.SelectedColourIndicator.Name = "SelectedColourIndicator";
            this.SelectedColourIndicator.Size = new System.Drawing.Size(312, 77);
            this.SelectedColourIndicator.TabIndex = 16;
            this.SelectedColourIndicator.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            this.SelectedColourIndicator.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectedColourIndicator_MouseDown);
            // 
            // ZoomInButton
            // 
            this.ZoomInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ZoomInButton.Location = new System.Drawing.Point(1264, 638);
            this.ZoomInButton.Margin = new System.Windows.Forms.Padding(6);
            this.ZoomInButton.Name = "ZoomInButton";
            this.ZoomInButton.Size = new System.Drawing.Size(150, 44);
            this.ZoomInButton.TabIndex = 17;
            this.ZoomInButton.Text = "Zoom In";
            this.ZoomInButton.UseVisualStyleBackColor = true;
            this.ZoomInButton.Click += new System.EventHandler(this.ZoomInButton_Click);
            // 
            // ZoomOutButton
            // 
            this.ZoomOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ZoomOutButton.Location = new System.Drawing.Point(1426, 638);
            this.ZoomOutButton.Margin = new System.Windows.Forms.Padding(6);
            this.ZoomOutButton.Name = "ZoomOutButton";
            this.ZoomOutButton.Size = new System.Drawing.Size(150, 44);
            this.ZoomOutButton.TabIndex = 18;
            this.ZoomOutButton.Text = "Zoom Out";
            this.ZoomOutButton.UseVisualStyleBackColor = true;
            this.ZoomOutButton.Click += new System.EventHandler(this.ZoomOutButton_Click);
            // 
            // BrushSizeBar
            // 
            this.BrushSizeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrushSizeBar.Location = new System.Drawing.Point(1264, 113);
            this.BrushSizeBar.Margin = new System.Windows.Forms.Padding(6);
            this.BrushSizeBar.Maximum = 20;
            this.BrushSizeBar.Minimum = 1;
            this.BrushSizeBar.Name = "BrushSizeBar";
            this.BrushSizeBar.Size = new System.Drawing.Size(312, 90);
            this.BrushSizeBar.TabIndex = 19;
            this.BrushSizeBar.Value = 1;
            this.BrushSizeBar.Scroll += new System.EventHandler(this.BrushSizeBar_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1282, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Size:";
            // 
            // SizeIndicator
            // 
            this.SizeIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SizeIndicator.AutoSize = true;
            this.SizeIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeIndicator.Location = new System.Drawing.Point(1382, 185);
            this.SizeIndicator.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SizeIndicator.Name = "SizeIndicator";
            this.SizeIndicator.Size = new System.Drawing.Size(30, 31);
            this.SizeIndicator.TabIndex = 21;
            this.SizeIndicator.Text = "1";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(1346, 560);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 44);
            this.button3.TabIndex = 27;
            this.button3.Text = "Debug";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.BackgroundImage = global::PixelArt.Properties.Resources.PixelEditLOAD;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Location = new System.Drawing.Point(748, 773);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(348, 67);
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox5.BackgroundImage = global::PixelArt.Properties.Resources.PixelEditNEW;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(22, 773);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(348, 67);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox4.BackgroundImage = global::PixelArt.Properties.Resources.PixelEditSAVE;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(386, 773);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(348, 67);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImage = global::PixelArt.Properties.Resources.PixelEdit_LOGO;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(1110, 773);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(464, 67);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // GridButton
            // 
            this.GridButton.Location = new System.Drawing.Point(1339, 305);
            this.GridButton.Name = "GridButton";
            this.GridButton.Size = new System.Drawing.Size(129, 63);
            this.GridButton.TabIndex = 0;
            this.GridButton.Text = "GRID";
            this.GridButton.UseVisualStyleBackColor = true;
            this.GridButton.Click += new System.EventHandler(this.GridButton_Click);
            // 
            // PixelEdit
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.GridButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SizeIndicator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrushSizeBar);
            this.Controls.Add(this.ZoomOutButton);
            this.Controls.Add(this.ZoomInButton);
            this.Controls.Add(this.SelectedColourIndicator);
            this.Controls.Add(this.EditingSpace);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PixelEdit";
            this.Text = "Pixel Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PixelEdit_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BrushSizeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel EditingSpace;
		private System.Windows.Forms.Panel SelectedColourIndicator;
		private System.Windows.Forms.Button ZoomInButton;
		private System.Windows.Forms.Button ZoomOutButton;
		private System.Windows.Forms.TrackBar BrushSizeBar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label SizeIndicator;
		private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button GridButton;
    }
}

