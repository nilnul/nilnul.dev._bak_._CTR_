﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Specialized;

namespace nilnul.dev._bak_._CTR_.ctr_.bak_._module_.start
{
	public partial class bak___module__start_Cancel : UserControl
	{
		public event Action started;
		public event Action finished;

		public event Action start;

		public bak___module__start_Cancel()
		{
			InitializeComponent();
		}

		private void showCancel()
		{
			this.start1.Hide();
			this.cancel1.reset();
			this.cancel1.Show();
			this.cancel1.Dock = DockStyle.Fill;
		}

		/// <summary>
		/// 
		/// </summary>
		/// shall be disposed. or it will be disposed with this control.
		public CancellationTokenSource source = new CancellationTokenSource();


		//private void Form1_Load(object sender, EventArgs e)
		//{

		//}

		private void start1_Load(object sender, EventArgs e)
		{
			//this.start1.click += start1_click;
			
		}



		//public string shield { get; set; }

		public void bak(string shieldAddresses) {
			


			started?.Invoke();

			showCancel();
			start1.begin(
				(shieldAddresses)
				,
				source.Token
			);

			//var task=Task.Run(()=>start1.begin(folders2bak, source.Token  ));

			//task.ContinueWith((t) => {
			//	cancel1.btnCancelled();
			//});


			//throw new NotImplementedException();

			//start1.finished += start1_finished;

		}

		//public void bak() {
		//	var shields2bak = nilnul.dev.srcs.bak_._retVoid.SettingX.shields2bak;
		//	bak(shields2bak.Cast<string>());
		//}

		private void start1_click()
		{
			//bak();
			start?.Invoke();

			//var shields2bak = nilnul.dev.srcs.bak_._retVoid.Settings1.Default.Properties[nameof(nilnul.dev.srcs.bak_._retVoid.Settings1.shields2bak)].DefaultValue as StringCollection;


		}

		public void reshowStart()
		{
			this.cancel1.Hide();
			this.start1.reset();
			this.start1.Show();
			this.start1.Dock = DockStyle.Fill;

		}

		private void start1_finished()
		{
			this.Text = "Finished!";
			this.BackColor = Color.Beige;
			this.cancel1.btnCancelled();
			reshowStart();
			finished?.Invoke();


		}

		public void disable() {
			this.start1.disable();
		}
		public void enable() {
			this.start1.enable();
		}
		private void cancel1_Load(object sender, EventArgs e)
		{
			//cancel1.click += cancel1_click;
		}

		private void cancel1_click()
		{
			cancel1.cancel(source);
			//throw new NotImplementedException();
		}

		
	}
}
