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
        //Tools
        private enum _Tool {_Pencil, _Brush, _Bucket, _Line, _Circle, _Square};
        int _CurrentTool = (int)_Tool._Pencil;

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
		Vector2 _MouseDown;
		Vector2 _MouseUp;


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

            UpdateSize();
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

            SizeIndicatorPanel.BackColor = _SecondaryColour;
            SizeIndicatorDot.BackColor = _PrimaryColour;

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

            UpdateSize();
        }

        private void SecondaryColourPanel_MouseDown(object sender, MouseEventArgs e)
		{
			ColorDialog colorPicker = new ColorDialog();

			colorPicker.FullOpen = true;
			colorPicker.ShowDialog();

			_SecondaryColour = colorPicker.Color;
			SecondaryColourPanel.BackColor = _SecondaryColour;

            UpdateSize();
        }

        private void SwapColourPanel_MouseDown(object sender, MouseEventArgs e)
		{
			Color _TempColour = _PrimaryColour;

			_PrimaryColour = _SecondaryColour;
			_SecondaryColour = _TempColour;

			PrimaryColourPanel.BackColor = _PrimaryColour;
			SecondaryColourPanel.BackColor = _SecondaryColour;

            UpdateSize();
		}

		private void Canvas_Paint(object sender, PaintEventArgs e)
		{
			if (_Editing && Canvas.BackgroundImage != null)
			{
				if (_PrevMousePos.x <= 0.0f && _PrevMousePos.y <= 0.0f)
				{
					_PrevMousePos = _CurrentMousePos;
				}

				Graphics _GraphicImage = Graphics.FromImage(Canvas.BackgroundImage);
				Pen _Pen = new Pen(color: _PrimaryColour, width: _ToolSize);
                Brush _Brush = new SolidBrush(color: _PrimaryColour);


                switch (_CurrentTool)
                {
                    case (int)_Tool._Pencil:
                        _GraphicImage.DrawLine(_Pen, _PrevMousePos.x, _PrevMousePos.y, _CurrentMousePos.x, _CurrentMousePos.y);
                        break;
                    default:
                        break;
                }
                

				_GraphicImage.Dispose();

				_PrevMousePos = _CurrentMousePos;
			}
		}

		private void Canvas_MouseDown(object sender, MouseEventArgs e)
		{
			_Editing = true;
			_PrevMousePos = _CurrentMousePos;
            _MouseDown = new Vector2(e.Location.X,e.Location.Y);
		}

		private void Canvas_MouseUp(object sender, MouseEventArgs e)
		{
			_Editing = false;
			_PrevMousePos = _CurrentMousePos;
            _MouseUp = new Vector2(e.Location.X, e.Location.Y);

            if (_CurrentTool == (int)_Tool._Line)
            {
                Graphics _GraphicImage = Graphics.FromImage(Canvas.BackgroundImage);
                Pen _Pen = new Pen(color: _PrimaryColour, width: _ToolSize);
                _GraphicImage.DrawLine(_Pen, _MouseDown.x, _MouseDown.y, _MouseUp.x, _MouseUp.y);
            }
           else if (_CurrentTool == (int)_Tool._Square)
            {
                Graphics _GraphicImage = Graphics.FromImage(Canvas.BackgroundImage);
                Pen _Pen = new Pen(color: _PrimaryColour, width: _ToolSize);

                Point _BRight = new Point((int)_MouseDown.x + (int)_MouseUp.x, (int)_MouseDown.y + (int)_MouseUp.y);

                // Rectangle _Rect = new Rectangle((int)_MouseUp.x, (int)_MouseUp.y, 2, 2);
                _GraphicImage.DrawLine(_Pen, _BRight, e.Location);
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
		{
			_CurrentMousePos.x = ((MouseEventArgs)e).X;
			_CurrentMousePos.y = ((MouseEventArgs)e).Y;
		}

		private void SizeNumUpDown_ValueChanged(object sender, EventArgs e)
		{
            UpdateSize();
        }

        //------------------------------
        //	ToolBar Functions
        //------------------------------
        private void UpdateSize()
        {
            _ToolSize = Convert.ToInt32(SizeNumUpDown.Value);
            SizeIndicatorDot.Size = new Size((int)SizeNumUpDown.Value, (int)SizeNumUpDown.Value);
            SizeIndicatorDot.Location = new Point(SizeIndicatorPanel.Width / 2 - SizeIndicatorDot.Width / 2, SizeIndicatorPanel.Height / 2 - SizeIndicatorDot.Height / 2);
            SizeIndicatorDot.BackColor = _PrimaryColour;
            SizeIndicatorPanel.BackColor = _SecondaryColour;
        }


        // Square Tool
        private void SquareToolButton_Click(object sender, EventArgs e)
        {
            _CurrentTool = (int)_Tool._Square;
        }

        // Pencil Tool
        private void PencilToolButton_Click(object sender, EventArgs e)
        {
            _CurrentTool = (int)_Tool._Pencil;
        }

        // Brush Tool
        private void BrushToolButton_Click(object sender, EventArgs e)
        {
            _CurrentTool = (int)_Tool._Brush;
        }

        // Bucket Tool
        private void BucketToolButton_Click(object sender, EventArgs e)
        {
            _CurrentTool = (int)_Tool._Bucket;
        }

        // Line Tool
        private void LineToolButton_Click(object sender, EventArgs e)
        {
            _CurrentTool = (int)_Tool._Line;
        }

        // Ellipse Tool
        private void EllipseToolButton_Click(object sender, EventArgs e)
        {
            _CurrentTool = (int)_Tool._Circle;
        }
    }
}
//y she bee looking for me gold, spongie bob
