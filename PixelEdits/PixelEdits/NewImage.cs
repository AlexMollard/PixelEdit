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
	public partial class NewImage : Form
	{

		Timer _GameTimer = new Timer();

		decimal _WidthValue = 0;
		decimal _HeightValue = 0;


		public NewImage(decimal _CurrentWidth, decimal _CurrentHeight)
		{
			InitializeComponent();

			_GameTimer.Interval = 30;
			_GameTimer.Tick += Update;
			_GameTimer.Start();

			WidthTextBox.Value = _CurrentWidth;
			HeightTextBox.Value = _CurrentHeight;

		}

		private void Update(object sender, EventArgs e)
		{
			if (SquareCheckBox.Checked == true)
			{
				if (HeightTextBox.Value != _HeightValue)
				{
					WidthTextBox.Value = HeightTextBox.Value;
					_HeightValue = HeightTextBox.Value;
				}
				else if (WidthTextBox.Value != _WidthValue)
				{
					HeightTextBox.Value = WidthTextBox.Value;
					_WidthValue = WidthTextBox.Value;
				}
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void SquareCheckBox_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void WidthTextBox_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}
