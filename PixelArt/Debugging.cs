using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelArt
{
	public partial class Debugging : Form
	{
		int i = 0;
		public Debugging()
		{
			InitializeComponent();

		}

		public void UpdateWindow(object sender, EventArgs e)
		{
			i++;

			MouseX.Text = Convert.ToString(i);

			//MouseX.Text = Form1.;
		}

	}
}
