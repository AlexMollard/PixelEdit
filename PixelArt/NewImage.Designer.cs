namespace PixelArt
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
			this.label1 = new System.Windows.Forms.Label();
			this.SquareCheckBox = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.WidthTextBox = new System.Windows.Forms.NumericUpDown();
			this.HeightTextBox = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.WidthTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HeightTextBox)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(241, 55);
			this.label1.TabIndex = 0;
			this.label1.Text = "New Image";
			// 
			// SquareCheckBox
			// 
			this.SquareCheckBox.AutoSize = true;
			this.SquareCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SquareCheckBox.Location = new System.Drawing.Point(172, 86);
			this.SquareCheckBox.Name = "SquareCheckBox";
			this.SquareCheckBox.Size = new System.Drawing.Size(60, 17);
			this.SquareCheckBox.TabIndex = 1;
			this.SquareCheckBox.Text = "Square";
			this.SquareCheckBox.UseVisualStyleBackColor = true;
			this.SquareCheckBox.CheckedChanged += new System.EventHandler(this.SquareCheckBox_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Width:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Height:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 135);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(257, 54);
			this.button1.TabIndex = 6;
			this.button1.Text = "Create";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// WidthTextBox
			// 
			this.WidthTextBox.Location = new System.Drawing.Point(63, 71);
			this.WidthTextBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.WidthTextBox.Name = "WidthTextBox";
			this.WidthTextBox.Size = new System.Drawing.Size(103, 20);
			this.WidthTextBox.TabIndex = 7;
			this.WidthTextBox.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
			// 
			// HeightTextBox
			// 
			this.HeightTextBox.Location = new System.Drawing.Point(63, 97);
			this.HeightTextBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.HeightTextBox.Name = "HeightTextBox";
			this.HeightTextBox.Size = new System.Drawing.Size(103, 20);
			this.HeightTextBox.TabIndex = 8;
			this.HeightTextBox.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
			// 
			// NewImage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(279, 198);
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
			this.Load += new System.EventHandler(this.NewImage_Load);
			((System.ComponentModel.ISupportInitialize)(this.WidthTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HeightTextBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.NumericUpDown WidthTextBox;
		public System.Windows.Forms.NumericUpDown HeightTextBox;
		public System.Windows.Forms.CheckBox SquareCheckBox;
	}
}