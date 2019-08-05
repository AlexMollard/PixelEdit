using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelArt
{
	public partial class PixelEdit : Form
	{
		private string _LastFileName = "";
		Color _SelectedColour = Color.Black;

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

		private void pictureBox4_Click(object sender, EventArgs e) // SaveFile
		{
			if (_LastFileName == "")
				Save();
			else
				panel1.BackgroundImage.Save(_LastFileName);
		}

		private void Save()
		{
			SaveFileDialog saveWindow = new SaveFileDialog();
			saveWindow.Filter = "PixelArt|*.png|Dogs|*.jpg";
			saveWindow.Title = "Pixel Saver";

			if (saveWindow.ShowDialog() == DialogResult.OK)
			{
				_LastFileName = saveWindow.FileName;

				panel1.BackgroundImage.Save(_LastFileName);
			}
		}

		private void pictureBox6_Click(object sender, EventArgs e) // LoadFile
		{
			OpenFileDialog openFile = new OpenFileDialog();

			openFile.Filter = "PixelArt|*.png;*.jpg";
			openFile.Title = "Pixel Loader";

			if (openFile.ShowDialog() == DialogResult.OK)
			{
				string fileName = openFile.FileName;
				Bitmap myImage = new Bitmap(fileName);

				panel1.BackgroundImage = myImage;
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			Graphics renderer = e.Graphics;

			SolidBrush brush = new SolidBrush(Color.Red);

			Rectangle _Box = new Rectangle(MousePosition.X, MousePosition.Y, 0, 0);

			renderer.FillRectangle(brush, _Box);

		}

		private void button1_Click(object sender, EventArgs e) // Scale up 25%
		{
			if (panel1.BackgroundImage != null)
			{
				panel1.BackgroundImage = ScaleByPercent(panel1.BackgroundImage, 125);
			}
		}


		private void button2_Click(object sender, EventArgs e) // Scale down 25%
		{
			if (panel1.BackgroundImage != null)
			{
				panel1.BackgroundImage = ScaleByPercent(panel1.BackgroundImage, 75);
			}
		}

		static Image ScaleByPercent(Image pixelImage, int percent)
		{
			float _Percent = ((float)percent / 100);

			int _SourceWidth = pixelImage.Width;
			int _SourceHeight = pixelImage.Height;
			int _SourceX = 0;
			int _SourceY = 0;

			int _DestX = 0;
			int _DestY = 0;
			int _DestWidth = (int)(_SourceWidth * _Percent);
			int _DestHeight = (int)(_SourceHeight * _Percent);

			Bitmap _Image = new Bitmap(_DestWidth, _DestHeight, PixelFormat.Format32bppArgb);
			_Image.SetResolution(pixelImage.HorizontalResolution, pixelImage.VerticalResolution);

			Graphics _GraphicImage = Graphics.FromImage(_Image);
			_GraphicImage.InterpolationMode = InterpolationMode.NearestNeighbor;

			_GraphicImage.DrawImage(pixelImage, new Rectangle(_DestX, _DestY, _DestWidth, _DestHeight), new Rectangle(_SourceX, _SourceY, _SourceWidth, _SourceHeight), GraphicsUnit.Pixel);
			_GraphicImage.Dispose();

			return _Image;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			ColorDialog colorPicker = new ColorDialog();

			colorPicker.FullOpen = true;
			colorPicker.ShowDialog();

			_SelectedColour = colorPicker.Color;
		}

		private void panel1_Click(object sender, EventArgs e)
		{
			Graphics _GraphicImage = Graphics.FromImage(panel1.BackgroundImage);
			Point _X = new Point(((MouseEventArgs)e).Location.X);
			Point _Y = new Point(((MouseEventArgs)e).Location.Y);
			Pen _Pen = new Pen(_SelectedColour);
			_GraphicImage.DrawLine(_Pen,_X,_Y);
			_GraphicImage.Dispose();
			panel1.Refresh();
		}
	}
}
