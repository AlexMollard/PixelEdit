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
	public partial class PixelEdit : Form
	{
        //Tools
        private enum _Tool {_Pencil, _Brush, _Bucket, _Line, _Circle, _Square};
        _Tool _CurrentTool = _Tool._Pencil;

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

		// Mouse Positions
		Vector2 _PrevMousePos;
		Vector2 _CurrentMousePos;
		Vector2 _MouseDown;
		Vector2 _MouseUp;


		//Updater
		System.Windows.Forms.Timer _Updater = new System.Windows.Forms.Timer();

		public PixelEdit()
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

            UpdateSize();
        }

		// Update Form
        private void Update(object sender, EventArgs e)
		{
			Canvas.Refresh();
		}

		//------------------------------
		//	Menu Bar (All)
		//------------------------------
		// Close Application
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		// FullScreen Toggle
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
		// Open Image
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

		// Save Image
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_LastFileName == "")
				Save();
			else
				Canvas.BackgroundImage.Save(_LastFileName);
		}

		// Save Image
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

		// New Image
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

            SizeIndicatorPanel.BackColor = _SecondaryColour;
            SizeIndicatorDot.BackColor = _PrimaryColour;

			Canvas.Refresh();
		}

		//------------------------------
		//	Colour Functions
		//------------------------------
		// Select Primary Colour
		private void PrimaryColourPanel_MouseDown(object sender, MouseEventArgs e)
		{
			ColorDialog colorPicker = new ColorDialog();

			colorPicker.FullOpen = true;
			colorPicker.ShowDialog();

			_PrimaryColour = colorPicker.Color;
			PrimaryColourPanel.BackColor = _PrimaryColour;

            UpdateSize();
        }

		// Select Secondary Colour
		private void SecondaryColourPanel_MouseDown(object sender, MouseEventArgs e)
		{
			ColorDialog colorPicker = new ColorDialog();

			colorPicker.FullOpen = true;
			colorPicker.ShowDialog();

			_SecondaryColour = colorPicker.Color;
			SecondaryColourPanel.BackColor = _SecondaryColour;

            UpdateSize();
        }

		// Swap Primary and Secondary Colour
		private void SwapColourPanel_MouseDown(object sender, MouseEventArgs e)
		{
			Color _TempColour = _PrimaryColour;

			_PrimaryColour = _SecondaryColour;
			_SecondaryColour = _TempColour;

			PrimaryColourPanel.BackColor = _PrimaryColour;
			SecondaryColourPanel.BackColor = _SecondaryColour;

            UpdateSize();
		}

		//------------------------------
		//	Canvas Functions
		//------------------------------
		// Runs every frame
		private void Canvas_Paint(object sender, PaintEventArgs e)
		{
			if (_Editing && Canvas.BackgroundImage != null)
			{
				if (_PrevMousePos.x < 0.0f && _PrevMousePos.y < 0.0f)
				{
					_PrevMousePos = _CurrentMousePos;
				}

				if (_CurrentTool == _Tool._Pencil)
					Line((int)_CurrentMousePos.x, (int)_CurrentMousePos.y, (int)_PrevMousePos.x, (int)_PrevMousePos.y);
				else if (_CurrentTool == _Tool._Brush)
				{
					Graphics _GraphicImage = Graphics.FromImage(Canvas.BackgroundImage);
					Pen _Pen = new Pen(color: _PrimaryColour, width: _ToolSize);
					_Pen.DashStyle = DashStyle.Solid;
					_Pen.EndCap = _Pen.StartCap = LineCap.Round;
					_GraphicImage.DrawLine(_Pen, _CurrentMousePos.x, _CurrentMousePos.y, _PrevMousePos.x, _PrevMousePos.y);
				}

				_PrevMousePos = _CurrentMousePos;
			}
		}

		// Runs once when the mouse is pressed on canvas
		private void Canvas_MouseDown(object sender, MouseEventArgs e)
		{
			_Editing = true;
			_PrevMousePos = _CurrentMousePos;
            _MouseDown = new Vector2(e.Location.X,e.Location.Y);

			if (_CurrentTool == _Tool._Bucket)
			{
				Bitmap _BMP = new Bitmap(Canvas.BackgroundImage);
				FloodFill(_BMP, e.Location, _PrimaryColour);
			}
		}

		// Runs once when the mouse is lifted on canvas
		private void Canvas_MouseUp(object sender, MouseEventArgs e)
		{
			_Editing = false;
			_PrevMousePos = _CurrentMousePos;
            _MouseUp = new Vector2(e.Location.X, e.Location.Y);

			if (Canvas.BackgroundImage != null)
			{
				if (_CurrentTool == _Tool._Line)
				{
					Line((int)_MouseDown.x, (int)_MouseDown.y, (int)_MouseUp.x, (int)_MouseUp.y);
				}
				else if (_CurrentTool == _Tool._Square)
				{
					Line((int)_MouseDown.x, (int)_MouseUp.y, (int)_MouseDown.x, (int)_MouseDown.y);
					Line((int)_MouseUp.x, (int)_MouseDown.y, (int)_MouseDown.x, (int)_MouseDown.y);
					Line((int)_MouseUp.x, (int)_MouseUp.y, (int)_MouseDown.x, (int)_MouseUp.y);
					Line((int)_MouseUp.x, (int)_MouseUp.y, (int)_MouseUp.x, (int)_MouseDown.y);
				}
				else if (_CurrentTool == _Tool._Circle)
				{
					DrawCircle(Canvas.BackgroundImage);
				}
			}
        }

		// Runs when mouse is moved on canvas
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
		{
			_CurrentMousePos.x = e.X;
			_CurrentMousePos.y = e.Y;
		}


        //------------------------------
        //	ToolBar Functions
        //------------------------------
		private void SizeNumUpDown_ValueChanged(object sender, EventArgs e)
		{
            UpdateSize();
        }

        private void UpdateSize()
        {
            _ToolSize = Convert.ToInt32(SizeNumUpDown.Value);
            SizeIndicatorDot.Size = new Size(_ToolSize*2, _ToolSize*2);
            SizeIndicatorDot.Location = new Point(SizeIndicatorPanel.Width / 2 - SizeIndicatorDot.Width / 2, SizeIndicatorPanel.Height / 2 - SizeIndicatorDot.Height / 2);
            SizeIndicatorDot.BackColor = _PrimaryColour;
            SizeIndicatorPanel.BackColor = _SecondaryColour;
        }


        // Square Tool
        private void SquareToolButton_Click(object sender, EventArgs e)
        {
            _CurrentTool = _Tool._Square;
        }

        // Pencil Tool
        private void PencilToolButton_Click(object sender, EventArgs e)
        {
            _CurrentTool = _Tool._Pencil;
        }

        // Brush Tool
        private void BrushToolButton_Click(object sender, EventArgs e)
        {
            _CurrentTool = _Tool._Brush;
        }

        // Bucket Tool
        private void BucketToolButton_Click(object sender, EventArgs e)
        {
            _CurrentTool = _Tool._Bucket;
        }

        // Line Tool
        private void LineToolButton_Click(object sender, EventArgs e)
        {
            _CurrentTool = _Tool._Line;
        }

        // Ellipse Tool
        private void EllipseToolButton_Click(object sender, EventArgs e)
        {
            _CurrentTool = _Tool._Circle;
        }


		//------------------------------
		//	Algorithms Functions
		//------------------------------

		//----------------------
		// Bresenham’s Line Generation Algorithm
		// https://stackoverflow.com/questions/11678693/all-cases-covered-bresenhams-line-algorithm
		//----------------------
		public void Line(int x, int y, int x2, int y2)
		{
			// Postition to mouse
			x = x -= _ToolSize / 2;
			y = y -= _ToolSize / 2;
			x2 = x2 -= _ToolSize / 2;
			y2 = y2 -= _ToolSize / 2;

			Graphics _GraphicImage = Graphics.FromImage(Canvas.BackgroundImage);
			Pen _Pen = new Pen(color: _PrimaryColour, width: _ToolSize);

			int w = x2 - x;
			int h = y2 - y;
			int dx1 = 0, dy1 = 0, dx2 = 0, dy2 = 0;

			if (w < 0) dx1 = -1; else if (w > 0) dx1 = 1;
			if (h < 0) dy1 = -1; else if (h > 0) dy1 = 1;
			if (w < 0) dx2 = -1; else if (w > 0) dx2 = 1;

			int longest = Math.Abs(w);
			int shortest = Math.Abs(h);

			if (!(longest > shortest))
			{
				longest = Math.Abs(h);
				shortest = Math.Abs(w);
				if (h < 0) dy2 = -1; else if (h > 0) dy2 = 1;
				dx2 = 0;
			}

			int numerator = longest >> 1;

			for (int i = 0; i <= longest; i++)
			{
				_GraphicImage.DrawRectangle(_Pen, x, y, _ToolSize, _ToolSize);
				numerator += shortest;
				if (!(numerator < longest))
				{
					numerator -= longest;
					x += dx1;
					y += dy1;
				}
				else
				{
					x += dx2;
					y += dy2;
				}
			}

			_GraphicImage.Dispose();
		}


		void DrawCircle(Image pb)
		{
			Point A = new Point((int)_MouseDown.x, (int)_MouseDown.y);
			Point B = new Point((int)_MouseUp.x, (int)_MouseUp.y);
			int smallSize = (int)ToolSettingNum.Value;

			Bitmap bmp = new Bitmap(pb.Width, pb.Height);

			float angle = -(float)(Math.Atan2(A.Y - B.Y, B.X - A.X) * 180f / Math.PI);
			int longSide = (int)(Math.Sqrt((A.Y - B.Y) * (A.Y - B.Y) + (B.X - A.X) * (B.X - A.X)));
			Point C = new Point((A.X + B.X) / 2, (A.Y + B.Y) / 2);
			Size size = new System.Drawing.Size((int)longSide, smallSize);

			using (Pen pen = new Pen(_PrimaryColour,_ToolSize))
			using (Graphics g = Graphics.FromImage(pb))
			{
				DrawEllipse(g, pen, C, size, angle);
			}
			
		}

		void DrawEllipse(Graphics G, Pen pen, Point center, Size size, float angle)
		{
			int h2 = size.Height / 2;
			int w2 = size.Width / 2;
			Rectangle rect = new Rectangle(new Point(center.X - w2, center.Y - h2), size);

			G.TranslateTransform(center.X, center.Y);
			G.RotateTransform(angle);
			G.TranslateTransform(-center.X, -center.Y);
			G.DrawEllipse(pen, rect);
			G.ResetTransform();
		}

		private static bool ColorMatch(Color a, Color b)
		{
			return (a.ToArgb() & 0xffffff) == (b.ToArgb() & 0xffffff);
		}
		
		void FloodFill(Bitmap bmp, Point pt, Color replacementColor)
		{
			Color targetColor = bmp.GetPixel((int)_MouseDown.x, (int)_MouseDown.y);
			if (targetColor == replacementColor)
			{
				return;
			}
		
			Queue<Point> q = new Queue<Point>();
			q.Enqueue(pt);
			while (q.Count > 0)
			{
				Point n = q.Dequeue();
				if (!ColorMatch(bmp.GetPixel(n.X, n.Y), targetColor))
					continue;
				Point w = n, e = new Point(n.X + 1, n.Y);
				while ((w.X >= 0) && ColorMatch(bmp.GetPixel(w.X, w.Y), targetColor))
				{
					bmp.SetPixel(w.X, w.Y, replacementColor);
					if ((w.Y > 0) && ColorMatch(bmp.GetPixel(w.X, w.Y - 1), targetColor))
						q.Enqueue(new Point(w.X, w.Y - 1));
					if ((w.Y < bmp.Height - 1) && ColorMatch(bmp.GetPixel(w.X, w.Y + 1), targetColor))
						q.Enqueue(new Point(w.X, w.Y + 1));
					w.X--;
				}
				while ((e.X <= bmp.Width - 1) && ColorMatch(bmp.GetPixel(e.X, e.Y), targetColor))
				{
					bmp.SetPixel(e.X, e.Y, replacementColor);
					if ((e.Y > 0) && ColorMatch(bmp.GetPixel(e.X, e.Y - 1), targetColor))
						q.Enqueue(new Point(e.X, e.Y - 1));
					if ((e.Y < bmp.Height - 1) && ColorMatch(bmp.GetPixel(e.X, e.Y + 1), targetColor))
						q.Enqueue(new Point(e.X, e.Y + 1));
					e.X++;
				}
			}
		
			Canvas.BackgroundImage = bmp;
		}
	}
}
//y she bee looking for me gold, spongie bob
