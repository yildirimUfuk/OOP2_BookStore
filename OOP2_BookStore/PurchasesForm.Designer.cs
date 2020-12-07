namespace OOP2_BookStore
{
	partial class PurchasesForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchasesForm));
			this.flpdetails = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// flpdetails
			// 
			this.flpdetails.AutoScroll = true;
			this.flpdetails.Location = new System.Drawing.Point(12, 12);
			this.flpdetails.Name = "flpdetails";
			this.flpdetails.Size = new System.Drawing.Size(587, 571);
			this.flpdetails.TabIndex = 0;
			// 
			// PurchasesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 601);
			this.Controls.Add(this.flpdetails);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PurchasesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PurchasesForm";
			this.Load += new System.EventHandler(this.PurchasesForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flpdetails;
	}
}