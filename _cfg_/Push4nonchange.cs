﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nilnul.dev._bak_._CTR_._cfg_
{
	public partial class _cfg__Push4nonchange : UserControl
	{
		public _cfg__Push4nonchange()
		{
			InitializeComponent();
		}

		private void Push4nonchange_Load(object sender, EventArgs e)
		{
			this.checkBox1.Checked = nilnul.dev.bak.nilnul0.dev.src.sln.div_.unjoint_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone_.primed._bak_._upload.Settings1.Default.push4nonchange;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
nilnul.dev.bak.nilnul0.dev.src.sln.div_.unjoint_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone_.primed._bak_._upload.Settings1.Default.push4nonchange=this.checkBox1.Checked
=
			this.checkBox1.Checked  				;

			nilnul.dev.bak.nilnul0.dev.src.sln.div_.unjoint_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone_.primed._bak_._upload.Settings1.Default.Save();

		}
	}
}
