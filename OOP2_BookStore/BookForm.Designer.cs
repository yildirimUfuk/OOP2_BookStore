namespace OOP2_BookStore
{
	partial class BookForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
			this.lbBookName = new System.Windows.Forms.Label();
			this.lbBookAuthor = new System.Windows.Forms.Label();
			this.lbPublisher = new System.Windows.Forms.Label();
			this.lbNoOfPage = new System.Windows.Forms.Label();
			this.txtbxDescription = new System.Windows.Forms.TextBox();
			this.lbType = new System.Windows.Forms.Label();
			this.lbLanguage = new System.Windows.Forms.Label();
			this.lbSize = new System.Windows.Forms.Label();
			this.nudquantity = new System.Windows.Forms.NumericUpDown();
			this.lbPrice = new System.Windows.Forms.Label();
			this.lbPrice2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pctrbxAddToBasket = new System.Windows.Forms.PictureBox();
			this.pctrbxCoverPhoto = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.nudquantity)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctrbxAddToBasket)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctrbxCoverPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// lbBookName
			// 
			this.lbBookName.AutoSize = true;
			this.lbBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbBookName.Location = new System.Drawing.Point(257, 12);
			this.lbBookName.Name = "lbBookName";
			this.lbBookName.Size = new System.Drawing.Size(195, 39);
			this.lbBookName.TabIndex = 1;
			this.lbBookName.Text = "Book Name";
			// 
			// lbBookAuthor
			// 
			this.lbBookAuthor.AutoSize = true;
			this.lbBookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.lbBookAuthor.Location = new System.Drawing.Point(12, 316);
			this.lbBookAuthor.Name = "lbBookAuthor";
			this.lbBookAuthor.Size = new System.Drawing.Size(112, 26);
			this.lbBookAuthor.TabIndex = 2;
			this.lbBookAuthor.Text = "Author : ...";
			// 
			// lbPublisher
			// 
			this.lbPublisher.AutoSize = true;
			this.lbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.lbPublisher.Location = new System.Drawing.Point(12, 357);
			this.lbPublisher.Name = "lbPublisher";
			this.lbPublisher.Size = new System.Drawing.Size(127, 26);
			this.lbPublisher.TabIndex = 2;
			this.lbPublisher.Text = "Publisher :..";
			// 
			// lbNoOfPage
			// 
			this.lbNoOfPage.AutoSize = true;
			this.lbNoOfPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.lbNoOfPage.Location = new System.Drawing.Point(12, 398);
			this.lbNoOfPage.Name = "lbNoOfPage";
			this.lbNoOfPage.Size = new System.Drawing.Size(93, 26);
			this.lbNoOfPage.TabIndex = 2;
			this.lbNoOfPage.Text = "Page :...";
			// 
			// txtbxDescription
			// 
			this.txtbxDescription.BackColor = System.Drawing.Color.White;
			this.txtbxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtbxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.txtbxDescription.Location = new System.Drawing.Point(257, 75);
			this.txtbxDescription.Multiline = true;
			this.txtbxDescription.Name = "txtbxDescription";
			this.txtbxDescription.ReadOnly = true;
			this.txtbxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtbxDescription.Size = new System.Drawing.Size(540, 223);
			this.txtbxDescription.TabIndex = 3;
			// 
			// lbType
			// 
			this.lbType.AutoSize = true;
			this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.lbType.Location = new System.Drawing.Point(12, 439);
			this.lbType.Name = "lbType";
			this.lbType.Size = new System.Drawing.Size(95, 26);
			this.lbType.TabIndex = 4;
			this.lbType.Text = "Type : ...";
			// 
			// lbLanguage
			// 
			this.lbLanguage.AutoSize = true;
			this.lbLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.lbLanguage.Location = new System.Drawing.Point(12, 480);
			this.lbLanguage.Name = "lbLanguage";
			this.lbLanguage.Size = new System.Drawing.Size(144, 26);
			this.lbLanguage.TabIndex = 5;
			this.lbLanguage.Text = "Language : ...";
			// 
			// lbSize
			// 
			this.lbSize.AutoSize = true;
			this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.lbSize.Location = new System.Drawing.Point(12, 521);
			this.lbSize.Name = "lbSize";
			this.lbSize.Size = new System.Drawing.Size(91, 26);
			this.lbSize.TabIndex = 6;
			this.lbSize.Text = "Size : ...";
			// 
			// nudquantity
			// 
			this.nudquantity.BackColor = System.Drawing.Color.WhiteSmoke;
			this.nudquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.nudquantity.Location = new System.Drawing.Point(64, 94);
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
			this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbPrice.Location = new System.Drawing.Point(92, 25);
			this.lbPrice.Name = "lbPrice";
			this.lbPrice.Size = new System.Drawing.Size(40, 17);
			this.lbPrice.TabIndex = 9;
			this.lbPrice.Text = "Price";
			// 
			// lbPrice2
			// 
			this.lbPrice2.AutoSize = true;
			this.lbPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.lbPrice2.Location = new System.Drawing.Point(138, 39);
			this.lbPrice2.Name = "lbPrice2";
			this.lbPrice2.Size = new System.Drawing.Size(82, 29);
			this.lbPrice2.TabIndex = 9;
			this.lbPrice2.Text = "Price2";
			this.lbPrice2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pctrbxAddToBasket);
			this.panel1.Controls.Add(this.lbPrice2);
			this.panel1.Controls.Add(this.nudquantity);
			this.panel1.Controls.Add(this.lbPrice);
			this.panel1.Location = new System.Drawing.Point(431, 357);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(303, 168);
			this.panel1.TabIndex = 10;
			// 
			// pctrbxAddToBasket
			// 
			this.pctrbxAddToBasket.Image = global::OOP2_BookStore.Properties.Resources.addtobasket;
			this.pctrbxAddToBasket.InitialImage = global::OOP2_BookStore.Properties.Resources.addtobasket;
			this.pctrbxAddToBasket.Location = new System.Drawing.Point(143, 81);
			this.pctrbxAddToBasket.Name = "pctrbxAddToBasket";
			this.pctrbxAddToBasket.Size = new System.Drawing.Size(90, 67);
			this.pctrbxAddToBasket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctrbxAddToBasket.TabIndex = 11;
			this.pctrbxAddToBasket.TabStop = false;
			this.pctrbxAddToBasket.Click += new System.EventHandler(this.pctrbxAddToBasket_Click);
			// 
			// pctrbxCoverPhoto
			// 
			this.pctrbxCoverPhoto.BackColor = System.Drawing.Color.White;
			this.pctrbxCoverPhoto.Location = new System.Drawing.Point(12, 12);
			this.pctrbxCoverPhoto.Name = "pctrbxCoverPhoto";
			this.pctrbxCoverPhoto.Size = new System.Drawing.Size(239, 286);
			this.pctrbxCoverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctrbxCoverPhoto.TabIndex = 0;
			this.pctrbxCoverPhoto.TabStop = false;
			// 
			// BookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(808, 557);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lbSize);
			this.Controls.Add(this.lbLanguage);
			this.Controls.Add(this.lbType);
			this.Controls.Add(this.txtbxDescription);
			this.Controls.Add(this.lbNoOfPage);
			this.Controls.Add(this.lbPublisher);
			this.Controls.Add(this.lbBookAuthor);
			this.Controls.Add(this.lbBookName);
			this.Controls.Add(this.pctrbxCoverPhoto);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BookForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BookForm";
			((System.ComponentModel.ISupportInitialize)(this.nudquantity)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctrbxAddToBasket)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctrbxCoverPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pctrbxCoverPhoto;
		private System.Windows.Forms.Label lbBookName;
		private System.Windows.Forms.Label lbBookAuthor;
		private System.Windows.Forms.Label lbPublisher;
		private System.Windows.Forms.Label lbNoOfPage;
		private System.Windows.Forms.TextBox txtbxDescription;
		private System.Windows.Forms.Label lbType;
		private System.Windows.Forms.Label lbLanguage;
		private System.Windows.Forms.Label lbSize;
		private System.Windows.Forms.NumericUpDown nudquantity;
		private System.Windows.Forms.Label lbPrice;
		private System.Windows.Forms.Label lbPrice2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pctrbxAddToBasket;
	}
}