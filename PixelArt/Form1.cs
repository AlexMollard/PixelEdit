using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelArt
{
	public partial class PixelEdit : Form
	{
		public PixelEdit()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Console.WriteLine("Wassup");
		}

		private void pictureBox5_Click(object sender, EventArgs e) // NewFile
		{
			
		}

		private void pictureBox4_Click(object sender, EventArgs e) // OpenFile
		{
			OpenFileDialog openFile = new OpenFileDialog();

			openFile.Filter = "PixelArt|*.png;*.jpg";
			openFile.Title = "Pixel Loader";

			if (openFile.ShowDialog() == DialogResult.OK)
			{
				string fileName = openFile.FileName;
				Bitmap myImage = new Bitmap(fileName);

				pictureBox1.Image = myImage;

			}
			

			//pictureBox1.BackgroundImage = ;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
