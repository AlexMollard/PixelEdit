using System.Drawing;

namespace PixelEdits
{
	partial class NewImage
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
			this.HeightTextBox = new System.Windows.Forms.NumericUpDown();
			this.WidthTextBox = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SquareCheckBox = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.NewFileName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.HeightTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WidthTextBox)).BeginInit();
			this.SuspendLayout();
			// 
			// HeightTextBox
			// 
			this.HeightTextBox.AutoSize = true;
			this.HeightTextBox.Location = new System.Drawing.Point(68, 95);
			this.HeightTextBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.HeightTextBox.Name = "HeightTextBox";
			this.HeightTextBox.Size = new System.Drawing.Size(103, 20);
			this.HeightTextBox.TabIndex = 15;
			this.HeightTextBox.Value = new decimal(new int[] {
            371,
            0,
            0,
            0});
			// 
			// WidthTextBox
			// 
			this.WidthTextBox.AutoSize = true;
			this.WidthTextBox.Location = new System.Drawing.Point(68, 69);
			this.WidthTextBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.WidthTextBox.Name = "WidthTextBox";
			this.WidthTextBox.Size = new System.Drawing.Size(103, 20);
			this.WidthTextBox.TabIndex = 14;
			this.WidthTextBox.Value = new decimal(new int[] {
            615,
            0,
            0,
            0});
			this.WidthTextBox.ValueChanged += new System.EventHandler(this.WidthTextBox_ValueChanged);
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new System.Drawing.Point(21, 154);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(257, 54);
			this.button1.TabIndex = 1;
			this.button1.Text = "Create";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(18, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Height:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(18, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Width:";
			// 
			// SquareCheckBox
			// 
			this.SquareCheckBox.AutoSize = true;
			this.SquareCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SquareCheckBox.ForeColor = System.Drawing.Color.Black;
			this.SquareCheckBox.Location = new System.Drawing.Point(177, 84);
			this.SquareCheckBox.Name = "SquareCheckBox";
			this.SquareCheckBox.Size = new System.Drawing.Size(60, 17);
			this.SquareCheckBox.TabIndex = 10;
			this.SquareCheckBox.Text = "Square";
			this.SquareCheckBox.UseVisualStyleBackColor = true;
			this.SquareCheckBox.CheckedChanged += new System.EventHandler(this.SquareCheckBox_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(17, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(239, 47);
			this.label1.TabIndex = 9;
			this.label1.Text = "New Image";
			// 
			// NewFileName
			// 
			this.NewFileName.Location = new System.Drawing.Point(68, 121);
			this.NewFileName.Name = "NewFileName";
			this.NewFileName.Size = new System.Drawing.Size(169, 20);
			this.NewFileName.TabIndex = 16;
			this.NewFileName.Text = "NewFile";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(18, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Name:";
			// 
			// NewImage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(60)))));
			this.ClientSize = new System.Drawing.Size(295, 223);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.NewFileName);
			this.Controls.Add(this.HeightTextBox);
			this.Controls.Add(this.WidthTextBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.SquareCheckBox);
			this.Controls.Add(this.label1);
			this.Name = "NewImage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "NewImage";
			((System.ComponentModel.ISupportInitialize)(this.HeightTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WidthTextBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.NumericUpDown HeightTextBox;
		public System.Windows.Forms.NumericUpDown WidthTextBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.CheckBox SquareCheckBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox NewFileName;
		private System.Windows.Forms.Label label4;
	}
}