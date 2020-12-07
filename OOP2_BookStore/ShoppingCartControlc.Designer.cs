namespace OOP2_BookStore
{
	partial class ShoppingCartControlc
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
			this.bttnDelete = new System.Windows.Forms.Button();
			this.nudpiece = new System.Windows.Forms.NumericUpDown();
			this.lbPrice = new System.Windows.Forms.Label();
			this.lbSale = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ptbxProductPhoto = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.nudpiece)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbxProductPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// bttnDelete
			// 
			this.bttnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.bttnDelete.Location = new System.Drawing.Point(361, 128);
			this.bttnDelete.Name = "bttnDelete";
			this.bttnDelete.Size = new System.Drawing.Size(81, 29);
			this.bttnDelete.TabIndex = 13;
			this.bttnDelete.Text = "Delete";
			this.bttnDelete.UseVisualStyleBackColor = true;
			this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
			// 
			// nudpiece
			// 
			this.nudpiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.nudpiece.Location = new System.Drawing.Point(270, 90);
			this.nudpiece.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudpiece.Name = "nudpiece";
			this.nudpiece.Size = new System.Drawing.Size(42, 27);
			this.nudpiece.TabIndex = 12;
			this.nudpiece.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudpiece.ValueChanged += new System.EventHandler(this.nudpiece_ValueChanged);
			// 
			// lbPrice
			// 
			this.lbPrice.AutoSize = true;
			this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbPrice.Location = new System.Drawing.Point(357, 92);
			this.lbPrice.Name = "lbPrice";
			this.lbPrice.Size = new System.Drawing.Size(61, 20);
			this.lbPrice.TabIndex = 11;
			this.lbPrice.Text = "lbPrice";
			// 
			// lbSale
			// 
			this.lbSale.AutoSize = true;
			this.lbSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbSale.Location = new System.Drawing.Point(358, 59);
			this.lbSale.Name = "lbSale";
			this.lbSale.Size = new System.Drawing.Size(47, 17);
			this.lbSale.TabIndex = 10;
			this.lbSale.Text = "lbSale";
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lbName.Location = new System.Drawing.Point(139, 5);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(101, 29);
			this.lbName.TabIndex = 9;
			this.lbName.Text = "lbName";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
			this.panel1.Location = new System.Drawing.Point(0, 181);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(478, 4);
			this.panel1.TabIndex = 8;
			// 
			// ptbxProductPhoto
			// 
			this.ptbxProductPhoto.Location = new System.Drawing.Point(3, 5);
			this.ptbxProductPhoto.Name = "ptbxProductPhoto";
			this.ptbxProductPhoto.Size = new System.Drawing.Size(130, 172);
			this.ptbxProductPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptbxProductPhoto.TabIndex = 7;
			this.ptbxProductPhoto.TabStop = false;
			// 
			// ShoppingCartControlc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.bttnDelete);
			this.Controls.Add(this.nudpiece);
			this.Controls.Add(this.lbPrice);
			this.Controls.Add(this.lbSale);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.ptbxProductPhoto);
			this.Name = "ShoppingCartControlc";
			this.Size = new System.Drawing.Size(478, 194);
			this.Load += new System.EventHandler(this.ShoppingCartControlc_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudpiece)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbxProductPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bttnDelete;
		private System.Windows.Forms.NumericUpDown nudpiece;
		private System.Windows.Forms.Label lbPrice;
		private System.Windows.Forms.Label lbSale;
		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox ptbxProductPhoto;
	}
}
