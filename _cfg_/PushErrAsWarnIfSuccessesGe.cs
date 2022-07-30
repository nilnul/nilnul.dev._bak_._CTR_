using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nilnul.dev._bak_._CTR_.ctr_._cfg_
{
	public partial class _cfg__PushErrAsWarnIfSuccessesGe: UserControl
	{
		public _cfg__PushErrAsWarnIfSuccessesGe()
		{

			InitializeComponent();
			//load the settings
			this.numericUpDown1.Value = nilnul.dev.bak.Properties.Settings.Default.pushErrsAsWarningIfSuccessesGe;

		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			 nilnul.dev.bak.Properties.Settings.Default.pushErrsAsWarningIfSuccessesGe= (uint)this.numericUpDown1.Value ;


		}
		public decimal val {
			get {
				return this.numericUpDown1.Value;
			}
			set {
				this.numericUpDown1.Value = value;
			}
		}
	}
}
