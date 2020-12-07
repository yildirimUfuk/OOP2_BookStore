namespace OOP2_BookStore
{
	partial class ShoppingCartForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingCartForm));
			this.flpList = new System.Windows.Forms.FlowLayoutPanel();
			this.tcShoppingCart = new System.Windows.Forms.TabControl();
			this.tpShoppingCart = new System.Windows.Forms.TabPage();
			this.lbTotalShopingCard = new System.Windows.Forms.Label();
			this.bttnContinue = new System.Windows.Forms.Button();
			this.bttnCancelOrder = new System.Windows.Forms.Button();
			this.tpOrderInfo = new System.Windows.Forms.TabPage();
			this.gbxCreditCartInfo = new System.Windows.Forms.GroupBox();
			this.cbYear = new System.Windows.Forms.ComboBox();
			this.cbMounth = new System.Windows.Forms.ComboBox();
			this.lbExpirationDate = new System.Windows.Forms.Label();
			this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
			this.lbCardNumb = new System.Windows.Forms.Label();
			this.lbSecurityCode = new System.Windows.Forms.Label();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.bttnOk = new System.Windows.Forms.Button();
			this.lbTotal = new System.Windows.Forms.Label();
			this.grbxPayment = new System.Windows.Forms.GroupBox();
			this.rdbCreditCard = new System.Windows.Forms.RadioButton();
			this.rdbCash = new System.Windows.Forms.RadioButton();
			this.chcbxMyAdress = new System.Windows.Forms.CheckBox();
			this.lbAdress = new System.Windows.Forms.Label();
			this.txtbxAdress = new System.Windows.Forms.TextBox();
			this.tcShoppingCart.SuspendLayout();
			this.tpShoppingCart.SuspendLayout();
			this.tpOrderInfo.SuspendLayout();
			this.gbxCreditCartInfo.SuspendLayout();
			this.grbxPayment.SuspendLayout();
			this.SuspendLayout();
			// 
			// flpList
			// 
			this.flpList.AutoScroll = true;
			this.flpList.AutoSize = true;
			this.flpList.Location = new System.Drawing.Point(5, 6);
			this.flpList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.flpList.MaximumSize = new System.Drawing.Size(531, 523);
			this.flpList.Name = "flpList";
			this.flpList.Size = new System.Drawing.Size(531, 523);
			this.flpList.TabIndex = 0;
			// 
			// tcShoppingCart
			// 
			this.tcShoppingCart.Controls.Add(this.tpShoppingCart);
			this.tcShoppingCart.Controls.Add(this.tpOrderInfo);
			this.tcShoppingCart.Location = new System.Drawing.Point(0, 1);
			this.tcShoppingCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tcShoppingCart.Name = "tcShoppingCart";
			this.tcShoppingCart.SelectedIndex = 0;
			this.tcShoppingCart.Size = new System.Drawing.Size(548, 638);
			this.tcShoppingCart.TabIndex = 1;
			this.tcShoppingCart.SelectedIndexChanged += new System.EventHandler(this.tcShoppingCart_SelectedIndexChanged);
			// 
			// tpShoppingCart
			// 
			this.tpShoppingCart.AutoScroll = true;
			this.tpShoppingCart.Controls.Add(this.lbTotalShopingCard);
			this.tpShoppingCart.Controls.Add(this.bttnContinue);
			this.tpShoppingCart.Controls.Add(this.bttnCancelOrder);
			this.tpShoppingCart.Controls.Add(this.flpList);
			this.tpShoppingCart.Location = new System.Drawing.Point(4, 25);
			this.tpShoppingCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tpShoppingCart.Name = "tpShoppingCart";
			this.tpShoppingCart.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tpShoppingCart.Size = new System.Drawing.Size(540, 609);
			this.tpShoppingCart.TabIndex = 0;
			this.tpShoppingCart.Text = "Shopping Cart";
			this.tpShoppingCart.UseVisualStyleBackColor = true;
			// 
			// lbTotalShopingCard
			// 
			this.lbTotalShopingCard.AutoSize = true;
			this.lbTotalShopingCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lbTotalShopingCard.Location = new System.Drawing.Point(389, 549);
			this.lbTotalShopingCard.Name = "lbTotalShopingCard";
			this.lbTotalShopingCard.Size = new System.Drawing.Size(46, 20);
			this.lbTotalShopingCard.TabIndex = 3;
			this.lbTotalShopingCard.Text = "Total";
			// 
			// bttnContinue
			// 
			this.bttnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(105)))), ((int)(((byte)(27)))));
			this.bttnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.bttnContinue.ForeColor = System.Drawing.Color.White;
			this.bttnContinue.Location = new System.Drawing.Point(147, 549);
			this.bttnContinue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bttnContinue.Name = "bttnContinue";
			this.bttnContinue.Size = new System.Drawing.Size(133, 38);
			this.bttnContinue.TabIndex = 2;
			this.bttnContinue.Text = "Continue";
			this.bttnContinue.UseVisualStyleBackColor = false;
			this.bttnContinue.Click += new System.EventHandler(this.bttnContinue_Click);
			// 
			// bttnCancelOrder
			// 
			this.bttnCancelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(105)))), ((int)(((byte)(27)))));
			this.bttnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.bttnCancelOrder.ForeColor = System.Drawing.Color.White;
			this.bttnCancelOrder.Location = new System.Drawing.Point(8, 549);
			this.bttnCancelOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bttnCancelOrder.Name = "bttnCancelOrder";
			this.bttnCancelOrder.Size = new System.Drawing.Size(133, 38);
			this.bttnCancelOrder.TabIndex = 1;
			this.bttnCancelOrder.Text = "Cancel Order";
			this.bttnCancelOrder.UseVisualStyleBackColor = false;
			this.bttnCancelOrder.Click += new System.EventHandler(this.bttnCancelOrder_Click);
			// 
			// tpOrderInfo
			// 
			this.tpOrderInfo.Controls.Add(this.gbxCreditCartInfo);
			this.tpOrderInfo.Controls.Add(this.bttnOk);
			this.tpOrderInfo.Controls.Add(this.lbTotal);
			this.tpOrderInfo.Controls.Add(this.grbxPayment);
			this.tpOrderInfo.Controls.Add(this.chcbxMyAdress);
			this.tpOrderInfo.Controls.Add(this.lbAdress);
			this.tpOrderInfo.Controls.Add(this.txtbxAdress);
			this.tpOrderInfo.Location = new System.Drawing.Point(4, 25);
			this.tpOrderInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tpOrderInfo.Name = "tpOrderInfo";
			this.tpOrderInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tpOrderInfo.Size = new System.Drawing.Size(540, 609);
			this.tpOrderInfo.TabIndex = 1;
			this.tpOrderInfo.Text = "Order";
			this.tpOrderInfo.UseVisualStyleBackColor = true;
			// 
			// gbxCreditCartInfo
			// 
			this.gbxCreditCartInfo.Controls.Add(this.cbYear);
			this.gbxCreditCartInfo.Controls.Add(this.cbMounth);
			this.gbxCreditCartInfo.Controls.Add(this.lbExpirationDate);
			this.gbxCreditCartInfo.Controls.Add(this.maskedTextBox2);
			this.gbxCreditCartInfo.Controls.Add(this.lbCardNumb);
			this.gbxCreditCartInfo.Controls.Add(this.lbSecurityCode);
			this.gbxCreditCartInfo.Controls.Add(this.maskedTextBox1);
			this.gbxCreditCartInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.gbxCreditCartInfo.Location = new System.Drawing.Point(67, 274);
			this.gbxCreditCartInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbxCreditCartInfo.Name = "gbxCreditCartInfo";
			this.gbxCreditCartInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbxCreditCartInfo.Size = new System.Drawing.Size(417, 194);
			this.gbxCreditCartInfo.TabIndex = 14;
			this.gbxCreditCartInfo.TabStop = false;
			this.gbxCreditCartInfo.Text = "Credit Card";
			this.gbxCreditCartInfo.Visible = false;
			// 
			// cbYear
			// 
			this.cbYear.FormattingEnabled = true;
			this.cbYear.Location = new System.Drawing.Point(213, 137);
			this.cbYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbYear.Name = "cbYear";
			this.cbYear.Size = new System.Drawing.Size(84, 28);
			this.cbYear.TabIndex = 19;
			// 
			// cbMounth
			// 
			this.cbMounth.FormattingEnabled = true;
			this.cbMounth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
			this.cbMounth.Location = new System.Drawing.Point(155, 137);
			this.cbMounth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbMounth.Name = "cbMounth";
			this.cbMounth.Size = new System.Drawing.Size(49, 28);
			this.cbMounth.TabIndex = 19;
			// 
			// lbExpirationDate
			// 
			this.lbExpirationDate.AutoSize = true;
			this.lbExpirationDate.Location = new System.Drawing.Point(5, 140);
			this.lbExpirationDate.Name = "lbExpirationDate";
			this.lbExpirationDate.Size = new System.Drawing.Size(124, 20);
			this.lbExpirationDate.TabIndex = 18;
			this.lbExpirationDate.Text = "Expiration Date";
			// 
			// maskedTextBox2
			// 
			this.maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.maskedTextBox2.Location = new System.Drawing.Point(155, 81);
			this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.maskedTextBox2.Mask = "000";
			this.maskedTextBox2.Name = "maskedTextBox2";
			this.maskedTextBox2.Size = new System.Drawing.Size(39, 26);
			this.maskedTextBox2.TabIndex = 17;
			// 
			// lbCardNumb
			// 
			this.lbCardNumb.AutoSize = true;
			this.lbCardNumb.Location = new System.Drawing.Point(20, 39);
			this.lbCardNumb.Name = "lbCardNumb";
			this.lbCardNumb.Size = new System.Drawing.Size(109, 20);
			this.lbCardNumb.TabIndex = 16;
			this.lbCardNumb.Text = "Card Number";
			// 
			// lbSecurityCode
			// 
			this.lbSecurityCode.AutoSize = true;
			this.lbSecurityCode.Location = new System.Drawing.Point(15, 87);
			this.lbSecurityCode.Name = "lbSecurityCode";
			this.lbSecurityCode.Size = new System.Drawing.Size(114, 20);
			this.lbSecurityCode.TabIndex = 16;
			this.lbSecurityCode.Text = "Security Code";
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.maskedTextBox1.Location = new System.Drawing.Point(155, 37);
			this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.maskedTextBox1.Mask = "0000-0000-0000-0000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(202, 27);
			this.maskedTextBox1.TabIndex = 15;
			// 
			// bttnOk
			// 
			this.bttnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(105)))), ((int)(((byte)(27)))));
			this.bttnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.bttnOk.ForeColor = System.Drawing.Color.White;
			this.bttnOk.Location = new System.Drawing.Point(335, 550);
			this.bttnOk.Margin = new System.Windows.Forms.Padding(4);
			this.bttnOk.Name = "bttnOk";
			this.bttnOk.Size = new System.Drawing.Size(133, 38);
			this.bttnOk.TabIndex = 13;
			this.bttnOk.Text = "Place Order";
			this.bttnOk.UseVisualStyleBackColor = false;
			this.bttnOk.Click += new System.EventHandler(this.bttnOk_Click);
			// 
			// lbTotal
			// 
			this.lbTotal.AutoSize = true;
			this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbTotal.Location = new System.Drawing.Point(61, 550);
			this.lbTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbTotal.Name = "lbTotal";
			this.lbTotal.Size = new System.Drawing.Size(116, 20);
			this.lbTotal.TabIndex = 12;
			this.lbTotal.Text = "Total Payment";
			// 
			// grbxPayment
			// 
			this.grbxPayment.Controls.Add(this.rdbCreditCard);
			this.grbxPayment.Controls.Add(this.rdbCash);
			this.grbxPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.grbxPayment.Location = new System.Drawing.Point(67, 194);
			this.grbxPayment.Margin = new System.Windows.Forms.Padding(4);
			this.grbxPayment.Name = "grbxPayment";
			this.grbxPayment.Padding = new System.Windows.Forms.Padding(4);
			this.grbxPayment.Size = new System.Drawing.Size(417, 73);
			this.grbxPayment.TabIndex = 11;
			this.grbxPayment.TabStop = false;
			this.grbxPayment.Text = "Payment Type";
			// 
			// rdbCreditCard
			// 
			this.rdbCreditCard.AutoSize = true;
			this.rdbCreditCard.Location = new System.Drawing.Point(233, 27);
			this.rdbCreditCard.Margin = new System.Windows.Forms.Padding(4);
			this.rdbCreditCard.Name = "rdbCreditCard";
			this.rdbCreditCard.Size = new System.Drawing.Size(116, 24);
			this.rdbCreditCard.TabIndex = 4;
			this.rdbCreditCard.Text = "Credit Card";
			this.rdbCreditCard.UseVisualStyleBackColor = true;
			this.rdbCreditCard.CheckedChanged += new System.EventHandler(this.rdbCreditCard_CheckedChanged);
			// 
			// rdbCash
			// 
			this.rdbCash.AutoSize = true;
			this.rdbCash.Checked = true;
			this.rdbCash.Location = new System.Drawing.Point(80, 27);
			this.rdbCash.Margin = new System.Windows.Forms.Padding(4);
			this.rdbCash.Name = "rdbCash";
			this.rdbCash.Size = new System.Drawing.Size(69, 24);
			this.rdbCash.TabIndex = 3;
			this.rdbCash.TabStop = true;
			this.rdbCash.Text = "Cash";
			this.rdbCash.UseVisualStyleBackColor = true;
			this.rdbCash.CheckedChanged += new System.EventHandler(this.RdbCash_CheckedChanged);
			// 
			// chcbxMyAdress
			// 
			this.chcbxMyAdress.AutoSize = true;
			this.chcbxMyAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.chcbxMyAdress.Location = new System.Drawing.Point(139, 162);
			this.chcbxMyAdress.Margin = new System.Windows.Forms.Padding(4);
			this.chcbxMyAdress.Name = "chcbxMyAdress";
			this.chcbxMyAdress.Size = new System.Drawing.Size(171, 24);
			this.chcbxMyAdress.TabIndex = 10;
			this.chcbxMyAdress.Text = "Send to my adress";
			this.chcbxMyAdress.UseVisualStyleBackColor = true;
			this.chcbxMyAdress.CheckedChanged += new System.EventHandler(this.chcbxMyAdress_CheckedChanged);
			// 
			// lbAdress
			// 
			this.lbAdress.AutoSize = true;
			this.lbAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lbAdress.Location = new System.Drawing.Point(61, 34);
			this.lbAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbAdress.Name = "lbAdress";
			this.lbAdress.Size = new System.Drawing.Size(62, 20);
			this.lbAdress.TabIndex = 9;
			this.lbAdress.Text = "Adress";
			// 
			// txtbxAdress
			// 
			this.txtbxAdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtbxAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.txtbxAdress.Location = new System.Drawing.Point(139, 32);
			this.txtbxAdress.Margin = new System.Windows.Forms.Padding(4);
			this.txtbxAdress.Multiline = true;
			this.txtbxAdress.Name = "txtbxAdress";
			this.txtbxAdress.Size = new System.Drawing.Size(343, 123);
			this.txtbxAdress.TabIndex = 8;
			// 
			// ShoppingCartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(551, 638);
			this.Controls.Add(this.tcShoppingCart);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "ShoppingCartForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ShoppingCartForm";
			this.Activated += new System.EventHandler(this.ShoppingCartForm_Activated);
			this.Load += new System.EventHandler(this.ShoppingCartForm_Load);
			this.tcShoppingCart.ResumeLayout(false);
			this.tpShoppingCart.ResumeLayout(false);
			this.tpShoppingCart.PerformLayout();
			this.tpOrderInfo.ResumeLayout(false);
			this.tpOrderInfo.PerformLayout();
			this.gbxCreditCartInfo.ResumeLayout(false);
			this.gbxCreditCartInfo.PerformLayout();
			this.grbxPayment.ResumeLayout(false);
			this.grbxPayment.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flpList;
		private System.Windows.Forms.TabControl tcShoppingCart;
		private System.Windows.Forms.TabPage tpShoppingCart;
		private System.Windows.Forms.TabPage tpOrderInfo;
		private System.Windows.Forms.Button bttnContinue;
		private System.Windows.Forms.Button bttnCancelOrder;
		private System.Windows.Forms.Button bttnOk;
		private System.Windows.Forms.Label lbTotal;
		private System.Windows.Forms.GroupBox grbxPayment;
		private System.Windows.Forms.RadioButton rdbCreditCard;
		private System.Windows.Forms.RadioButton rdbCash;
		private System.Windows.Forms.CheckBox chcbxMyAdress;
		private System.Windows.Forms.Label lbAdress;
		private System.Windows.Forms.TextBox txtbxAdress;
		private System.Windows.Forms.GroupBox gbxCreditCartInfo;
		private System.Windows.Forms.ComboBox cbYear;
		private System.Windows.Forms.ComboBox cbMounth;
		private System.Windows.Forms.Label lbExpirationDate;
		private System.Windows.Forms.MaskedTextBox maskedTextBox2;
		private System.Windows.Forms.Label lbCardNumb;
		private System.Windows.Forms.Label lbSecurityCode;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.Label lbTotalShopingCard;
	}
}