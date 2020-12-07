namespace OOP2_BookStore
{
	partial class MusicCdControl
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtbxSinger = new System.Windows.Forms.TextBox();
			this.txtbxName = new System.Windows.Forms.TextBox();
			this.pctrbxDetail = new System.Windows.Forms.PictureBox();
			this.pctrbxAddToBasket = new System.Windows.Forms.PictureBox();
			this.lbPrice = new System.Windows.Forms.Label();
			this.lbPrice1 = new System.Windows.Forms.Label();
			this.pctrxPhoto = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctrbxDetail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctrbxAddToBasket)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctrxPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.txtbxSinger);
			this.panel1.Controls.Add(this.txtbxName);
			this.panel1.Controls.Add(this.pctrbxDetail);
			this.panel1.Controls.Add(this.pctrbxAddToBasket);
			this.panel1.Controls.Add(this.lbPrice);
			this.panel1.Controls.Add(this.lbPrice1);
			this.panel1.Location = new System.Drawing.Point(3, 120);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(196, 359);
			this.panel1.TabIndex = 8;
			// 
			// txtbxSinger
			// 
			this.txtbxSinger.BackColor = System.Drawing.Color.White;
			this.txtbxSinger.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtbxSinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.txtbxSinger.Location = new System.Drawing.Point(3, 211);
			this.txtbxSinger.Name = "txtbxSinger";
			this.txtbxSinger.ReadOnly = true;
			this.txtbxSinger.Size = new System.Drawing.Size(190, 19);
			this.txtbxSinger.TabIndex = 13;
			this.txtbxSinger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtbxName
			// 
			this.txtbxName.BackColor = System.Drawing.Color.White;
			this.txtbxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
			this.txtbxName.Location = new System.Drawing.Point(6, 160);
			this.txtbxName.Name = "txtbxName";
			this.txtbxName.ReadOnly = true;
			this.txtbxName.Size = new System.Drawing.Size(190, 25);
			this.txtbxName.TabIndex = 12;
			this.txtbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pctrbxDetail
			// 
			this.pctrbxDetail.Image = global::OOP2_BookStore.Properties.Resources.büyüteç_icon_png_5;
			this.pctrbxDetail.Location = new System.Drawing.Point(37, 300);
			this.pctrbxDetail.Name = "pctrbxDetail";
			this.pctrbxDetail.Size = new System.Drawing.Size(56, 49);
			this.pctrbxDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctrbxDetail.TabIndex = 10;
			this.pctrbxDetail.TabStop = false;
			this.pctrbxDetail.Click += new System.EventHandler(this.pctrbxDetail_Click);
			// 
			// pctrbxAddToBasket
			// 
			this.pctrbxAddToBasket.Image = global::OOP2_BookStore.Properties.Resources.addtobasket;
			this.pctrbxAddToBasket.Location = new System.Drawing.Point(118, 300);
			this.pctrbxAddToBasket.Name = "pctrbxAddToBasket";
			this.pctrbxAddToBasket.Size = new System.Drawing.Size(56, 49);
			this.pctrbxAddToBasket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctrbxAddToBasket.TabIndex = 11;
			this.pctrbxAddToBasket.TabStop = false;
			this.pctrbxAddToBasket.Click += new System.EventHandler(this.pctrbxAddToBasket_Click);
			// 
			// lbPrice
			// 
			this.lbPrice.AutoSize = true;
			this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbPrice.Location = new System.Drawing.Point(13, 253);
			this.lbPrice.Name = "lbPrice";
			this.lbPrice.Size = new System.Drawing.Size(70, 20);
			this.lbPrice.TabIndex = 5;
			this.lbPrice.Text = "lbPrice1";
			this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbPrice1
			// 
			this.lbPrice1.AutoSize = true;
			this.lbPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
			this.lbPrice1.Location = new System.Drawing.Point(89, 253);
			this.lbPrice1.Name = "lbPrice1";
			this.lbPrice1.Size = new System.Drawing.Size(99, 26);
			this.lbPrice1.TabIndex = 6;
			this.lbPrice1.Text = "lbPrice1";
			this.lbPrice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pctrxPhoto
			// 
			this.pctrxPhoto.Location = new System.Drawing.Point(16, 3);
			this.pctrxPhoto.Name = "pctrxPhoto";
			this.pctrxPhoto.Size = new System.Drawing.Size(167, 235);
			this.pctrxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctrxPhoto.TabIndex = 9;
			this.pctrxPhoto.TabStop = false;
			this.pctrxPhoto.Click += new System.EventHandler(this.pctrxPhoto_Click);
			// 
			// MusicCdControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pctrxPhoto);
			this.Controls.Add(this.panel1);
			this.Name = "MusicCdControl";
			this.Size = new System.Drawing.Size(202, 481);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctrbxDetail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctrbxAddToBasket)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctrxPhoto)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pctrxPhoto;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbPrice;
		private System.Windows.Forms.Label lbPrice1;
		private System.Windows.Forms.PictureBox pctrbxDetail;
		private System.Windows.Forms.PictureBox pctrbxAddToBasket;
		private System.Windows.Forms.TextBox txtbxSinger;
		private System.Windows.Forms.TextBox txtbxName;
	}
}
