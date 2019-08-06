using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelArt
{

	public partial class PixelEdit : Form
	{
		private string _LastFileName = "";
		Color _SelectedColour = Color.Black;

		Timer _GameTimer = new Timer();


		int _CurrentZoom = 1;
		int _BrushSize = 1;

		//New Sizes
		int _NewSizeX = 32;
		int _NewSizeY = 32;
		int testingint = 0;


		public PixelEdit()
		{
			InitializeComponent();


			typeof(Panel).InvokeMember("DoubleBuffered",
			BindingFlags.SetProperty
			| BindingFlags.Instance
			| BindingFlags.NonPublic,
			null, EditingSpace, new object[] { true });

			_GameTimer.Interval = 300;
			_GameTimer.Tick += Update;
			_GameTimer.Start();
		}

		private void Update(object sender, EventArgs e)
		{
			EditingSpace.Refresh();
			testingint++;
			TestingLabel.Text = Convert.ToString(testingint);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			EditingSpace.AutoScrollMinSize = new Size();
		}

		private void pictureBox5_Click(object sender, EventArgs e) // NewFile
		{
			NewImage _Settings = new NewImage();
			_Settings.ShowDialog();

			_NewSizeX = Convert.ToInt32(_Settings.WidthTextBox.Text);
			_NewSizeY = Convert.ToInt32(_Settings.HeightTextBox.Text);
			if (_NewSizeX > 0 && _NewSizeY > 0)
			{

			Bitmap _NewImage = new Bitmap(_NewSizeX, _NewSizeY);
			Graphics _GraphicImage = Graphics.FromImage(_NewImage);
			Brush _Brush = new SolidBrush(_SelectedColour);

			_GraphicImage.FillRectangle(_Brush, 0,0,_NewSizeX,_NewSizeY);

			_GraphicImage.Dispose();

			EditingSpace.BackgroundImage = _NewImage;
			}

			EditingSpace.Refresh();

		}

		private void pictureBox4_Click(object sender, EventArgs e) // SaveFile
		{
			if (_LastFileName == "")
				Save();
			else
				EditingSpace.BackgroundImage.Save(_LastFileName);
		}

		private void Save()
		{
			SaveFileDialog saveWindow = new SaveFileDialog();
			saveWindow.Filter = "PixelArt|*.png|Dogs|*.jpg";
			saveWindow.Title = "Pixel Saver";

			if (saveWindow.ShowDialog() == DialogResult.OK)
			{
				_LastFileName = saveWindow.FileName;

				EditingSpace.BackgroundImage.Save(_LastFileName);
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

				EditingSpace.BackgroundImage = myImage;
			}
		}


		private void button1_Click(object sender, EventArgs e) // Scale up 25%
		{
			if (EditingSpace.BackgroundImage != null)
			{
				EditingSpace.BackgroundImage = ScaleByPercent(EditingSpace.BackgroundImage, 125);
				//((Bitmap)EditingSpace.BackgroundImage).
			}
		}


		private void button2_Click(object sender, EventArgs e) // Scale down 25%
		{
			if (EditingSpace.BackgroundImage != null)
			{
				EditingSpace.BackgroundImage = ScaleByPercent(EditingSpace.BackgroundImage, 75);
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
			SelectedColourIndicator.BackColor = _SelectedColour;
		}

		private void panel1_Click(object sender, EventArgs e)
		{

		}

		private void EditingSpace_MouseDown(object sender, MouseEventArgs e)
		{

		}

		private void panel1_Paint_1(object sender, PaintEventArgs e)
		{
			SelectedColourIndicator.BackColor = _SelectedColour;
		}

		private void ZoomInButton_Click(object sender, EventArgs e)
		{

			int _Zoom = _CurrentZoom += 1;

			_CurrentZoom = _Zoom;

			EditingSpace.AutoScrollMinSize = new Size(EditingSpace.BackgroundImage.Width * _Zoom, EditingSpace.BackgroundImage.Height * _Zoom);
		}

		private void EditingSpace_Paint(object sender, PaintEventArgs e)
		{
			//Drawing
			if (EditingSpace.BackgroundImage != null)
			{
				Graphics _GraphicImage = Graphics.FromImage(EditingSpace.BackgroundImage);
				Brush _Pen = new SolidBrush(_SelectedColour);
				_GraphicImage.FillRectangle(_Pen, GetMousePos(MousePosition).X - _BrushSize / 2, GetMousePos(MousePosition).Y - _BrushSize / 2, _BrushSize, _BrushSize);
				_GraphicImage.Dispose();

				//EditingSpace.Refresh();
			}

			//Zoom image
			if (EditingSpace.BackgroundImage != null)
			{
				using (Matrix mx = new Matrix(_CurrentZoom, 0, 0, _CurrentZoom, 0, 0))
				{
					mx.Translate(EditingSpace.AutoScrollPosition.X / _CurrentZoom, EditingSpace.AutoScrollPosition.Y / _CurrentZoom);
					e.Graphics.Transform = mx;
					e.Graphics.DrawImage(EditingSpace.BackgroundImage, new Point(0, 0));
				}
				//EditingSpace.Refresh();
			}
		}

		private void ZoomOutButton_Click(object sender, EventArgs e)
		{
			int _Zoom = _CurrentZoom -= 1;

			_CurrentZoom = _Zoom;


			EditingSpace.AutoScrollMinSize = new Size(EditingSpace.BackgroundImage.Width * _Zoom, EditingSpace.BackgroundImage.Height * _Zoom);
		}

		protected Point GetMousePos(Point e)
		{
			Matrix mx = new Matrix(_CurrentZoom, 0, 0, _CurrentZoom, 0, 0);
			mx.Translate(this.AutoScrollPosition.X * (1.0f / _CurrentZoom), this.AutoScrollPosition.X * (1.0f / _CurrentZoom));
			mx.Invert();
			Point[] p = new Point[] { new Point(e.X, e.Y) };
			mx.TransformPoints(p);
			return p[0];
		}

		private void BrushSizeBar_Scroll(object sender, EventArgs e)
		{
			SizeIndicator.Text = Convert.ToString(BrushSizeBar.Value);
			_BrushSize = BrushSizeBar.Value;
		}
	}
}
