﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nilnul.dev._bak_._CTR_.ctr_.bak_.srcs.statused
{
	public partial class Form1 : Form
	{
		public event Action started;
		public event Action finished;

		public Form1()
		{
			InitializeComponent();
		}



		public void disableCtr()
		{
			this.ControlBox = false;

		}
		public void enableCtr()
		{
			this.ControlBox = true;

		}

		private void retVoid__startOfPar_ShieldsSel11_finished()
		{
			enableCtr();
			finished?.Invoke();
			//_this._BlinkFormX.FlashWindow(this.Handle, false);

		}

		private void retVoid__startOfPar_ShieldsSel11_started()
		{
			disableCtr();
			started?.Invoke();

		}
	}
}
