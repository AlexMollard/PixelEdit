using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelArt
{
	class ToolBar
	{
		// Editing space
		Panel _PanelEditingSpace;

		// Zoom
		Button _ButtonZoomIn;
		Button _ButtonZoomOut;
		int _CurrentZoom = 1;

		// Scale
		Button _ButtonScaleUp;
		Button _ButtonScaleDown;

		// Colour Picker Panel
		Panel _PanelColourPicker;


		public ToolBar(Panel _PanelEditingSpace, Button _ButtonZoomIn, Button _ButtonZoomOut, Button _ButtonScaleUp, Button _ButtonScaleDown, Panel _PanelColourPicker)
		{
			// Editing space
			this._PanelEditingSpace = _PanelEditingSpace;

			// Zoom Button
			this._ButtonZoomIn = _ButtonZoomIn;
			this._ButtonZoomOut = _ButtonZoomOut;

			// Scale Button
			this._ButtonScaleUp = _ButtonScaleUp;
			this._ButtonScaleDown = _ButtonScaleDown;

			// Colour Picker Panel
			this._PanelColourPicker = _PanelColourPicker;
		}

		// Scale Image
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

		//Scale
		public void ScaleUp(object sender, EventArgs e) // Scale up 25%
		{
			if (_PanelEditingSpace.BackgroundImage != null)
			{
				_PanelEditingSpace.BackgroundImage = ScaleByPercent(_PanelEditingSpace.BackgroundImage, 125);
			}
		}

		public void ScaleDown(object sender, EventArgs e) // Scale down 25%
		{
			if (_PanelEditingSpace.BackgroundImage != null)
			{
				_PanelEditingSpace.BackgroundImage = ScaleByPercent(_PanelEditingSpace.BackgroundImage, 75);
			}
		}

		//Zoom
		public void ZoomIn(object sender, EventArgs e)
		{

			int _Zoom = _CurrentZoom += 1;

			_CurrentZoom = _Zoom;

			_PanelEditingSpace.AutoScrollMinSize = new Size(_PanelEditingSpace.BackgroundImage.Width * _Zoom, _PanelEditingSpace.BackgroundImage.Height * _Zoom);

            if (_CurrentZoom < 1)
            {
                _CurrentZoom = 1;
            }
        }

		public void ZoomOut(object sender, EventArgs e)
		{

			int _Zoom = _CurrentZoom -= 1;

			_CurrentZoom = _Zoom;

			_PanelEditingSpace.AutoScrollMinSize = new Size(_PanelEditingSpace.BackgroundImage.Width * _Zoom, _PanelEditingSpace.BackgroundImage.Height * _Zoom);

            if (_CurrentZoom < 1)
            {
                _CurrentZoom = 1;
            }
        }

        public int UpdateZoom(object sender, PaintEventArgs e)
        {
            // Update Zoom
            using (Matrix mx = new Matrix(_CurrentZoom, 0, 0, _CurrentZoom, 0, 0))
            {
                mx.Translate(_PanelEditingSpace.AutoScrollPosition.X / _CurrentZoom, _PanelEditingSpace.AutoScrollPosition.Y / _CurrentZoom);
                e.Graphics.Transform = mx;
                e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor; 
                e.Graphics.DrawImage(_PanelEditingSpace.BackgroundImage, new Point(x: 0, y: 0));
            }

            return _CurrentZoom;
        }
	}
}
