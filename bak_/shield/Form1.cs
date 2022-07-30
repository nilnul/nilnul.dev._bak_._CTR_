using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nilnul.dev._bak_._CTR_.ctr_.bak_.shield
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void shields1_finished()
		{
			enableCtr();
			nilnul.win.ui.act_._FlashX.FlashWindow(this.Handle, false);


		}

		private void shields1_started()
		{
			disableCtr();
		}

		public void disableCtr()
		{
			this.ControlBox = false;

		}
		public void enableCtr()
		{
			this.ControlBox = true;

		}

		

	}
}
