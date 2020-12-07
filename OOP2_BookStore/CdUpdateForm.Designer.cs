namespace OOP2_BookStore
{
    partial class CdUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CdUpdateForm));
            this.cmbCdType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSinger = new System.Windows.Forms.TextBox();
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
            this.lblSelectImage = new System.Windows.Forms.Label();
            this.dgvCdUpdate = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCdUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCdType
            // 
            this.cmbCdType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbCdType.FormattingEnabled = true;
            this.cmbCdType.Items.AddRange(new object[] {
            "Romans",
            "Hard Rock",
            "Country"});
            this.cmbCdType.Location = new System.Drawing.Point(248, 163);
            this.cmbCdType.Name = "cmbCdType";
            this.cmbCdType.Size = new System.Drawing.Size(100, 24);
            this.cmbCdType.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(42, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Singer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(53, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Sale";
            // 
            // tbSinger
            // 
            this.tbSinger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSinger.Location = new System.Drawing.Point(89, 163);
            this.tbSinger.Name = "tbSinger";
            this.tbSinger.Size = new System.Drawing.Size(100, 23);
            this.tbSinger.TabIndex = 43;
            // 
            // tbSale
            // 
            this.tbSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSale.Location = new System.Drawing.Point(89, 197);
            this.tbSale.Multiline = true;
            this.tbSale.Name = "tbSale";
            this.tbSale.Size = new System.Drawing.Size(100, 18);
            this.tbSale.TabIndex = 42;
            this.tbSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(247, 214);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 34);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            this.btnUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(16, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(212, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(50, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(47, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblId.Location = new System.Drawing.Point(65, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 17);
            this.lblId.TabIndex = 35;
            this.lblId.Text = "ID";
            // 
            // tbDescription
            // 
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbDescription.Location = new System.Drawing.Point(89, 130);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(100, 23);
            this.tbDescription.TabIndex = 33;
            // 
            // tbPrice
            // 
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbPrice.Location = new System.Drawing.Point(89, 97);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 23);
            this.tbPrice.TabIndex = 32;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbName.Location = new System.Drawing.Point(89, 63);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 23);
            this.tbName.TabIndex = 31;
            // 
            // tbId
            // 
            this.tbId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbId.Location = new System.Drawing.Point(89, 30);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(100, 23);
            this.tbId.TabIndex = 34;
            // 
            // pbProductImage
            // 
            this.pbProductImage.Location = new System.Drawing.Point(248, 31);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(100, 117);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProductImage.TabIndex = 46;
            this.pbProductImage.TabStop = false;
            this.pbProductImage.Visible = false;
            // 
            // lblSelectImage
            // 
            this.lblSelectImage.AutoSize = true;
            this.lblSelectImage.Location = new System.Drawing.Point(254, 57);
            this.lblSelectImage.Name = "lblSelectImage";
            this.lblSelectImage.Size = new System.Drawing.Size(85, 13);
            this.lblSelectImage.TabIndex = 48;
            this.lblSelectImage.Text = "SELECT IMAGE";
            this.lblSelectImage.Click += new System.EventHandler(this.LblSelectImage_Click);
            this.lblSelectImage.MouseLeave += new System.EventHandler(this.LblSelectImage_MouseLeave);
            this.lblSelectImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblSelectImage_MouseMove);
            // 
            // dgvCdUpdate
            // 
            this.dgvCdUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCdUpdate.Location = new System.Drawing.Point(0, 348);
            this.dgvCdUpdate.Name = "dgvCdUpdate";
            this.dgvCdUpdate.Size = new System.Drawing.Size(13, 14);
            this.dgvCdUpdate.TabIndex = 49;
            this.dgvCdUpdate.Visible = false;
            // 
            // CdUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 292);
            this.Controls.Add(this.dgvCdUpdate);
            this.Controls.Add(this.lblSelectImage);
            this.Controls.Add(this.cmbCdType);
            this.Controls.Add(this.pbProductImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSinger);
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
            this.Name = "CdUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CdUpdateForm";
            this.Load += new System.EventHandler(this.CdUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCdUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCdType;
        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSinger;
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
        private System.Windows.Forms.Label lblSelectImage;
        private System.Windows.Forms.DataGridView dgvCdUpdate;
    }
}