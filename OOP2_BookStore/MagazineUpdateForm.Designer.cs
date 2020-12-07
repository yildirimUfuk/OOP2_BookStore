namespace OOP2_BookStore
{
    partial class MagazineUpdateForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagazineUpdateForm));
			this.cmbCdType = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbIssue = new System.Windows.Forms.TextBox();
			this.tbSale = new System.Windows.Forms.TextBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblId = new System.Windows.Forms.Label();
			this.tbDescription = new System.Windows.Forms.TextBox();
			this.tbPrice = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbId = new System.Windows.Forms.TextBox();
			this.pbProductImage = new System.Windows.Forms.PictureBox();
			this.dgvMagazineUpdate = new System.Windows.Forms.DataGridView();
			this.lblSelectImage = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvMagazineUpdate)).BeginInit();
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
			this.cmbCdType.Location = new System.Drawing.Point(141, 114);
			this.cmbCdType.Margin = new System.Windows.Forms.Padding(4);
			this.cmbCdType.Name = "cmbCdType";
			this.cmbCdType.Size = new System.Drawing.Size(132, 28);
			this.cmbCdType.TabIndex = 64;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(77, 42);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 20);
			this.label1.TabIndex = 62;
			this.label1.Text = "Issue";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label5.Location = new System.Drawing.Point(85, 80);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 20);
			this.label5.TabIndex = 61;
			this.label5.Text = "Sale";
			// 
			// tbIssue
			// 
			this.tbIssue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbIssue.Location = new System.Drawing.Point(141, 38);
			this.tbIssue.Margin = new System.Windows.Forms.Padding(4);
			this.tbIssue.Name = "tbIssue";
			this.tbIssue.Size = new System.Drawing.Size(132, 26);
			this.tbIssue.TabIndex = 60;
			// 
			// tbSale
			// 
			this.tbSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbSale.Location = new System.Drawing.Point(141, 76);
			this.tbSale.Margin = new System.Windows.Forms.Padding(4);
			this.tbSale.Name = "tbSale";
			this.tbSale.Size = new System.Drawing.Size(132, 26);
			this.tbSale.TabIndex = 59;
			this.tbSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(328, 254);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(133, 42);
			this.btnUpdate.TabIndex = 58;
			this.btnUpdate.Text = "UPDATE";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label8.Location = new System.Drawing.Point(36, 270);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(91, 20);
			this.label8.TabIndex = 56;
			this.label8.Text = "description";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label9.Location = new System.Drawing.Point(87, 118);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 20);
			this.label9.TabIndex = 54;
			this.label9.Text = "type";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label7.Location = new System.Drawing.Point(81, 231);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 20);
			this.label7.TabIndex = 57;
			this.label7.Text = "price";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label6.Location = new System.Drawing.Point(77, 194);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 20);
			this.label6.TabIndex = 53;
			this.label6.Text = "name";
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblId.Location = new System.Drawing.Point(101, 156);
			this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(26, 20);
			this.lblId.TabIndex = 52;
			this.lblId.Text = "ID";
			// 
			// tbDescription
			// 
			this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbDescription.Location = new System.Drawing.Point(141, 268);
			this.tbDescription.Margin = new System.Windows.Forms.Padding(4);
			this.tbDescription.Multiline = true;
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.Size = new System.Drawing.Size(132, 22);
			this.tbDescription.TabIndex = 50;
			// 
			// tbPrice
			// 
			this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbPrice.Location = new System.Drawing.Point(141, 230);
			this.tbPrice.Margin = new System.Windows.Forms.Padding(4);
			this.tbPrice.Name = "tbPrice";
			this.tbPrice.Size = new System.Drawing.Size(132, 26);
			this.tbPrice.TabIndex = 49;
			this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
			// 
			// tbName
			// 
			this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbName.Location = new System.Drawing.Point(141, 192);
			this.tbName.Margin = new System.Windows.Forms.Padding(4);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(132, 26);
			this.tbName.TabIndex = 48;
			// 
			// tbId
			// 
			this.tbId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbId.Location = new System.Drawing.Point(141, 154);
			this.tbId.Margin = new System.Windows.Forms.Padding(4);
			this.tbId.Name = "tbId";
			this.tbId.ReadOnly = true;
			this.tbId.Size = new System.Drawing.Size(132, 26);
			this.tbId.TabIndex = 51;
			// 
			// pbProductImage
			// 
			this.pbProductImage.Location = new System.Drawing.Point(328, 38);
			this.pbProductImage.Margin = new System.Windows.Forms.Padding(4);
			this.pbProductImage.Name = "pbProductImage";
			this.pbProductImage.Size = new System.Drawing.Size(133, 172);
			this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbProductImage.TabIndex = 63;
			this.pbProductImage.TabStop = false;
			this.pbProductImage.Visible = false;
			// 
			// dgvMagazineUpdate
			// 
			this.dgvMagazineUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMagazineUpdate.Location = new System.Drawing.Point(0, 332);
			this.dgvMagazineUpdate.Margin = new System.Windows.Forms.Padding(4);
			this.dgvMagazineUpdate.Name = "dgvMagazineUpdate";
			this.dgvMagazineUpdate.Size = new System.Drawing.Size(25, 12);
			this.dgvMagazineUpdate.TabIndex = 65;
			this.dgvMagazineUpdate.Visible = false;
			// 
			// lblSelectImage
			// 
			this.lblSelectImage.AutoSize = true;
			this.lblSelectImage.Location = new System.Drawing.Point(333, 71);
			this.lblSelectImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSelectImage.Name = "lblSelectImage";
			this.lblSelectImage.Size = new System.Drawing.Size(108, 17);
			this.lblSelectImage.TabIndex = 66;
			this.lblSelectImage.Text = "SELECT IMAGE";
			this.lblSelectImage.Click += new System.EventHandler(this.LblSelectImage_Click);
			this.lblSelectImage.MouseLeave += new System.EventHandler(this.LblSelectImage_MouseLeave);
			this.lblSelectImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblSelectImage_MouseMove);
			// 
			// MagazineUpdateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(539, 359);
			this.Controls.Add(this.lblSelectImage);
			this.Controls.Add(this.dgvMagazineUpdate);
			this.Controls.Add(this.cmbCdType);
			this.Controls.Add(this.pbProductImage);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbIssue);
			this.Controls.Add(this.tbSale);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.tbDescription);
			this.Controls.Add(this.tbPrice);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.tbId);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MagazineUpdateForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MagazineUpdateForm";
			this.Load += new System.EventHandler(this.MagazineUpdateForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvMagazineUpdate)).EndInit();
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.DataGridView dgvMagazineUpdate;
        private System.Windows.Forms.Label lblSelectImage;
    }
}