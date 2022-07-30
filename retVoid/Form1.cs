﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nilnul.dev._bak_._CTR_.ctr_.retVoid
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.shields1.started += shields1_started;
			this.shields1.finished += shields1_finished;
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
