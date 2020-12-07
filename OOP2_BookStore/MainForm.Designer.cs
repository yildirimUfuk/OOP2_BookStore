namespace OOP2_BookStore
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pnlMainPanel = new System.Windows.Forms.Panel();
			this.bttnUserName = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tbAra = new System.Windows.Forms.TextBox();
			this.btnAdminPaneli = new System.Windows.Forms.Button();
			this.pctrbxMenu = new System.Windows.Forms.PictureBox();
			this.bttnShopingCart = new System.Windows.Forms.Button();
			this.lb = new System.Windows.Forms.Label();
			this.pnlSearch = new System.Windows.Forms.Panel();
			this.pnlUserNameClicked = new System.Windows.Forms.Panel();
			this.bttnPuch = new System.Windows.Forms.Button();
			this.bttnProfile = new System.Windows.Forms.Button();
			this.bttnlogout = new System.Windows.Forms.Button();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.pnlShow = new System.Windows.Forms.FlowLayoutPanel();
			this.tvFilter = new System.Windows.Forms.TreeView();
			this.pnlBottom = new System.Windows.Forms.Panel();
			this.lbEUR = new System.Windows.Forms.Label();
			this.lbUSD = new System.Windows.Forms.Label();
			this.pnlMainPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctrbxMenu)).BeginInit();
			this.pnlUserNameClicked.SuspendLayout();
			this.pnlBottom.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlMainPanel
			// 
			this.pnlMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(128)))), ((int)(((byte)(151)))));
			this.pnlMainPanel.Controls.Add(this.bttnUserName);
			this.pnlMainPanel.Controls.Add(this.panel1);
			this.pnlMainPanel.Controls.Add(this.btnAdminPaneli);
			this.pnlMainPanel.Controls.Add(this.pctrbxMenu);
			this.pnlMainPanel.Controls.Add(this.bttnShopingCart);
			this.pnlMainPanel.Controls.Add(this.lb);
			this.pnlMainPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlMainPanel.Location = new System.Drawing.Point(0, 0);
			this.pnlMainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlMainPanel.Name = "pnlMainPanel";
			this.pnlMainPanel.Size = new System.Drawing.Size(1902, 70);
			this.pnlMainPanel.TabIndex = 0;
			// 
			// bttnUserName
			// 
			this.bttnUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bttnUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(128)))), ((int)(((byte)(151)))));
			this.bttnUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.bttnUserName.ForeColor = System.Drawing.Color.White;
			this.bttnUserName.Location = new System.Drawing.Point(1528, 19);
			this.bttnUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bttnUserName.Name = "bttnUserName";
			this.bttnUserName.Size = new System.Drawing.Size(160, 39);
			this.bttnUserName.TabIndex = 2;
			this.bttnUserName.Text = "User Name";
			this.bttnUserName.UseVisualStyleBackColor = false;
			this.bttnUserName.Click += new System.EventHandler(this.bttnUserName_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.tbAra);
			this.panel1.ForeColor = System.Drawing.SystemColors.Control;
			this.panel1.Location = new System.Drawing.Point(717, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(469, 33);
			this.panel1.TabIndex = 9;
			// 
			// tbAra
			// 
			this.tbAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(128)))), ((int)(((byte)(151)))));
			this.tbAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbAra.ForeColor = System.Drawing.Color.White;
			this.tbAra.Location = new System.Drawing.Point(4, 4);
			this.tbAra.Margin = new System.Windows.Forms.Padding(4);
			this.tbAra.Name = "tbAra";
			this.tbAra.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tbAra.Size = new System.Drawing.Size(460, 23);
			this.tbAra.TabIndex = 8;
			this.tbAra.Text = "Search";
			this.tbAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbAra.Click += new System.EventHandler(this.TbAra_Click);
			this.tbAra.TextChanged += new System.EventHandler(this.TbAra_TextChanged);
			// 
			// btnAdminPaneli
			// 
			this.btnAdminPaneli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdminPaneli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdminPaneli.ForeColor = System.Drawing.Color.White;
			this.btnAdminPaneli.Location = new System.Drawing.Point(1361, 19);
			this.btnAdminPaneli.Margin = new System.Windows.Forms.Padding(4);
			this.btnAdminPaneli.Name = "btnAdminPaneli";
			this.btnAdminPaneli.Size = new System.Drawing.Size(160, 39);
			this.btnAdminPaneli.TabIndex = 6;
			this.btnAdminPaneli.Text = "ADMIN PANEL";
			this.btnAdminPaneli.UseVisualStyleBackColor = true;
			this.btnAdminPaneli.Visible = false;
			this.btnAdminPaneli.Click += new System.EventHandler(this.BtnAdminPaneli_Click);
			// 
			// pctrbxMenu
			// 
			this.pctrbxMenu.Image = global::OOP2_BookStore.Properties.Resources.menu;
			this.pctrbxMenu.Location = new System.Drawing.Point(33, 17);
			this.pctrbxMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pctrbxMenu.Name = "pctrbxMenu";
			this.pctrbxMenu.Size = new System.Drawing.Size(48, 36);
			this.pctrbxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctrbxMenu.TabIndex = 7;
			this.pctrbxMenu.TabStop = false;
			this.pctrbxMenu.Click += new System.EventHandler(this.pctrbxMenu_Click);
			// 
			// bttnShopingCart
			// 
			this.bttnShopingCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bttnShopingCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(128)))), ((int)(((byte)(151)))));
			this.bttnShopingCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnShopingCart.ForeColor = System.Drawing.Color.White;
			this.bttnShopingCart.Location = new System.Drawing.Point(1694, 19);
			this.bttnShopingCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bttnShopingCart.Name = "bttnShopingCart";
			this.bttnShopingCart.Size = new System.Drawing.Size(144, 39);
			this.bttnShopingCart.TabIndex = 6;
			this.bttnShopingCart.Text = "Shopping Cart()";
			this.bttnShopingCart.UseVisualStyleBackColor = false;
			this.bttnShopingCart.Click += new System.EventHandler(this.bttnShopingCart_Click_1);
			// 
			// lb
			// 
			this.lb.AutoSize = true;
			this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
			this.lb.ForeColor = System.Drawing.Color.White;
			this.lb.Location = new System.Drawing.Point(87, 11);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(224, 48);
			this.lb.TabIndex = 4;
			this.lb.Text = "BookStore";
			this.lb.Click += new System.EventHandler(this.lb_Click);
			// 
			// pnlSearch
			// 
			this.pnlSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pnlSearch.AutoScroll = true;
			this.pnlSearch.BackColor = System.Drawing.Color.White;
			this.pnlSearch.Location = new System.Drawing.Point(717, 72);
			this.pnlSearch.Margin = new System.Windows.Forms.Padding(4);
			this.pnlSearch.Name = "pnlSearch";
			this.pnlSearch.Size = new System.Drawing.Size(469, 122);
			this.pnlSearch.TabIndex = 9;
			this.pnlSearch.Visible = false;
			this.pnlSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSearch_Paint);
			// 
			// pnlUserNameClicked
			// 
			this.pnlUserNameClicked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlUserNameClicked.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.pnlUserNameClicked.Controls.Add(this.bttnPuch);
			this.pnlUserNameClicked.Controls.Add(this.bttnProfile);
			this.pnlUserNameClicked.Controls.Add(this.bttnlogout);
			this.pnlUserNameClicked.Location = new System.Drawing.Point(1528, 76);
			this.pnlUserNameClicked.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlUserNameClicked.Name = "pnlUserNameClicked";
			this.pnlUserNameClicked.Size = new System.Drawing.Size(160, 162);
			this.pnlUserNameClicked.TabIndex = 2;
			// 
			// bttnPuch
			// 
			this.bttnPuch.FlatAppearance.BorderSize = 0;
			this.bttnPuch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnPuch.Location = new System.Drawing.Point(7, 112);
			this.bttnPuch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bttnPuch.Name = "bttnPuch";
			this.bttnPuch.Size = new System.Drawing.Size(145, 47);
			this.bttnPuch.TabIndex = 1;
			this.bttnPuch.Text = "Previous Purchases";
			this.bttnPuch.UseVisualStyleBackColor = true;
			this.bttnPuch.Click += new System.EventHandler(this.bttnPuch_Click);
			// 
			// bttnProfile
			// 
			this.bttnProfile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.bttnProfile.FlatAppearance.BorderSize = 0;
			this.bttnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnProfile.Location = new System.Drawing.Point(7, 4);
			this.bttnProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bttnProfile.Name = "bttnProfile";
			this.bttnProfile.Size = new System.Drawing.Size(145, 47);
			this.bttnProfile.TabIndex = 0;
			this.bttnProfile.Text = "Profile";
			this.bttnProfile.UseVisualStyleBackColor = false;
			this.bttnProfile.Click += new System.EventHandler(this.bttnProfile_Click);
			// 
			// bttnlogout
			// 
			this.bttnlogout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.bttnlogout.FlatAppearance.BorderSize = 0;
			this.bttnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnlogout.Location = new System.Drawing.Point(7, 58);
			this.bttnlogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bttnlogout.Name = "bttnlogout";
			this.bttnlogout.Size = new System.Drawing.Size(145, 47);
			this.bttnlogout.TabIndex = 0;
			this.bttnlogout.Text = "Log Out";
			this.bttnlogout.UseVisualStyleBackColor = false;
			this.bttnlogout.Click += new System.EventHandler(this.bttnlogout_Click);
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Location = new System.Drawing.Point(1677, 878);
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(21, 80);
			this.vScrollBar1.TabIndex = 4;
			this.vScrollBar1.Visible = false;
			// 
			// pnlShow
			// 
			this.pnlShow.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pnlShow.AutoSize = true;
			this.pnlShow.Location = new System.Drawing.Point(324, 76);
			this.pnlShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlShow.MaximumSize = new System.Drawing.Size(1255, 0);
			this.pnlShow.Name = "pnlShow";
			this.pnlShow.Size = new System.Drawing.Size(1255, 0);
			this.pnlShow.TabIndex = 0;
			// 
			// tvFilter
			// 
			this.tvFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
			this.tvFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tvFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tvFilter.Location = new System.Drawing.Point(0, 71);
			this.tvFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tvFilter.Name = "tvFilter";
			this.tvFilter.Size = new System.Drawing.Size(282, 525);
			this.tvFilter.TabIndex = 0;
			this.tvFilter.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvFilter_AfterSelect);
			// 
			// pnlBottom
			// 
			this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(128)))), ((int)(((byte)(151)))));
			this.pnlBottom.Controls.Add(this.lbEUR);
			this.pnlBottom.Controls.Add(this.lbUSD);
			this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottom.Location = new System.Drawing.Point(0, 994);
			this.pnlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlBottom.Name = "pnlBottom";
			this.pnlBottom.Size = new System.Drawing.Size(1902, 39);
			this.pnlBottom.TabIndex = 5;
			// 
			// lbEUR
			// 
			this.lbEUR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbEUR.AutoSize = true;
			this.lbEUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbEUR.ForeColor = System.Drawing.Color.White;
			this.lbEUR.Location = new System.Drawing.Point(957, 6);
			this.lbEUR.Name = "lbEUR";
			this.lbEUR.Size = new System.Drawing.Size(89, 25);
			this.lbEUR.TabIndex = 0;
			this.lbEUR.Text = "EUR :    ;";
			// 
			// lbUSD
			// 
			this.lbUSD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbUSD.AutoSize = true;
			this.lbUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbUSD.ForeColor = System.Drawing.Color.White;
			this.lbUSD.Location = new System.Drawing.Point(780, 6);
			this.lbUSD.Name = "lbUSD";
			this.lbUSD.Size = new System.Drawing.Size(91, 25);
			this.lbUSD.TabIndex = 0;
			this.lbUSD.Text = "USD :    ;";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1902, 1033);
			this.Controls.Add(this.pnlSearch);
			this.Controls.Add(this.pnlBottom);
			this.Controls.Add(this.tvFilter);
			this.Controls.Add(this.pnlShow);
			this.Controls.Add(this.vScrollBar1);
			this.Controls.Add(this.pnlUserNameClicked);
			this.Controls.Add(this.pnlMainPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Book Store";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Activated += new System.EventHandler(this.MainForm_Activated);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Click += new System.EventHandler(this.MainForm_Click);
			this.pnlMainPanel.ResumeLayout(false);
			this.pnlMainPanel.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctrbxMenu)).EndInit();
			this.pnlUserNameClicked.ResumeLayout(false);
			this.pnlBottom.ResumeLayout(false);
			this.pnlBottom.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlMainPanel;
		private System.Windows.Forms.Button bttnUserName;
		private System.Windows.Forms.Panel pnlUserNameClicked;
		private System.Windows.Forms.Button bttnProfile;
		private System.Windows.Forms.Button bttnlogout;
		private System.Windows.Forms.Label lb;
		private System.Windows.Forms.VScrollBar vScrollBar1;
		private System.Windows.Forms.FlowLayoutPanel pnlShow;
		private System.Windows.Forms.Button bttnShopingCart;
		private System.Windows.Forms.TreeView tvFilter;
		private System.Windows.Forms.PictureBox pctrbxMenu;
		private System.Windows.Forms.Panel pnlBottom;
		private System.Windows.Forms.Label lbUSD;
		private System.Windows.Forms.Label lbEUR;
		private System.Windows.Forms.Button bttnPuch;
        private System.Windows.Forms.Button btnAdminPaneli;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox tbAra;
		private System.Windows.Forms.Panel panel1;
	}
}