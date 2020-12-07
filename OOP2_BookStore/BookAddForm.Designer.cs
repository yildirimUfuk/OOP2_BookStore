namespace OOP2_BookStore
{
    partial class BookAddForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookAddForm));
			this.tbIsbn = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.tbAuthor = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbPublisher = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbPage = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbPrice = new System.Windows.Forms.TextBox();
			this.tbDescription = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbSale = new System.Windows.Forms.TextBox();
			this.pbProductImage = new System.Windows.Forms.PictureBox();
			this.lblSelectImage = new System.Windows.Forms.Label();
			this.cmbBookType = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.cmbBoxLanguage = new System.Windows.Forms.ComboBox();
			this.tbSize = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
			this.SuspendLayout();
			// 
			// tbIsbn
			// 
			this.tbIsbn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbIsbn.Location = new System.Drawing.Point(104, 16);
			this.tbIsbn.Margin = new System.Windows.Forms.Padding(4);
			this.tbIsbn.Name = "tbIsbn";
			this.tbIsbn.Size = new System.Drawing.Size(132, 26);
			this.tbIsbn.TabIndex = 0;
			this.tbIsbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(56, 19);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 20);
			this.label1.TabIndex = 11;
			this.label1.Text = "isbn";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(375, 288);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(133, 42);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// tbAuthor
			// 
			this.tbAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbAuthor.Location = new System.Drawing.Point(104, 48);
			this.tbAuthor.Margin = new System.Windows.Forms.Padding(4);
			this.tbAuthor.Name = "tbAuthor";
			this.tbAuthor.Size = new System.Drawing.Size(132, 26);
			this.tbAuthor.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.Location = new System.Drawing.Point(40, 51);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 20);
			this.label2.TabIndex = 12;
			this.label2.Text = "author";
			// 
			// tbPublisher
			// 
			this.tbPublisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbPublisher.Location = new System.Drawing.Point(104, 80);
			this.tbPublisher.Margin = new System.Windows.Forms.Padding(4);
			this.tbPublisher.Name = "tbPublisher";
			this.tbPublisher.Size = new System.Drawing.Size(132, 26);
			this.tbPublisher.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label3.Location = new System.Drawing.Point(19, 83);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 20);
			this.label3.TabIndex = 13;
			this.label3.Text = "publisher";
			// 
			// tbPage
			// 
			this.tbPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbPage.Location = new System.Drawing.Point(104, 112);
			this.tbPage.Margin = new System.Windows.Forms.Padding(4);
			this.tbPage.Name = "tbPage";
			this.tbPage.Size = new System.Drawing.Size(132, 26);
			this.tbPage.TabIndex = 3;
			this.tbPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label4.Location = new System.Drawing.Point(51, 115);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 20);
			this.label4.TabIndex = 14;
			this.label4.Text = "page";
			// 
			// tbName
			// 
			this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbName.Location = new System.Drawing.Point(104, 206);
			this.tbName.Margin = new System.Windows.Forms.Padding(4);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(132, 26);
			this.tbName.TabIndex = 6;
			// 
			// tbPrice
			// 
			this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbPrice.Location = new System.Drawing.Point(104, 238);
			this.tbPrice.Margin = new System.Windows.Forms.Padding(4);
			this.tbPrice.Name = "tbPrice";
			this.tbPrice.Size = new System.Drawing.Size(132, 26);
			this.tbPrice.TabIndex = 7;
			this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
			// 
			// tbDescription
			// 
			this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbDescription.Location = new System.Drawing.Point(104, 270);
			this.tbDescription.Margin = new System.Windows.Forms.Padding(4);
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.Size = new System.Drawing.Size(132, 26);
			this.tbDescription.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label6.Location = new System.Drawing.Point(46, 209);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 20);
			this.label6.TabIndex = 17;
			this.label6.Text = "name";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label7.Location = new System.Drawing.Point(50, 241);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 20);
			this.label7.TabIndex = 18;
			this.label7.Text = "price";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label8.Location = new System.Drawing.Point(5, 273);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(91, 20);
			this.label8.TabIndex = 19;
			this.label8.Text = "description";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label5.Location = new System.Drawing.Point(54, 147);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 20);
			this.label5.TabIndex = 15;
			this.label5.Text = "Sale";
			// 
			// tbSale
			// 
			this.tbSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbSale.Location = new System.Drawing.Point(104, 144);
			this.tbSale.Margin = new System.Windows.Forms.Padding(4);
			this.tbSale.Name = "tbSale";
			this.tbSale.Size = new System.Drawing.Size(132, 26);
			this.tbSale.TabIndex = 4;
			this.tbSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
			// 
			// pbProductImage
			// 
			this.pbProductImage.Location = new System.Drawing.Point(374, 19);
			this.pbProductImage.Margin = new System.Windows.Forms.Padding(4);
			this.pbProductImage.Name = "pbProductImage";
			this.pbProductImage.Size = new System.Drawing.Size(133, 159);
			this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbProductImage.TabIndex = 5;
			this.pbProductImage.TabStop = false;
			this.pbProductImage.Visible = false;
			// 
			// lblSelectImage
			// 
			this.lblSelectImage.AutoSize = true;
			this.lblSelectImage.Location = new System.Drawing.Point(386, 90);
			this.lblSelectImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSelectImage.Name = "lblSelectImage";
			this.lblSelectImage.Size = new System.Drawing.Size(108, 17);
			this.lblSelectImage.TabIndex = 1;
			this.lblSelectImage.Text = "SELECT IMAGE";
			this.lblSelectImage.Click += new System.EventHandler(this.LblSelectImage_Click);
			this.lblSelectImage.MouseLeave += new System.EventHandler(this.LblSelectImage_MouseLeave);
			this.lblSelectImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblSelectImage_MouseMove);
			// 
			// cmbBookType
			// 
			this.cmbBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.cmbBookType.FormattingEnabled = true;
			this.cmbBookType.Items.AddRange(new object[] {
            "ScienceFiction",
            "Satire",
            "Drama"});
			this.cmbBookType.Location = new System.Drawing.Point(375, 204);
			this.cmbBookType.Margin = new System.Windows.Forms.Padding(4);
			this.cmbBookType.Name = "cmbBookType";
			this.cmbBookType.Size = new System.Drawing.Size(132, 28);
			this.cmbBookType.TabIndex = 9;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label9.Location = new System.Drawing.Point(315, 207);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 20);
			this.label9.TabIndex = 20;
			this.label9.Text = "type";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label10.Location = new System.Drawing.Point(279, 240);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(76, 20);
			this.label10.TabIndex = 21;
			this.label10.Text = "language";
			// 
			// cmbBoxLanguage
			// 
			this.cmbBoxLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.cmbBoxLanguage.FormattingEnabled = true;
			this.cmbBoxLanguage.Items.AddRange(new object[] {
            "Turkish",
            "English"});
			this.cmbBoxLanguage.Location = new System.Drawing.Point(375, 237);
			this.cmbBoxLanguage.Margin = new System.Windows.Forms.Padding(4);
			this.cmbBoxLanguage.Name = "cmbBoxLanguage";
			this.cmbBoxLanguage.Size = new System.Drawing.Size(132, 28);
			this.cmbBoxLanguage.TabIndex = 10;
			// 
			// tbSize
			// 
			this.tbSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbSize.Location = new System.Drawing.Point(104, 176);
			this.tbSize.Margin = new System.Windows.Forms.Padding(4);
			this.tbSize.Name = "tbSize";
			this.tbSize.Size = new System.Drawing.Size(132, 26);
			this.tbSize.TabIndex = 4;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label11.Location = new System.Drawing.Point(54, 179);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(42, 20);
			this.label11.TabIndex = 15;
			this.label11.Text = "Size";
			// 
			// BookAddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 359);
			this.Controls.Add(this.cmbBoxLanguage);
			this.Controls.Add(this.cmbBookType);
			this.Controls.Add(this.pbProductImage);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbSize);
			this.Controls.Add(this.tbSale);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.lblSelectImage);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbDescription);
			this.Controls.Add(this.tbPage);
			this.Controls.Add(this.tbPrice);
			this.Controls.Add(this.tbPublisher);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.tbAuthor);
			this.Controls.Add(this.tbIsbn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "BookAddForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BookAddForm";
			((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIsbn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPublisher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSale;
        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.Label lblSelectImage;
        private System.Windows.Forms.ComboBox cmbBookType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbBoxLanguage;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Label label11;
    }
}