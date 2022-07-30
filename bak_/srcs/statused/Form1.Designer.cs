
namespace nilnul.dev._bak_._CTR_.ctr_.bak_.srcs.statused
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.bak__srcs_Statused1 = new nilnul.dev._bak_._CTR_.ctr_.bak_.srcs.bak__srcs_Statused();
			this.SuspendLayout();
			// 
			// bak__srcs_Statused1
			// 
			resources.ApplyResources(this.bak__srcs_Statused1, "bak__srcs_Statused1");
			this.bak__srcs_Statused1.Name = "bak__srcs_Statused1";
			this.bak__srcs_Statused1.started += new System.Action(this.retVoid__startOfPar_ShieldsSel11_started);
			this.bak__srcs_Statused1.finished += new System.Action(this.retVoid__startOfPar_ShieldsSel11_finished);
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.bak__srcs_Statused1);
			this.Name = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private bak__srcs_Statused bak__srcs_Statused1;
	}
}