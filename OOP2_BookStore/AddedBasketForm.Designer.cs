namespace OOP2_BookStore
{
	partial class AddedBasketForm
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
			this.pcrbxcheckedphoto = new System.Windows.Forms.PictureBox();
			this.pctrbxProductPhoto = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbPriceSale = new System.Windows.Forms.Label();
			this.lbPrice = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pcrbxcheckedphoto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctrbxProductPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// pcrbxcheckedphoto
			// 
			this.pcrbxcheckedphoto.Image = global::OOP2_BookStore.Properties.Resources._checked;
			this.pcrbxcheckedphoto.Location = new System.Drawing.Point(138, 12);
			this.pcrbxcheckedphoto.Name = "pcrbxcheckedphoto";
			this.pcrbxcheckedphoto.Size = new System.Drawing.Size(150, 150);
			this.pcrbxcheckedphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcrbxcheckedphoto.TabIndex = 0;
			this.pcrbxcheckedphoto.TabStop = false;
			// 
			// pctrbxProductPhoto
			// 
			this.pctrbxProductPhoto.Location = new System.Drawing.Point(24, 278);
			this.pctrbxProductPhoto.Name = "pctrbxProductPhoto";
			this.pctrbxProductPhoto.Size = new System.Drawing.Size(139, 198);
			this.pctrbxProductPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctrbxProductPhoto.TabIndex = 1;
			this.pctrbxProductPhoto.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label1.ForeColor = System.Drawing.Color.DarkGreen;
			this.label1.Location = new System.Drawing.Point(19, 201);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(369, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "The product has been added to your cart.";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkGreen;
			this.panel1.Location = new System.Drawing.Point(-8, 241);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(442, 3);
			this.panel1.TabIndex = 3;
			// 
			// lbPriceSale
			// 
			this.lbPriceSale.AutoSize = true;
			this.lbPriceSale.Location = new System.Drawing.Point(245, 419);
			this.lbPriceSale.Name = "lbPriceSale";
			this.lbPriceSale.Size = new System.Drawing.Size(79, 17);
			this.lbPriceSale.TabIndex = 4;
			this.lbPriceSale.Text = "lbPriceSale";
			// 
			// lbPrice
			// 
			this.lbPrice.AutoSize = true;
			this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
			this.lbPrice.Location = new System.Drawing.Point(300, 447);
			this.lbPrice.Name = "lbPrice";
			this.lbPrice.Size = new System.Drawing.Size(98, 29);
			this.lbPrice.TabIndex = 5;
			this.lbPrice.Text = "lbPrice";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.label2.Location = new System.Drawing.Point(250, 370);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 26);
			this.label2.TabIndex = 6;
			this.label2.Text = "Price Per Unit";
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
			this.lbName.Location = new System.Drawing.Point(181, 283);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(107, 29);
			this.lbName.TabIndex = 7;
			this.lbName.Text = "lbName";
			// 
			// AddedBasketForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(426, 499);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbPrice);
			this.Controls.Add(this.lbPriceSale);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pctrbxProductPhoto);
			this.Controls.Add(this.pcrbxcheckedphoto);
			this.Name = "AddedBasketForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddedBasketForm";
			((System.ComponentModel.ISupportInitialize)(this.pcrbxcheckedphoto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctrbxProductPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pcrbxcheckedphoto;
		private System.Windows.Forms.PictureBox pctrbxProductPhoto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbPriceSale;
		private System.Windows.Forms.Label lbPrice;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbName;
	}
}