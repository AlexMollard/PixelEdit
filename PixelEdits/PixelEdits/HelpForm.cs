using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelEdits
{
	public partial class HelpForm : Form
	{
		public HelpForm()
		{
			InitializeComponent();
			Info.Text = "~ \r\n Welcome to the local weed help center where we bake it, you take it. \r\n \r\n Phone: 069-420-420";

		}

		//-------------
		//	Menu Bar
		//-------------
		private void homeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Title.Text = "Home";
			Info.Text = "~ \r\n Welcome to the local weed help center where we bake it, you take it. \r\n \r\n Phone: 069-420-420";
		}
		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			Title.Text = "Pencil";
			Info.Text = "! \r\n The Pencil is a tool that is used to create a square on the canvas every frame where the mouse is with your desired size.";
		}
		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Title.Text = "Brush";
			Info.Text = "¡ \r\n The Brush is a tool that is used to create a circle on the canvas every frame where the mouse is with your desired size.";
		}
		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			Title.Text = "Bucket";
			Info.Text = "|_| \r\n The Bucket is a tool that is used to fill in areas of the canvas with the selected colour, this uses a algorithm known as a flood fill algorithm.";
		}
		private void toolStripMenuItem5_Click(object sender, EventArgs e)
		{
			Title.Text = "Line";
			Info.Text = "/ \r\n The Line tool is used to draw a straight line from point A to point B. \r\n \r\n Point A: MouseDown. \r\n Point B: MouseUp";
		}
		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			Title.Text = "Circle";
			Info.Text = "O \r\n The Circle Tool is used to draw a ellipse from point A to point B with your desired size. \r\n \r\n Point A: MouseDown. \r\n Point B: MouseUp";
		}
		private void toolStripMenuItem6_Click(object sender, EventArgs e)
		{
			Title.Text = "Square";
			Info.Text = "■ \r\n The Square Tool is used to draw a square from point A to point B both being opposite corners. \r\n \r\n Point A: MouseDown. \r\n Point B: MouseUp";

		}
	}
}
