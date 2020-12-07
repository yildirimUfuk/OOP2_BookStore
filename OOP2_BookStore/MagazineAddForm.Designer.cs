namespace OOP2_BookStore
{
    partial class MagazineAddForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagazineAddForm));
			this.cmbCdType = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbIssue = new System.Windows.Forms.TextBox();
			this.tbSale = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.lblSelectImage = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbDescription = new System.Windows.Forms.TextBox();
			this.tbPrice = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.pbProductImage = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbCdType
			// 
			this.cmbCdType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.cmbCdType.FormattingEnabled = true;
			this.cmbCdType.Items.AddRange(new object[] {
            "Actual",
            "News",
            "Sport",
            "Computer",
            "Technology"});
			this.cmbCdType.Location = new System.Drawing.Point(135, 136);
			this.cmbCdType.Margin = new System.Windows.Forms.Padding(4);
			this.cmbCdType.Name = "cmbCdType";
			this.cmbCdType.Size = new System.Drawing.Size(132, 28);
			this.cmbCdType.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(72, 52);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 20);
			this.label1.TabIndex = 45;
			this.label1.Text = "Issue";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label5.Location = new System.Drawing.Point(79, 96);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 20);
			this.label5.TabIndex = 44;
			this.label5.Text = "Sale";
			// 
			// tbIssue
			// 
			this.tbIssue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbIssue.Location = new System.Drawing.Point(135, 48);
			this.tbIssue.Margin = new System.Windows.Forms.Padding(4);
			this.tbIssue.Name = "tbIssue";
			this.tbIssue.Size = new System.Drawing.Size(132, 26);
			this.tbIssue.TabIndex = 0;
			// 
			// tbSale
			// 
			this.tbSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbSale.Location = new System.Drawing.Point(135, 92);
			this.tbSale.Margin = new System.Windows.Forms.Padding(4);
			this.tbSale.Name = "tbSale";
			this.tbSale.Size = new System.Drawing.Size(132, 26);
			this.tbSale.TabIndex = 1;
			this.tbSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(337, 258);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(133, 42);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label8.Location = new System.Drawing.Point(30, 272);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(91, 20);
			this.label8.TabIndex = 39;
			this.label8.Text = "description";
			// 
			// lblSelectImage
			// 
			this.lblSelectImage.AutoSize = true;
			this.lblSelectImage.Location = new System.Drawing.Point(347, 81);
			this.lblSelectImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSelectImage.Name = "lblSelectImage";
			this.lblSelectImage.Size = new System.Drawing.Size(108, 17);
			this.lblSelectImage.TabIndex = 38;
			this.lblSelectImage.Text = "SELECT IMAGE";
			this.lblSelectImage.Click += new System.EventHandler(this.LblSelectImage_Click);
			this.lblSelectImage.MouseLeave += new System.EventHandler(this.LblSelectImage_MouseLeave);
			this.lblSelectImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblSelectImage_MouseMove);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label9.Location = new System.Drawing.Point(81, 140);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 20);
			this.label9.TabIndex = 37;
			this.label9.Text = "type";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label7.Location = new System.Drawing.Point(75, 228);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 20);
			this.label7.TabIndex = 40;
			this.label7.Text = "price";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label6.Location = new System.Drawing.Point(71, 184);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 20);
			this.label6.TabIndex = 36;
			this.label6.Text = "name";
			// 
			// tbDescription
			// 
			this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbDescription.Location = new System.Drawing.Point(135, 270);
			this.tbDescription.Margin = new System.Windows.Forms.Padding(4);
			this.tbDescription.Multiline = true;
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.Size = new System.Drawing.Size(132, 22);
			this.tbDescription.TabIndex = 6;
			// 
			// tbPrice
			// 
			this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbPrice.Location = new System.Drawing.Point(135, 226);
			this.tbPrice.Margin = new System.Windows.Forms.Padding(4);
			this.tbPrice.Name = "tbPrice";
			this.tbPrice.Size = new System.Drawing.Size(132, 26);
			this.tbPrice.TabIndex = 5;
			this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
			// 
			// tbName
			// 
			this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbName.Location = new System.Drawing.Point(135, 182);
			this.tbName.Margin = new System.Windows.Forms.Padding(4);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(132, 26);
			this.tbName.TabIndex = 4;
			// 
			// pbProductImage
			// 
			this.pbProductImage.Location = new System.Drawing.Point(337, 48);
			this.pbProductImage.Margin = new System.Windows.Forms.Padding(4);
			this.pbProductImage.Name = "pbProductImage";
			this.pbProductImage.Size = new System.Drawing.Size(133, 168);
			this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbProductImage.TabIndex = 46;
			this.pbProductImage.TabStop = false;
			this.pbProductImage.Visible = false;
			// 
			// MagazineAddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 359);
			this.Controls.Add(this.cmbCdType);
			this.Controls.Add(this.pbProductImage);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbIssue);
			this.Controls.Add(this.tbSale);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.lblSelectImage);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbDescription);
			this.Controls.Add(this.tbPrice);
			this.Controls.Add(this.tbName);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MagazineAddForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MagazineAddForm";
			((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCdType;
        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIssue;
        private System.Windows.Forms.TextBox tbSale;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSelectImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbName;
    }
}