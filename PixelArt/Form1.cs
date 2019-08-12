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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelArt
{

	public partial class PixelEdit : Form
	{
		private string _LastFileName = "";
		Color _SelectedColour = Color.White;

		System.Windows.Forms.Timer _GameTimer = new System.Windows.Forms.Timer();

		bool _Drawing = false;
		int _CurrentZoom = 1;
		int _BrushSize = 1;

		//New Sizes
		int _NewSizeX = 32;
		int _NewSizeY = 32;
		int _CurrentFrame = 0;

		bool _Debugger = false;


		string _DebugMouseXPos = "";
		string _DebugMouseYPos = "";

		Vector2 _PrevMousePos;
		Vector2 _CurrentMousePos;

		ToolBar _ToolBar = null;

		public PixelEdit()
		{
			// Create Form
			InitializeComponent();

			// Create Tool Bar
			_ToolBar = new ToolBar(EditingSpace, ZoomInButton, ZoomOutButton, button1, button2, SelectedColourIndicator);

			// Set up double buffer
			typeof(Panel).InvokeMember("DoubleBuffered",
			BindingFlags.SetProperty
			| BindingFlags.Instance
			| BindingFlags.NonPublic,
			null, EditingSpace, new object[] { true });

			// Setup Update function
			_GameTimer.Interval = 1;
			_GameTimer.Tick += Update;
			_GameTimer.Start();
		}

		Debugging _FormDebugging = new Debugging();
		public void StartDebug()
		{
			Application.Run(_FormDebugging);
		}

		public void TransferData(string text1, string text2, string text3)
		{
			if (_FormDebugging.MouseX.InvokeRequired)
				_FormDebugging.MouseX.Invoke((MethodInvoker)delegate ()
				{
					TransferData(text1, text2, text3);
				});
			else
			{
				_FormDebugging.MouseX.Text = text1;
				_FormDebugging.MouseY.Text = text2;
				_FormDebugging.TestingLabel.Text = text3;
			}
		}

		public void Close()
		{
			if (_FormDebugging.MouseX.InvokeRequired)
				_FormDebugging.MouseX.Invoke((MethodInvoker)delegate ()
				{
					Close();
				});
			else
				_FormDebugging.Close();
		}

		private void button3_Click_1(object sender, EventArgs e) //Debug Button
		{
			//Thread Stuff
			Thread _FrmDebug = new Thread(new ThreadStart(StartDebug));
			_FrmDebug.Start();
			_Debugger = true;
		}

		private void Update(object sender, EventArgs e)
		{
			EditingSpace.Refresh();
			_CurrentFrame++;

			if (_Debugger)
			{
				UpdateDebugging();
			}

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			EditingSpace.AutoScrollMinSize = new Size();
		}

		private void pictureBox5_Click(object sender, EventArgs e) // NewFile
		{
			NewImage _Settings = new NewImage(EditingSpace.Width,EditingSpace.Height);
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

		private void EditingSpace_MouseDown(object sender, MouseEventArgs e)
		{
			_Drawing = true;
			_CurrentMousePos = new Vector2(GetMousePos(e.Location).X, GetMousePos(e.Location).Y);
			_PrevMousePos = _CurrentMousePos;
		}

		private void EditingSpace_Paint(object sender, PaintEventArgs e)
		{
			//Drawing
			if (EditingSpace.BackgroundImage != null)
			{
				if (_Drawing)
				{
					if(_PrevMousePos.x <= 0.0f && _PrevMousePos.y <= 0.0f)
					{
						_PrevMousePos = _CurrentMousePos;
					}

					Graphics _GraphicImage = Graphics.FromImage(EditingSpace.BackgroundImage);
					Pen _Pen = new Pen(color: _SelectedColour, width: _BrushSize);

					_GraphicImage.DrawLine(_Pen,_PrevMousePos.x,_PrevMousePos.y,_CurrentMousePos.x,_CurrentMousePos.y);
					_GraphicImage.Dispose();

					_PrevMousePos = _CurrentMousePos;
				}

                // Update Zoom
               _CurrentZoom = _ToolBar.UpdateZoom(sender, e);

            }

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

		private void EditingSpace_MouseUp(object sender, MouseEventArgs e)
		{
			_Drawing = false;
		}

		private void EditingSpace_MouseMove(object sender, MouseEventArgs e)
		{
			if (_Drawing)
			{
				_CurrentMousePos = new Vector2(GetMousePos(e.Location).X, GetMousePos(e.Location).Y);
			}
			_DebugMouseXPos = Convert.ToString(GetMousePos(e.Location).X);
			_DebugMouseYPos = Convert.ToString(GetMousePos(e.Location).Y);
		}

		private void SelectedColourIndicator_MouseDown(object sender, MouseEventArgs e)
		{
			ColorDialog colorPicker = new ColorDialog();

			colorPicker.FullOpen = true;
			colorPicker.ShowDialog();

			_SelectedColour = colorPicker.Color;
			SelectedColourIndicator.BackColor = _SelectedColour;
		}

		void UpdateDebugging()
		{
			TransferData(_DebugMouseXPos, _DebugMouseYPos, Convert.ToString(_CurrentFrame));
		}

		private void PixelEdit_FormClosing(object sender, FormClosingEventArgs e)
		{
			Close();
		}

		private void EditingSpace_DragDrop(object sender, DragEventArgs e)
		{
			EditingSpace.BackgroundImage = (Image)e.Data.GetData(DataFormats.Bitmap);
		}

		private void EditingSpace_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Bitmap))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		//--------------------------------------------------
		///	TOOL BAR
		//--------------------------------------------------

		// Scale
		private void button1_Click(object sender, EventArgs e) // Scale up
		{
			_ToolBar.ScaleUp(sender, e);
		}

		private void button2_Click(object sender, EventArgs e) // Scale down
		{
			_ToolBar.ScaleDown(sender,e);
		}


		// Zoom
		private void ZoomInButton_Click(object sender, EventArgs e) // Zoom In
		{
			_ToolBar.ZoomIn(sender, e);
		}

		private void ZoomOutButton_Click(object sender, EventArgs e) // Zoom Out
		{
			_ToolBar.ZoomOut(sender, e);
		}

		// Brush Size
		private void BrushSizeBar_Scroll(object sender, EventArgs e)
		{
			SizeIndicator.Text = Convert.ToString(BrushSizeBar.Value);
			_BrushSize = BrushSizeBar.Value;
		}

		// Colour Indicator
		private void panel1_Paint_1(object sender, PaintEventArgs e)
		{
			SelectedColourIndicator.BackColor = _SelectedColour;
		}

        private void GridButton_Click(object sender, EventArgs e)
        {
            if (EditingSpace.BackgroundImage != null)
            {
                Bitmap _GridBitMap = new Bitmap(EditingSpace.BackgroundImage.Width, EditingSpace.BackgroundImage.Height);

                Graphics _GridImage = Graphics.FromImage(_GridBitMap);
                Pen _GridPen = new Pen(color: Color.Black, width: 1);

                for (int i = 0; i < EditingSpace.BackgroundImage.Width; i += 2)
                {
                    _GridImage.DrawLine(_GridPen, i, 0, i, EditingSpace.BackgroundImage.Width);
                }

                for (int i = 0; i < EditingSpace.BackgroundImage.Height; i += 2)
                {
                    _GridImage.DrawLine(_GridPen, 0, i, EditingSpace.BackgroundImage.Height, i);
                }

                _GridImage.Dispose();
            }
        }
    }
}
