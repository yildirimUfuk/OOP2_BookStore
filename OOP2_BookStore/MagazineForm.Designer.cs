namespace OOP2_BookStore
{
	partial class MagazineForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagazineForm));
			this.lbIssue = new System.Windows.Forms.Label();
			this.lbType = new System.Windows.Forms.Label();
			this.txtbxDescription = new System.Windows.Forms.TextBox();
			this.lbMagazineName = new System.Windows.Forms.Label();
			this.pctrbxCoverPhoto = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pctrbxAddToBasket = new System.Windows.Forms.PictureBox();
			this.lbPrice2 = new System.Windows.Forms.Label();
			this.nudquantity = new System.Windows.Forms.NumericUpDown();
			this.lbPrice = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pctrbxCoverPhoto)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctrbxAddToBasket)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudquantity)).BeginInit();
			this.SuspendLayout();
			// 
			// lbIssue
			// 
			resources.ApplyResources(this.lbIssue, "lbIssue");
			this.lbIssue.Name = "lbIssue";
			// 
			// lbType
			// 
			resources.ApplyResources(this.lbType, "lbType");
			this.lbType.Name = "lbType";
			// 
			// txtbxDescription
			// 
			this.txtbxDescription.BackColor = System.Drawing.Color.White;
			this.txtbxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			resources.ApplyResources(this.txtbxDescription, "txtbxDescription");
			this.txtbxDescription.Name = "txtbxDescription";
			this.txtbxDescription.ReadOnly = true;
			// 
			// lbMagazineName
			// 
			resources.ApplyResources(this.lbMagazineName, "lbMagazineName");
			this.lbMagazineName.Name = "lbMagazineName";
			// 
			// pctrbxCoverPhoto
			// 
			resources.ApplyResources(this.pctrbxCoverPhoto, "pctrbxCoverPhoto");
			this.pctrbxCoverPhoto.Name = "pctrbxCoverPhoto";
			this.pctrbxCoverPhoto.TabStop = false;
			this.pctrbxCoverPhoto.Click += new System.EventHandler(this.pctrbxCoverPhoto_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pctrbxAddToBasket);
			this.panel1.Controls.Add(this.lbPrice2);
			this.panel1.Controls.Add(this.nudquantity);
			this.panel1.Controls.Add(this.lbPrice);
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			// 
			// pctrbxAddToBasket
			// 
			this.pctrbxAddToBasket.Image = global::OOP2_BookStore.Properties.Resources.addtobasket;
			this.pctrbxAddToBasket.InitialImage = global::OOP2_BookStore.Properties.Resources.addtobasket;
			resources.ApplyResources(this.pctrbxAddToBasket, "pctrbxAddToBasket");
			this.pctrbxAddToBasket.Name = "pctrbxAddToBasket";
			this.pctrbxAddToBasket.TabStop = false;
			this.pctrbxAddToBasket.Click += new System.EventHandler(this.pctrbxAddToBasket_Click);
			// 
			// lbPrice2
			// 
			resources.ApplyResources(this.lbPrice2, "lbPrice2");
			this.lbPrice2.Name = "lbPrice2";
			// 
			// nudquantity
			// 
			this.nudquantity.BackColor = System.Drawing.Color.WhiteSmoke;
			resources.ApplyResources(this.nudquantity, "nudquantity");
			this.nudquantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudquantity.Name = "nudquantity";
			this.nudquantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// lbPrice
			// 
			resources.ApplyResources(this.lbPrice, "lbPrice");
			this.lbPrice.Name = "lbPrice";
			// 
			// MagazineForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lbIssue);
			this.Controls.Add(this.lbType);
			this.Controls.Add(this.txtbxDescription);
			this.Controls.Add(this.lbMagazineName);
			this.Controls.Add(this.pctrbxCoverPhoto);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MagazineForm";
			((System.ComponentModel.ISupportInitialize)(this.pctrbxCoverPhoto)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctrbxAddToBasket)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudquantity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lbIssue;
		private System.Windows.Forms.Label lbType;
		private System.Windows.Forms.TextBox txtbxDescription;
		private System.Windows.Forms.Label lbMagazineName;
		private System.Windows.Forms.PictureBox pctrbxCoverPhoto;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pctrbxAddToBasket;
		private System.Windows.Forms.Label lbPrice2;
		private System.Windows.Forms.NumericUpDown nudquantity;
		private System.Windows.Forms.Label lbPrice;
	}
}