namespace OOP2_BookStore
{
	partial class MainFormPanelWithPicture
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
			this.components = new System.ComponentModel.Container();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lbMagazine = new System.Windows.Forms.Label();
			this.flytbMagazine = new System.Windows.Forms.FlowLayoutPanel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lbMusic = new System.Windows.Forms.Label();
			this.flytbMusic = new System.Windows.Forms.FlowLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbBook = new System.Windows.Forms.Label();
			this.pnlpicture = new System.Windows.Forms.Panel();
			this.pctrbxsitephoto = new System.Windows.Forms.PictureBox();
			this.flytbBook = new System.Windows.Forms.FlowLayoutPanel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pnlpicture.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctrbxsitephoto)).BeginInit();
			this.SuspendLayout();
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
			this.panel4.Controls.Add(this.lbMagazine);
			this.panel4.Location = new System.Drawing.Point(3, 1538);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1248, 59);
			this.panel4.TabIndex = 17;
			// 
			// lbMagazine
			// 
			this.lbMagazine.AutoSize = true;
			this.lbMagazine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.lbMagazine.Location = new System.Drawing.Point(545, 10);
			this.lbMagazine.Name = "lbMagazine";
			this.lbMagazine.Size = new System.Drawing.Size(165, 39);
			this.lbMagazine.TabIndex = 0;
			this.lbMagazine.Text = "Magazine";
			this.lbMagazine.Click += new System.EventHandler(this.lbProducts_Click);
			// 
			// flytbMagazine
			// 
			this.flytbMagazine.AutoScroll = true;
			this.flytbMagazine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flytbMagazine.BackColor = System.Drawing.SystemColors.Control;
			this.flytbMagazine.Location = new System.Drawing.Point(3, 1603);
			this.flytbMagazine.Name = "flytbMagazine";
			this.flytbMagazine.Size = new System.Drawing.Size(1248, 486);
			this.flytbMagazine.TabIndex = 16;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
			this.panel3.Controls.Add(this.lbMusic);
			this.panel3.Location = new System.Drawing.Point(3, 988);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1248, 59);
			this.panel3.TabIndex = 15;
			// 
			// lbMusic
			// 
			this.lbMusic.AutoSize = true;
			this.lbMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.lbMusic.Location = new System.Drawing.Point(574, 10);
			this.lbMusic.Name = "lbMusic";
			this.lbMusic.Size = new System.Drawing.Size(106, 39);
			this.lbMusic.TabIndex = 0;
			this.lbMusic.Text = "Music";
			this.lbMusic.Click += new System.EventHandler(this.lbProducts_Click);
			// 
			// flytbMusic
			// 
			this.flytbMusic.AutoScroll = true;
			this.flytbMusic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flytbMusic.BackColor = System.Drawing.SystemColors.Control;
			this.flytbMusic.Location = new System.Drawing.Point(3, 1049);
			this.flytbMusic.Name = "flytbMusic";
			this.flytbMusic.Size = new System.Drawing.Size(1248, 486);
			this.flytbMusic.TabIndex = 14;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
			this.panel2.Controls.Add(this.lbBook);
			this.panel2.Location = new System.Drawing.Point(3, 435);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1248, 59);
			this.panel2.TabIndex = 13;
			// 
			// lbBook
			// 
			this.lbBook.AutoSize = true;
			this.lbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.lbBook.Location = new System.Drawing.Point(580, 10);
			this.lbBook.Name = "lbBook";
			this.lbBook.Size = new System.Drawing.Size(95, 39);
			this.lbBook.TabIndex = 0;
			this.lbBook.Text = "Book";
			this.lbBook.Click += new System.EventHandler(this.lbProducts_Click);
			// 
			// pnlpicture
			// 
			this.pnlpicture.Controls.Add(this.pctrbxsitephoto);
			this.pnlpicture.Location = new System.Drawing.Point(3, 8);
			this.pnlpicture.Name = "pnlpicture";
			this.pnlpicture.Size = new System.Drawing.Size(1248, 421);
			this.pnlpicture.TabIndex = 12;
			// 
			// pctrbxsitephoto
			// 
			this.pctrbxsitephoto.Location = new System.Drawing.Point(3, 3);
			this.pctrbxsitephoto.Name = "pctrbxsitephoto";
			this.pctrbxsitephoto.Size = new System.Drawing.Size(1242, 415);
			this.pctrbxsitephoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctrbxsitephoto.TabIndex = 0;
			this.pctrbxsitephoto.TabStop = false;
			// 
			// flytbBook
			// 
			this.flytbBook.AutoScroll = true;
			this.flytbBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flytbBook.BackColor = System.Drawing.SystemColors.Control;
			this.flytbBook.Location = new System.Drawing.Point(3, 500);
			this.flytbBook.Name = "flytbBook";
			this.flytbBook.Size = new System.Drawing.Size(1248, 486);
			this.flytbBook.TabIndex = 11;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 4000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// MainFormPanelWithPicture
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.flytbMagazine);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.flytbMusic);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pnlpicture);
			this.Controls.Add(this.flytbBook);
			this.Name = "MainFormPanelWithPicture";
			this.Size = new System.Drawing.Size(1255, 2111);
			this.Load += new System.EventHandler(this.MainFormPanelWithPicture_Load);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.pnlpicture.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pctrbxsitephoto)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label lbMagazine;
		private System.Windows.Forms.FlowLayoutPanel flytbMagazine;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label lbMusic;
		private System.Windows.Forms.FlowLayoutPanel flytbMusic;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbBook;
		private System.Windows.Forms.Panel pnlpicture;
		private System.Windows.Forms.FlowLayoutPanel flytbBook;
		public System.Windows.Forms.PictureBox pctrbxsitephoto;
		private System.Windows.Forms.Timer timer1;
	}
}
