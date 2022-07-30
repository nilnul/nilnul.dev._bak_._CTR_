using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nilnul.dev._bak_._CTR_.ctr_.retVoid_.startOfPar.shieldsSel
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

		private void shieldsBakedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.panel1.Controls.Clear();
			this.panel1.Controls.Add( new ctr_._cfg_.ShieldsBaked() { Dock= DockStyle.Fill});
		}

		private void bakToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.panel1.Controls.Clear();
			this.panel1.Controls.Add(shields1);
		}

		private void modulesBakedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.panel1.Controls.Clear();
			this.panel1.Controls.Add( new ctr_._cfg_.ModulesBaked() { Dock= DockStyle.Fill});

		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.panel1.Controls.Clear();
			this.panel1.Controls.Add( new ctr_._cfg_._cfg__Srcs() { Dock= DockStyle.Fill});

		}

		private void shieldsNotBakedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.panel1.Controls.Clear();
			this.panel1.Controls.Add( new ctr_._cfg_.ShieldsNotBaked() { Dock= DockStyle.Fill});

		}

		private void modulesNotBakedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.panel1.Controls.Clear();
			this.panel1.Controls.Add( new ctr_._cfg_.ModulesNotBaked() { Dock= DockStyle.Fill});

		}
	}
}
