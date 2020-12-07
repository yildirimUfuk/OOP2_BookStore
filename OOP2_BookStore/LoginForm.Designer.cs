namespace OOP2_BookStore
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.txtbcUserName = new System.Windows.Forms.TextBox();
			this.txtbxPassWord = new System.Windows.Forms.TextBox();
			this.lbUserName = new System.Windows.Forms.Label();
			this.lbPassword = new System.Windows.Forms.Label();
			this.lbSignUp = new System.Windows.Forms.Label();
			this.bttnLogIn = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pcrbxLoginPhoto = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pcrbxLoginPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// txtbcUserName
			// 
			this.txtbcUserName.BackColor = System.Drawing.Color.White;
			this.txtbcUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtbcUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.txtbcUserName.Location = new System.Drawing.Point(60, 244);
			this.txtbcUserName.Margin = new System.Windows.Forms.Padding(4);
			this.txtbcUserName.Name = "txtbcUserName";
			this.txtbcUserName.Size = new System.Drawing.Size(268, 38);
			this.txtbcUserName.TabIndex = 0;
			// 
			// txtbxPassWord
			// 
			this.txtbxPassWord.BackColor = System.Drawing.Color.White;
			this.txtbxPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtbxPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.txtbxPassWord.Location = new System.Drawing.Point(60, 324);
			this.txtbxPassWord.Margin = new System.Windows.Forms.Padding(4);
			this.txtbxPassWord.Name = "txtbxPassWord";
			this.txtbxPassWord.PasswordChar = '?';
			this.txtbxPassWord.Size = new System.Drawing.Size(268, 38);
			this.txtbxPassWord.TabIndex = 1;
			// 
			// lbUserName
			// 
			this.lbUserName.AutoSize = true;
			this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbUserName.Location = new System.Drawing.Point(57, 224);
			this.lbUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbUserName.Name = "lbUserName";
			this.lbUserName.Size = new System.Drawing.Size(88, 17);
			this.lbUserName.TabIndex = 2;
			this.lbUserName.Text = "User Name";
			// 
			// lbPassword
			// 
			this.lbPassword.AutoSize = true;
			this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbPassword.Location = new System.Drawing.Point(57, 303);
			this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbPassword.Name = "lbPassword";
			this.lbPassword.Size = new System.Drawing.Size(77, 17);
			this.lbPassword.TabIndex = 2;
			this.lbPassword.Text = "Password";
			// 
			// lbSignUp
			// 
			this.lbSignUp.AutoSize = true;
			this.lbSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lbSignUp.Location = new System.Drawing.Point(55, 460);
			this.lbSignUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbSignUp.Name = "lbSignUp";
			this.lbSignUp.Size = new System.Drawing.Size(216, 20);
			this.lbSignUp.TabIndex = 3;
			this.lbSignUp.Text = "Don\'t you have an account?";
			this.lbSignUp.Click += new System.EventHandler(this.lbSignUp_Click);
			this.lbSignUp.MouseLeave += new System.EventHandler(this.lbSignUp_MouseLeave);
			this.lbSignUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbSignUp_MouseMove);
			// 
			// bttnLogIn
			// 
			this.bttnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(105)))), ((int)(((byte)(27)))));
			this.bttnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.bttnLogIn.ForeColor = System.Drawing.Color.White;
			this.bttnLogIn.Location = new System.Drawing.Point(129, 396);
			this.bttnLogIn.Margin = new System.Windows.Forms.Padding(4);
			this.bttnLogIn.Name = "bttnLogIn";
			this.bttnLogIn.Size = new System.Drawing.Size(126, 44);
			this.bttnLogIn.TabIndex = 2;
			this.bttnLogIn.Text = "Log In";
			this.bttnLogIn.UseVisualStyleBackColor = false;
			this.bttnLogIn.Click += new System.EventHandler(this.bttnLogIn_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(105)))), ((int)(((byte)(27)))));
			this.panel2.Location = new System.Drawing.Point(46, 367);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(292, 4);
			this.panel2.TabIndex = 4;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(105)))), ((int)(((byte)(27)))));
			this.panel1.Location = new System.Drawing.Point(46, 288);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(292, 4);
			this.panel1.TabIndex = 4;
			// 
			// pcrbxLoginPhoto
			// 
			this.pcrbxLoginPhoto.Image = global::OOP2_BookStore.Properties.Resources.loginOrange;
			this.pcrbxLoginPhoto.Location = new System.Drawing.Point(103, 12);
			this.pcrbxLoginPhoto.Margin = new System.Windows.Forms.Padding(4);
			this.pcrbxLoginPhoto.Name = "pcrbxLoginPhoto";
			this.pcrbxLoginPhoto.Size = new System.Drawing.Size(180, 176);
			this.pcrbxLoginPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcrbxLoginPhoto.TabIndex = 5;
			this.pcrbxLoginPhoto.TabStop = false;
			// 
			// LoginForm
			// 
			this.AcceptButton = this.bttnLogIn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(377, 538);
			this.Controls.Add(this.pcrbxLoginPhoto);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.bttnLogIn);
			this.Controls.Add(this.lbSignUp);
			this.Controls.Add(this.lbPassword);
			this.Controls.Add(this.lbUserName);
			this.Controls.Add(this.txtbxPassWord);
			this.Controls.Add(this.txtbcUserName);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginForm";
			((System.ComponentModel.ISupportInitialize)(this.pcrbxLoginPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtbcUserName;
		private System.Windows.Forms.TextBox txtbxPassWord;
		private System.Windows.Forms.Label lbUserName;
		private System.Windows.Forms.Label lbPassword;
		private System.Windows.Forms.Label lbSignUp;
		private System.Windows.Forms.Button bttnLogIn;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pcrbxLoginPhoto;
	}
}