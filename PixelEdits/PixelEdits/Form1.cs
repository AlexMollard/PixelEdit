using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelEdits
{
	public partial class Form1 : Form
	{
		string _LastFileName = "";
		bool _Editing = false;

		// Tool Size
		int _ToolSize = 1;

		// Starting colours
		Color _PrimaryColour = Color.Black;
		Color _SecondaryColour = Color.White;

		// New Canvas
		int _NewSizeX = 0;
		int _NewSizeY = 0;

		// Mouse Postitions
		Vector2 _PrevMousePos;
		Vector2 _CurrentMousePos;

		Point _TestA;
		Point _TestB;

		//Updater
		System.Windows.Forms.Timer _Updater = new System.Windows.Forms.Timer();

		public Form1()
		{
			InitializeComponent();

			// Set up double buffer
			typeof(Panel).InvokeMember("DoubleBuffered",
			BindingFlags.SetProperty
			| BindingFlags.Instance
			| BindingFlags.NonPublic,
			null, Canvas, new object[] { true });

			// Set Colour Picker BackColor
			PrimaryColourPanel.BackColor = _PrimaryColour;
			SecondaryColourPanel.BackColor = _SecondaryColour;

			// Setup Update function
			_Updater.Interval = 1;
			_Updater.Tick += Update;
			_Updater.Start();
		}

		private void Update(object sender, EventArgs e)
		{
			Canvas.Refresh();
		}

		//------------------------------
		//	Menu Bar (All)
		//------------------------------
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (WindowState != FormWindowState.Maximized)
			{
				WindowState = FormWindowState.Maximized;
			}
			else
			{
				WindowState = FormWindowState.Normal;
			}
		}

		//------------------------------
		//	Menu Bar (Files)
		//------------------------------
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile = new OpenFileDialog();

			openFile.Filter = "PixelArt|*.png;*.jpg";
			openFile.Title = "Pixel Loader";

			if (openFile.ShowDialog() == DialogResult.OK)
			{
				string fileName = openFile.FileName;
				Bitmap myImage = new Bitmap(fileName);

				Canvas.BackgroundImage = myImage;
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_LastFileName == "")
				Save();
			else
				Canvas.BackgroundImage.Save(_LastFileName);
		}

		private void Save()
		{
			SaveFileDialog saveWindow = new SaveFileDialog();
			saveWindow.Filter = "PixelArt|*.png|Dogs|*.jpg";
			saveWindow.Title = "Pixel Saver";

			if (saveWindow.ShowDialog() == DialogResult.OK)
			{
				_LastFileName = saveWindow.FileName;

				Canvas.BackgroundImage.Save(_LastFileName);
			}
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewImage _Settings = new NewImage(Canvas.Width, Canvas.Height);
			_Settings.ShowDialog();

			_NewSizeX = Convert.ToInt32(_Settings.WidthTextBox.Text);
			_NewSizeY = Convert.ToInt32(_Settings.HeightTextBox.Text);
			if (_NewSizeX > 0 && _NewSizeY > 0)
			{

				Bitmap _NewImage = new Bitmap(_NewSizeX, _NewSizeY);
				Graphics _GraphicImage = Graphics.FromImage(_NewImage);
				Brush _Brush = new SolidBrush(_SecondaryColour);

				_GraphicImage.FillRectangle(_Brush, 0, 0, _NewSizeX, _NewSizeY);

				_GraphicImage.Dispose();

				Canvas.BackgroundImage = _NewImage;
			}

			Canvas.Refresh();
		}

		//------------------------------
		//	Colour Functions
		//------------------------------
		private void PrimaryColourPanel_MouseDown(object sender, MouseEventArgs e)
		{
			ColorDialog colorPicker = new ColorDialog();

			colorPicker.FullOpen = true;
			colorPicker.ShowDialog();

			_PrimaryColour = colorPicker.Color;
			PrimaryColourPanel.BackColor = _PrimaryColour;
		}

		private void SecondaryColourPanel_MouseDown(object sender, MouseEventArgs e)
		{
			ColorDialog colorPicker = new ColorDialog();

			colorPicker.FullOpen = true;
			colorPicker.ShowDialog();

			_SecondaryColour = colorPicker.Color;
			SecondaryColourPanel.BackColor = _SecondaryColour;
		}

		private void SwapColourPanel_MouseDown(object sender, MouseEventArgs e)
		{
			Color _TempColour = _PrimaryColour;

			_PrimaryColour = _SecondaryColour;
			_SecondaryColour = _TempColour;

			PrimaryColourPanel.BackColor = _PrimaryColour;
			SecondaryColourPanel.BackColor = _SecondaryColour;
		}

		private void Canvas_Paint(object sender, PaintEventArgs e)
		{
			if (_Editing)
			{
				if (_PrevMousePos.x <= 0.0f && _PrevMousePos.y <= 0.0f)
				{
					_PrevMousePos = _CurrentMousePos;
				}

				Graphics _GraphicImage = Graphics.FromImage(Canvas.BackgroundImage);
				Pen _Pen = new Pen(color: _PrimaryColour, width: _ToolSize);

				//_GraphicImage.DrawRectangle(_Pen, _PrevMousePos.x, _PrevMousePos.y, _CurrentMousePos.x, _CurrentMousePos.y);

				GraphicsPath _Path = new GraphicsPath();
				Point _point1 = new Point(Convert.ToInt32(_CurrentMousePos.x), Convert.ToInt32(_CurrentMousePos.y));
				Point _point2 = new Point(Convert.ToInt32(_PrevMousePos.x), Convert.ToInt32(_PrevMousePos.y));

				PointF[] _points = { _point1, _point2 };

				//_Path.AddCurve(_points);

				Size _Size = new Size(_ToolSize, _ToolSize);

				Rectangle _Rectangle = new Rectangle(_point1, _Size);

				//_Path.AddRectangle(_Rectangle);

				for (int i = 0; i < 100; i++)
				{
				_Path.AddEllipse(_Rectangle);

				}


				_GraphicImage.DrawPath(_Pen, _Path);

				_GraphicImage.Dispose();

				_PrevMousePos = _CurrentMousePos;
			}
		}

		private void Canvas_MouseDown(object sender, MouseEventArgs e)
		{
			//_Editing = true;
			_PrevMousePos = _CurrentMousePos;
			_TestA = e.Location;
		}

		private void Canvas_MouseUp(object sender, MouseEventArgs e)
		{
			_Editing = false;
			_TestB = e.Location;

			Point _TestC = new Point(50, 50);
			Point _TestD = new Point(500, 500);

			Graphics _GraphicImage = Graphics.FromImage(Canvas.BackgroundImage);
			Pen _Pen = new Pen(color: _PrimaryColour, width: _ToolSize);

			GraphicsPath _Path = new GraphicsPath();


			//PointF[] _points = { _TestA, _TestB , _TestC , _TestD };

			//_Path.AddCurve(_points);

			//Size _Size = new Size(_ToolSize, _ToolSize);

			//Rectangle _Rectangle = new Rectangle(_TestA, _Size);

			//_Path.AddRectangle(_Rectangle);

			//_Path.Warp(_points, _Rectangle);

			//_Path.AddPolygon(_points);

			//_Path.AddBeziers(_points);

			FontFamily family = new FontFamily("Arial");

			int fontStyle = (int)FontStyle.Bold;

			Point _TestPointText = _TestA;



			_Path.AddString("❤♥ \n JAMES \n IS \n WEEB", family, fontStyle, _ToolSize, _TestPointText, StringFormat.GenericDefault);

			_GraphicImage.FillPath(Brushes.Black, _Path);
	


			_GraphicImage.Dispose();

			_PrevMousePos = _CurrentMousePos;
		}

		private void Canvas_MouseMove(object sender, MouseEventArgs e)
		{
			_CurrentMousePos.x = ((MouseEventArgs)e).X;
			_CurrentMousePos.y = ((MouseEventArgs)e).Y;
		}

		private void SizeNumUpDown_ValueChanged(object sender, EventArgs e)
		{
			_ToolSize = Convert.ToInt32(SizeNumUpDown.Value);
		}
	}
}
//y she bee looking for me gold, spongie bob
