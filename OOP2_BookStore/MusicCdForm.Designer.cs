namespace OOP2_BookStore
{
	partial class MusicCdForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.pctrbxAddToBasket = new System.Windows.Forms.PictureBox();
			this.lbPrice2 = new System.Windows.Forms.Label();
			this.nudquantity = new System.Windows.Forms.NumericUpDown();
			this.lbPrice = new System.Windows.Forms.Label();
			this.lbsinger = new System.Windows.Forms.Label();
			this.lbType = new System.Windows.Forms.Label();
			this.txtbxDescription = new System.Windows.Forms.TextBox();
			this.lbMusicCDName = new System.Windows.Forms.Label();
			this.pctrbxCoverPhoto = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctrbxAddToBasket)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudquantity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctrbxCoverPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pctrbxAddToBasket);
			this.panel1.Controls.Add(this.lbPrice2);
			this.panel1.Controls.Add(this.nudquantity);
			this.panel1.Controls.Add(this.lbPrice);
			this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.panel1.Location = new System.Drawing.Point(456, 362);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(303, 168);
			this.panel1.TabIndex = 26;
			// 
			// pctrbxAddToBasket
			// 
			this.pctrbxAddToBasket.Image = global::OOP2_BookStore.Properties.Resources.addtobasket;
			this.pctrbxAddToBasket.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pctrbxAddToBasket.InitialImage = global::OOP2_BookStore.Properties.Resources.addtobasket;
			this.pctrbxAddToBasket.Location = new System.Drawing.Point(143, 81);
			this.pctrbxAddToBasket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pctrbxAddToBasket.Name = "pctrbxAddToBasket";
			this.pctrbxAddToBasket.Size = new System.Drawing.Size(91, 66);
			this.pctrbxAddToBasket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctrbxAddToBasket.TabIndex = 11;
			this.pctrbxAddToBasket.TabStop = false;
			this.pctrbxAddToBasket.Click += new System.EventHandler(this.pctrbxAddToBasket_Click);
			// 
			// lbPrice2
			// 
			this.lbPrice2.AutoSize = true;
			this.lbPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.lbPrice2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbPrice2.Location = new System.Drawing.Point(139, 39);
			this.lbPrice2.Name = "lbPrice2";
			this.lbPrice2.Size = new System.Drawing.Size(82, 29);
			this.lbPrice2.TabIndex = 9;
			this.lbPrice2.Text = "Price2";
			this.lbPrice2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// nudquantity
			// 
			this.nudquantity.BackColor = System.Drawing.Color.WhiteSmoke;
			this.nudquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.nudquantity.Location = new System.Drawing.Point(64, 94);
			this.nudquantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.nudquantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudquantity.Name = "nudquantity";
			this.nudquantity.Size = new System.Drawing.Size(68, 34);
			this.nudquantity.TabIndex = 7;
			this.nudquantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// lbPrice
			// 
			this.lbPrice.AutoSize = true;
			this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Strikeout);
			this.lbPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbPrice.Location = new System.Drawing.Point(92, 25);
			this.lbPrice.Name = "lbPrice";
			this.lbPrice.Size = new System.Drawing.Size(40, 17);
			this.lbPrice.TabIndex = 9;
			this.lbPrice.Text = "Price";
			// 
			// lbsinger
			// 
			this.lbsinger.AutoSize = true;
			this.lbsinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.lbsinger.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbsinger.Location = new System.Drawing.Point(12, 388);
			this.lbsinger.Name = "lbsinger";
			this.lbsinger.Size = new System.Drawing.Size(111, 26);
			this.lbsinger.TabIndex = 25;
			this.lbsinger.Text = "Singer : ...";
			// 
			// lbType
			// 
			this.lbType.AutoSize = true;
			this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.lbType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbType.Location = new System.Drawing.Point(12, 422);
			this.lbType.Name = "lbType";
			this.lbType.Size = new System.Drawing.Size(95, 26);
			this.lbType.TabIndex = 24;
			this.lbType.Text = "Type : ...";
			// 
			// txtbxDescription
			// 
			this.txtbxDescription.BackColor = System.Drawing.Color.White;
			this.txtbxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtbxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.txtbxDescription.Location = new System.Drawing.Point(257, 82);
			this.txtbxDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtbxDescription.Multiline = true;
			this.txtbxDescription.Name = "txtbxDescription";
			this.txtbxDescription.ReadOnly = true;
			this.txtbxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtbxDescription.Size = new System.Drawing.Size(540, 230);
			this.txtbxDescription.TabIndex = 23;
			// 
			// lbMusicCDName
			// 
			this.lbMusicCDName.AutoSize = true;
			this.lbMusicCDName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.lbMusicCDName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbMusicCDName.Location = new System.Drawing.Point(257, 26);
			this.lbMusicCDName.Name = "lbMusicCDName";
			this.lbMusicCDName.Size = new System.Drawing.Size(265, 39);
			this.lbMusicCDName.TabIndex = 22;
			this.lbMusicCDName.Text = "Music CD Name";
			// 
			// pctrbxCoverPhoto
			// 
			this.pctrbxCoverPhoto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pctrbxCoverPhoto.Location = new System.Drawing.Point(12, 26);
			this.pctrbxCoverPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pctrbxCoverPhoto.Name = "pctrbxCoverPhoto";
			this.pctrbxCoverPhoto.Size = new System.Drawing.Size(239, 286);
			this.pctrbxCoverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctrbxCoverPhoto.TabIndex = 21;
			this.pctrbxCoverPhoto.TabStop = false;
			// 
			// MusicCdForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(808, 558);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lbsinger);
			this.Controls.Add(this.lbType);
			this.Controls.Add(this.txtbxDescription);
			this.Controls.Add(this.lbMusicCDName);
			this.Controls.Add(this.pctrbxCoverPhoto);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MusicCdForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MusicCdForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctrbxAddToBasket)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudquantity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctrbxCoverPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pctrbxAddToBasket;
		private System.Windows.Forms.Label lbPrice2;
		private System.Windows.Forms.NumericUpDown nudquantity;
		private System.Windows.Forms.Label lbPrice;
		private System.Windows.Forms.Label lbsinger;
		private System.Windows.Forms.Label lbType;
		private System.Windows.Forms.TextBox txtbxDescription;
		private System.Windows.Forms.Label lbMusicCDName;
		private System.Windows.Forms.PictureBox pctrbxCoverPhoto;
	}
}