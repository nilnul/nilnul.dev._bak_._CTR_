using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nilnul.dev._bak_._CTR_.ctr_._cfg_.sema
{
	public partial class _cfg__sema_Save : UserControl
	{
		public _cfg__sema_Save()
		{
			InitializeComponent();
		}

		private void Save_Click(object sender, EventArgs e)
		{
			try
			{
				nilnul.dev.bak.Properties.Settings.Default.semaphore = (int)(_cfg__Semaphore1.val);
				nilnul.dev.bak.Properties.Settings.Default.Save();

			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
