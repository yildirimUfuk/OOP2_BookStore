namespace OOP2_BookStore
{
    partial class AdminForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
			this.dgvUrunler = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.musicCdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.magazineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnAdd = new System.Windows.Forms.Button();
			this.gbUrun = new System.Windows.Forms.GroupBox();
			this.lblMagazine = new System.Windows.Forms.Label();
			this.lblCD = new System.Windows.Forms.Label();
			this.lblBook = new System.Windows.Forms.Label();
			this.pbUrunResmi = new System.Windows.Forms.PictureBox();
			this.btnUserSettings = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.gbUrun.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbUrunResmi)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvUrunler
			// 
			this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUrunler.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvUrunler.Location = new System.Drawing.Point(16, 15);
			this.dgvUrunler.Margin = new System.Windows.Forms.Padding(4);
			this.dgvUrunler.MultiSelect = false;
			this.dgvUrunler.Name = "dgvUrunler";
			this.dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUrunler.Size = new System.Drawing.Size(1035, 378);
			this.dgvUrunler.TabIndex = 0;
			this.dgvUrunler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUrunler_CellDoubleClick);
			this.dgvUrunler.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUrunler_CellMouseLeave);
			this.dgvUrunler.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvUrunler_CellMouseMove);
			this.dgvUrunler.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DgvUrunler_MouseDown);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem,
            this.deleteItemToolStripMenuItem,
            this.updateItemToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(158, 76);
			// 
			// addItemToolStripMenuItem
			// 
			this.addItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.musicCdToolStripMenuItem,
            this.magazineToolStripMenuItem});
			this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
			this.addItemToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
			this.addItemToolStripMenuItem.Text = "Add item";
			// 
			// bookToolStripMenuItem
			// 
			this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
			this.bookToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
			this.bookToolStripMenuItem.Text = "Book";
			this.bookToolStripMenuItem.Click += new System.EventHandler(this.BookToolStripMenuItem_Click);
			// 
			// musicCdToolStripMenuItem
			// 
			this.musicCdToolStripMenuItem.Name = "musicCdToolStripMenuItem";
			this.musicCdToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
			this.musicCdToolStripMenuItem.Text = "Music Cd";
			this.musicCdToolStripMenuItem.Click += new System.EventHandler(this.MusicCdToolStripMenuItem_Click);
			// 
			// magazineToolStripMenuItem
			// 
			this.magazineToolStripMenuItem.Name = "magazineToolStripMenuItem";
			this.magazineToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
			this.magazineToolStripMenuItem.Text = "Magazine";
			this.magazineToolStripMenuItem.Click += new System.EventHandler(this.MagazineToolStripMenuItem_Click);
			// 
			// deleteItemToolStripMenuItem
			// 
			this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
			this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
			this.deleteItemToolStripMenuItem.Text = "Delete Item";
			this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.DeleteItemToolStripMenuItem_Click);
			// 
			// updateItemToolStripMenuItem
			// 
			this.updateItemToolStripMenuItem.Name = "updateItemToolStripMenuItem";
			this.updateItemToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
			this.updateItemToolStripMenuItem.Text = "UpdateItem";
			this.updateItemToolStripMenuItem.Click += new System.EventHandler(this.UpdateItemToolStripMenuItem_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(41, 441);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(161, 32);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "ADD";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			this.btnAdd.MouseEnter += new System.EventHandler(this.BtnAdd_MouseEnter);
			// 
			// gbUrun
			// 
			this.gbUrun.Controls.Add(this.lblMagazine);
			this.gbUrun.Controls.Add(this.lblCD);
			this.gbUrun.Controls.Add(this.lblBook);
			this.gbUrun.Location = new System.Drawing.Point(725, 427);
			this.gbUrun.Margin = new System.Windows.Forms.Padding(4);
			this.gbUrun.Name = "gbUrun";
			this.gbUrun.Padding = new System.Windows.Forms.Padding(4);
			this.gbUrun.Size = new System.Drawing.Size(96, 91);
			this.gbUrun.TabIndex = 3;
			this.gbUrun.TabStop = false;
			this.gbUrun.Text = "SELECT";
			this.gbUrun.Visible = false;
			// 
			// lblMagazine
			// 
			this.lblMagazine.AutoSize = true;
			this.lblMagazine.Location = new System.Drawing.Point(4, 68);
			this.lblMagazine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMagazine.Name = "lblMagazine";
			this.lblMagazine.Size = new System.Drawing.Size(69, 17);
			this.lblMagazine.TabIndex = 0;
			this.lblMagazine.Text = "Magazine";
			this.lblMagazine.Click += new System.EventHandler(this.LblMagazine_Click);
			this.lblMagazine.MouseLeave += new System.EventHandler(this.LblBook_MouseLeave);
			this.lblMagazine.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblBook_MouseMove);
			// 
			// lblCD
			// 
			this.lblCD.AutoSize = true;
			this.lblCD.Location = new System.Drawing.Point(4, 43);
			this.lblCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCD.Name = "lblCD";
			this.lblCD.Size = new System.Drawing.Size(27, 17);
			this.lblCD.TabIndex = 0;
			this.lblCD.Text = "CD";
			this.lblCD.Click += new System.EventHandler(this.LblCD_Click);
			this.lblCD.MouseLeave += new System.EventHandler(this.LblBook_MouseLeave);
			this.lblCD.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblBook_MouseMove);
			// 
			// lblBook
			// 
			this.lblBook.AutoSize = true;
			this.lblBook.Location = new System.Drawing.Point(4, 20);
			this.lblBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBook.Name = "lblBook";
			this.lblBook.Size = new System.Drawing.Size(40, 17);
			this.lblBook.TabIndex = 0;
			this.lblBook.Text = "Book";
			this.lblBook.Click += new System.EventHandler(this.LblBook_Click);
			this.lblBook.MouseLeave += new System.EventHandler(this.LblBook_MouseLeave);
			this.lblBook.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblBook_MouseMove);
			// 
			// pbUrunResmi
			// 
			this.pbUrunResmi.Location = new System.Drawing.Point(976, 441);
			this.pbUrunResmi.Margin = new System.Windows.Forms.Padding(4);
			this.pbUrunResmi.Name = "pbUrunResmi";
			this.pbUrunResmi.Size = new System.Drawing.Size(92, 102);
			this.pbUrunResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbUrunResmi.TabIndex = 1;
			this.pbUrunResmi.TabStop = false;
			// 
			// btnUserSettings
			// 
			this.btnUserSettings.Location = new System.Drawing.Point(211, 441);
			this.btnUserSettings.Margin = new System.Windows.Forms.Padding(4);
			this.btnUserSettings.Name = "btnUserSettings";
			this.btnUserSettings.Size = new System.Drawing.Size(161, 32);
			this.btnUserSettings.TabIndex = 4;
			this.btnUserSettings.Text = "USER SETTINGS";
			this.btnUserSettings.UseVisualStyleBackColor = true;
			this.btnUserSettings.Click += new System.EventHandler(this.BtnUserSettings_Click);
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.btnUserSettings);
			this.Controls.Add(this.gbUrun);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.pbUrunResmi);
			this.Controls.Add(this.dgvUrunler);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AdminForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminForm";
			this.Activated += new System.EventHandler(this.AdminForm_Activated);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.gbUrun.ResumeLayout(false);
			this.gbUrun.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbUrunResmi)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.PictureBox pbUrunResmi;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbUrun;
        private System.Windows.Forms.Label lblMagazine;
        private System.Windows.Forms.Label lblCD;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Button btnUserSettings;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicCdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magazineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateItemToolStripMenuItem;
    }
}