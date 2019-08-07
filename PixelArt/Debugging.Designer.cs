namespace PixelArt
{
	partial class Debugging
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
			this.label4 = new System.Windows.Forms.Label();
			this.MouseY = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.MouseX = new System.Windows.Forms.Label();
			this.Frame = new System.Windows.Forms.Label();
			this.TestingLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(-2, 84);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(138, 17);
			this.label4.TabIndex = 32;
			this.label4.Text = "Mouse Y in panel:";
			// 
			// MouseY
			// 
			this.MouseY.AutoSize = true;
			this.MouseY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MouseY.Location = new System.Drawing.Point(138, 84);
			this.MouseY.Name = "MouseY";
			this.MouseY.Size = new System.Drawing.Size(89, 17);
			this.MouseY.TabIndex = 31;
			this.MouseY.Text = "Testing label";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(-2, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 17);
			this.label2.TabIndex = 30;
			this.label2.Text = "Mouse X in panel:";
			// 
			// MouseX
			// 
			this.MouseX.AutoSize = true;
			this.MouseX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MouseX.Location = new System.Drawing.Point(138, 62);
			this.MouseX.Name = "MouseX";
			this.MouseX.Size = new System.Drawing.Size(89, 17);
			this.MouseX.TabIndex = 29;
			this.MouseX.Text = "Testing label";
			// 
			// Frame
			// 
			this.Frame.AutoSize = true;
			this.Frame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Frame.Location = new System.Drawing.Point(62, 106);
			this.Frame.Name = "Frame";
			this.Frame.Size = new System.Drawing.Size(58, 17);
			this.Frame.TabIndex = 28;
			this.Frame.Text = "Frame:";
			// 
			// TestingLabel
			// 
			this.TestingLabel.AutoSize = true;
			this.TestingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TestingLabel.Location = new System.Drawing.Point(138, 106);
			this.TestingLabel.Name = "TestingLabel";
			this.TestingLabel.Size = new System.Drawing.Size(89, 17);
			this.TestingLabel.TabIndex = 27;
			this.TestingLabel.Text = "Testing label";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 31);
			this.label1.TabIndex = 33;
			this.label1.Text = "Debugging";
			// 
			// Debugging
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(245, 243);
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.MouseY);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.MouseX);
			this.Controls.Add(this.Frame);
			this.Controls.Add(this.TestingLabel);
			this.Name = "Debugging";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Debugging";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.Label MouseY;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label MouseX;
		public System.Windows.Forms.Label Frame;
		public System.Windows.Forms.Label TestingLabel;
		private System.Windows.Forms.Label label1;
	}
}