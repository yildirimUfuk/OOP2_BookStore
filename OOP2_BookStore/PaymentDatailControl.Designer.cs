namespace OOP2_BookStore
{
	partial class PaymentDatailControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbDate = new System.Windows.Forms.Label();
			this.lwproductlist = new System.Windows.Forms.ListView();
			this.clindex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clquantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lbtotal = new System.Windows.Forms.Label();
			this.lbShip = new System.Windows.Forms.Label();
			this.txtbxAdress = new System.Windows.Forms.TextBox();
			this.lbAdress = new System.Windows.Forms.Label();
			this.lbOrderName = new System.Windows.Forms.Label();
			this.lbInvoiceID = new System.Windows.Forms.Label();
			this.lbLogo = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lbDate
			// 
			this.lbDate.AutoSize = true;
			this.lbDate.Location = new System.Drawing.Point(12, 134);
			this.lbDate.Name = "lbDate";
			this.lbDate.Size = new System.Drawing.Size(46, 17);
			this.lbDate.TabIndex = 0;
			this.lbDate.Text = "label1";
			// 
			// lwproductlist
			// 
			this.lwproductlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lwproductlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clindex,
            this.clProductName,
            this.clquantity,
            this.clPrice});
			this.lwproductlist.Location = new System.Drawing.Point(15, 157);
			this.lwproductlist.Name = "lwproductlist";
			this.lwproductlist.Size = new System.Drawing.Size(522, 333);
			this.lwproductlist.TabIndex = 1;
			this.lwproductlist.UseCompatibleStateImageBehavior = false;
			this.lwproductlist.View = System.Windows.Forms.View.Details;
			// 
			// clindex
			// 
			this.clindex.Text = "";
			this.clindex.Width = 10;
			// 
			// clProductName
			// 
			this.clProductName.Text = "Name";
			this.clProductName.Width = 120;
			// 
			// clquantity
			// 
			this.clquantity.Text = "Quantity";
			this.clquantity.Width = 120;
			// 
			// clPrice
			// 
			this.clPrice.Text = "Price";
			this.clPrice.Width = 120;
			// 
			// lbtotal
			// 
			this.lbtotal.AutoSize = true;
			this.lbtotal.Location = new System.Drawing.Point(307, 524);
			this.lbtotal.Name = "lbtotal";
			this.lbtotal.Size = new System.Drawing.Size(52, 17);
			this.lbtotal.TabIndex = 2;
			this.lbtotal.Text = "Total : ";
			// 
			// lbShip
			// 
			this.lbShip.AutoSize = true;
			this.lbShip.Location = new System.Drawing.Point(280, 498);
			this.lbShip.Name = "lbShip";
			this.lbShip.Size = new System.Drawing.Size(79, 17);
			this.lbShip.TabIndex = 3;
			this.lbShip.Text = "Shipment : ";
			// 
			// txtbxAdress
			// 
			this.txtbxAdress.BackColor = System.Drawing.Color.White;
			this.txtbxAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtbxAdress.Location = new System.Drawing.Point(283, 10);
			this.txtbxAdress.Multiline = true;
			this.txtbxAdress.Name = "txtbxAdress";
			this.txtbxAdress.Size = new System.Drawing.Size(254, 141);
			this.txtbxAdress.TabIndex = 4;
			// 
			// lbAdress
			// 
			this.lbAdress.AutoSize = true;
			this.lbAdress.Location = new System.Drawing.Point(213, 10);
			this.lbAdress.Name = "lbAdress";
			this.lbAdress.Size = new System.Drawing.Size(64, 17);
			this.lbAdress.TabIndex = 5;
			this.lbAdress.Text = "Adress : ";
			// 
			// lbOrderName
			// 
			this.lbOrderName.AutoSize = true;
			this.lbOrderName.Location = new System.Drawing.Point(12, 105);
			this.lbOrderName.Name = "lbOrderName";
			this.lbOrderName.Size = new System.Drawing.Size(46, 17);
			this.lbOrderName.TabIndex = 6;
			this.lbOrderName.Text = "label1";
			// 
			// lbInvoiceID
			// 
			this.lbInvoiceID.AutoSize = true;
			this.lbInvoiceID.Location = new System.Drawing.Point(12, 76);
			this.lbInvoiceID.Name = "lbInvoiceID";
			this.lbInvoiceID.Size = new System.Drawing.Size(46, 17);
			this.lbInvoiceID.TabIndex = 6;
			this.lbInvoiceID.Text = "label1";
			// 
			// lbLogo
			// 
			this.lbLogo.AutoSize = true;
			this.lbLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
			this.lbLogo.Location = new System.Drawing.Point(69, 1);
			this.lbLogo.Name = "lbLogo";
			this.lbLogo.Size = new System.Drawing.Size(109, 67);
			this.lbLogo.TabIndex = 8;
			this.lbLogo.Text = "BS";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::OOP2_BookStore.Properties.Resources.logo1;
			this.pictureBox1.Location = new System.Drawing.Point(15, 10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(62, 52);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// PaymentDatailControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lbInvoiceID);
			this.Controls.Add(this.lbOrderName);
			this.Controls.Add(this.lbAdress);
			this.Controls.Add(this.txtbxAdress);
			this.Controls.Add(this.lbShip);
			this.Controls.Add(this.lbtotal);
			this.Controls.Add(this.lwproductlist);
			this.Controls.Add(this.lbDate);
			this.Controls.Add(this.lbLogo);
			this.Name = "PaymentDatailControl";
			this.Size = new System.Drawing.Size(554, 556);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbDate;
		private System.Windows.Forms.ListView lwproductlist;
		private System.Windows.Forms.ColumnHeader clProductName;
		private System.Windows.Forms.ColumnHeader clquantity;
		private System.Windows.Forms.ColumnHeader clPrice;
		private System.Windows.Forms.ColumnHeader clindex;
		private System.Windows.Forms.Label lbtotal;
		private System.Windows.Forms.Label lbShip;
		private System.Windows.Forms.TextBox txtbxAdress;
		private System.Windows.Forms.Label lbAdress;
		private System.Windows.Forms.Label lbOrderName;
		private System.Windows.Forms.Label lbInvoiceID;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbLogo;
	}
}
