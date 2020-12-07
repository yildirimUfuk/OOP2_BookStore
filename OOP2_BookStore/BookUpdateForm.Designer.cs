namespace OOP2_BookStore
{
    partial class BookUpdateForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookUpdateForm));
			this.cmbBoxLanguage = new System.Windows.Forms.ComboBox();
			this.cmbBookType = new System.Windows.Forms.ComboBox();
			this.pbProductImage = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbSale = new System.Windows.Forms.TextBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblId = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbDescription = new System.Windows.Forms.TextBox();
			this.tbPage = new System.Windows.Forms.TextBox();
			this.tbPrice = new System.Windows.Forms.TextBox();
			this.tbPublisher = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbAuthor = new System.Windows.Forms.TextBox();
			this.tbId = new System.Windows.Forms.TextBox();
			this.tbIsbn = new System.Windows.Forms.TextBox();
			this.dgvBookUpdate = new System.Windows.Forms.DataGridView();
			this.tbSize = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.lblSelectImage = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBookUpdate)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbBoxLanguage
			// 
			this.cmbBoxLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.cmbBoxLanguage.FormattingEnabled = true;
			this.cmbBoxLanguage.Items.AddRange(new object[] {
            "Turkish",
            "English"});
			this.cmbBoxLanguage.Location = new System.Drawing.Point(348, 207);
			this.cmbBoxLanguage.Margin = new System.Windows.Forms.Padding(4);
			this.cmbBoxLanguage.Name = "cmbBoxLanguage";
			this.cmbBoxLanguage.Size = new System.Drawing.Size(132, 28);
			this.cmbBoxLanguage.TabIndex = 31;
			// 
			// cmbBookType
			// 
			this.cmbBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.cmbBookType.FormattingEnabled = true;
			this.cmbBookType.Items.AddRange(new object[] {
            "ScienceFiction",
            "Satire",
            "Drama"});
			this.cmbBookType.Location = new System.Drawing.Point(348, 174);
			this.cmbBookType.Margin = new System.Windows.Forms.Padding(4);
			this.cmbBookType.Name = "cmbBookType";
			this.cmbBookType.Size = new System.Drawing.Size(132, 28);
			this.cmbBookType.TabIndex = 30;
			// 
			// pbProductImage
			// 
			this.pbProductImage.Location = new System.Drawing.Point(347, 15);
			this.pbProductImage.Margin = new System.Windows.Forms.Padding(4);
			this.pbProductImage.Name = "pbProductImage";
			this.pbProductImage.Size = new System.Drawing.Size(133, 149);
			this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbProductImage.TabIndex = 29;
			this.pbProductImage.TabStop = false;
			this.pbProductImage.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label5.Location = new System.Drawing.Point(62, 147);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 20);
			this.label5.TabIndex = 28;
			this.label5.Text = "Sale";
			// 
			// tbSale
			// 
			this.tbSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbSale.Location = new System.Drawing.Point(120, 143);
			this.tbSale.Margin = new System.Windows.Forms.Padding(4);
			this.tbSale.Name = "tbSale";
			this.tbSale.Size = new System.Drawing.Size(132, 26);
			this.tbSale.TabIndex = 27;
			this.tbSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(347, 273);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(133, 42);
			this.btnUpdate.TabIndex = 26;
			this.btnUpdate.Text = "UPDATE";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label8.Location = new System.Drawing.Point(13, 309);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(91, 20);
			this.label8.TabIndex = 24;
			this.label8.Text = "description";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label10.Location = new System.Drawing.Point(272, 210);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(76, 20);
			this.label10.TabIndex = 23;
			this.label10.Text = "language";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label9.Location = new System.Drawing.Point(304, 177);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 20);
			this.label9.TabIndex = 21;
			this.label9.Text = "type";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label4.Location = new System.Drawing.Point(59, 115);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 20);
			this.label4.TabIndex = 20;
			this.label4.Text = "page";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label7.Location = new System.Drawing.Point(58, 277);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 20);
			this.label7.TabIndex = 25;
			this.label7.Text = "price";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label3.Location = new System.Drawing.Point(27, 83);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 20);
			this.label3.TabIndex = 19;
			this.label3.Text = "publisher";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label6.Location = new System.Drawing.Point(54, 245);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 20);
			this.label6.TabIndex = 18;
			this.label6.Text = "name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.Location = new System.Drawing.Point(48, 51);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 20);
			this.label2.TabIndex = 17;
			this.label2.Text = "author";
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblId.Location = new System.Drawing.Point(78, 213);
			this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(26, 20);
			this.lblId.TabIndex = 16;
			this.lblId.Text = "ID";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(64, 19);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 20);
			this.label1.TabIndex = 15;
			this.label1.Text = "isbn";
			// 
			// tbDescription
			// 
			this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbDescription.Location = new System.Drawing.Point(120, 305);
			this.tbDescription.Margin = new System.Windows.Forms.Padding(4);
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.Size = new System.Drawing.Size(132, 26);
			this.tbDescription.TabIndex = 13;
			// 
			// tbPage
			// 
			this.tbPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbPage.Location = new System.Drawing.Point(120, 111);
			this.tbPage.Margin = new System.Windows.Forms.Padding(4);
			this.tbPage.Name = "tbPage";
			this.tbPage.Size = new System.Drawing.Size(132, 26);
			this.tbPage.TabIndex = 12;
			this.tbPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
			// 
			// tbPrice
			// 
			this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbPrice.Location = new System.Drawing.Point(120, 273);
			this.tbPrice.Margin = new System.Windows.Forms.Padding(4);
			this.tbPrice.Name = "tbPrice";
			this.tbPrice.Size = new System.Drawing.Size(132, 26);
			this.tbPrice.TabIndex = 11;
			this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
			// 
			// tbPublisher
			// 
			this.tbPublisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbPublisher.Location = new System.Drawing.Point(120, 79);
			this.tbPublisher.Margin = new System.Windows.Forms.Padding(4);
			this.tbPublisher.Name = "tbPublisher";
			this.tbPublisher.Size = new System.Drawing.Size(132, 26);
			this.tbPublisher.TabIndex = 10;
			// 
			// tbName
			// 
			this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbName.Location = new System.Drawing.Point(120, 241);
			this.tbName.Margin = new System.Windows.Forms.Padding(4);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(132, 26);
			this.tbName.TabIndex = 9;
			// 
			// tbAuthor
			// 
			this.tbAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbAuthor.Location = new System.Drawing.Point(120, 47);
			this.tbAuthor.Margin = new System.Windows.Forms.Padding(4);
			this.tbAuthor.Name = "tbAuthor";
			this.tbAuthor.Size = new System.Drawing.Size(132, 26);
			this.tbAuthor.TabIndex = 8;
			// 
			// tbId
			// 
			this.tbId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbId.Location = new System.Drawing.Point(120, 209);
			this.tbId.Margin = new System.Windows.Forms.Padding(4);
			this.tbId.Name = "tbId";
			this.tbId.ReadOnly = true;
			this.tbId.Size = new System.Drawing.Size(132, 26);
			this.tbId.TabIndex = 14;
			// 
			// tbIsbn
			// 
			this.tbIsbn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbIsbn.Location = new System.Drawing.Point(120, 15);
			this.tbIsbn.Margin = new System.Windows.Forms.Padding(4);
			this.tbIsbn.Name = "tbIsbn";
			this.tbIsbn.Size = new System.Drawing.Size(132, 26);
			this.tbIsbn.TabIndex = 7;
			this.tbIsbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
			// 
			// dgvBookUpdate
			// 
			this.dgvBookUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBookUpdate.Location = new System.Drawing.Point(-1, 343);
			this.dgvBookUpdate.Margin = new System.Windows.Forms.Padding(4);
			this.dgvBookUpdate.Name = "dgvBookUpdate";
			this.dgvBookUpdate.Size = new System.Drawing.Size(29, 17);
			this.dgvBookUpdate.TabIndex = 32;
			this.dgvBookUpdate.Visible = false;
			// 
			// tbSize
			// 
			this.tbSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbSize.Location = new System.Drawing.Point(120, 175);
			this.tbSize.Margin = new System.Windows.Forms.Padding(4);
			this.tbSize.Name = "tbSize";
			this.tbSize.Size = new System.Drawing.Size(132, 26);
			this.tbSize.TabIndex = 27;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label11.Location = new System.Drawing.Point(62, 179);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(42, 20);
			this.label11.TabIndex = 28;
			this.label11.Text = "Size";
			// 
			// lblSelectImage
			// 
			this.lblSelectImage.AutoSize = true;
			this.lblSelectImage.Location = new System.Drawing.Point(357, 85);
			this.lblSelectImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSelectImage.Name = "lblSelectImage";
			this.lblSelectImage.Size = new System.Drawing.Size(108, 17);
			this.lblSelectImage.TabIndex = 33;
			this.lblSelectImage.Text = "SELECT IMAGE";
			this.lblSelectImage.Click += new System.EventHandler(this.LblSelectImage_Click);
			this.lblSelectImage.MouseLeave += new System.EventHandler(this.LblSelectImage_MouseLeave);
			this.lblSelectImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblSelectImage_MouseMove);
			// 
			// BookUpdateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 359);
			this.Controls.Add(this.lblSelectImage);
			this.Controls.Add(this.dgvBookUpdate);
			this.Controls.Add(this.cmbBoxLanguage);
			this.Controls.Add(this.cmbBookType);
			this.Controls.Add(this.pbProductImage);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbSize);
			this.Controls.Add(this.tbSale);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbDescription);
			this.Controls.Add(this.tbPage);
			this.Controls.Add(this.tbPrice);
			this.Controls.Add(this.tbPublisher);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.tbAuthor);
			this.Controls.Add(this.tbId);
			this.Controls.Add(this.tbIsbn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "BookUpdateForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BookUpdateForm";
			this.Load += new System.EventHandler(this.BookUpdateForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBookUpdate)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxLanguage;
        private System.Windows.Forms.ComboBox cmbBookType;
        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSale;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbPage;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbPublisher;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbIsbn;
        private System.Windows.Forms.DataGridView dgvBookUpdate;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSelectImage;
    }
}