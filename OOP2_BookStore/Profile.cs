using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_BookStore
{
	public partial class Profile : Form
	{
		/// <summary>
		/// user to list its information
		/// </summary>
		User user;
		/// <summary>
		/// this constructor using to show given user information or change its values
		/// </summary>
		/// <param name="user"></param>
		/// <param name="chose"></param>
		public Profile(User user, int chose)
		{
			InitializeComponent();
			this.user = user;
			if (chose == 1)
			{
				txtbxName.Text = user.Name;
				txtbxSurname.Text = user.Surname;
				txtbxUserName.Text = user.Username;
				txtbxAdress.Text = user.Adress;
				txtbxMail.Text = user.Email;
				txtbxName.Enabled = false;
				txtbxName.BackColor = Color.White;
				txtbxName.ForeColor = Color.Black;
				txtbxSurname.Enabled = false;
				txtbxSurname.BackColor = Color.White;
				txtbxSurname.ForeColor = Color.Black;
				txtbxUserName.Enabled = false;
				txtbxUserName.BackColor = Color.White;
				txtbxUserName.ForeColor = Color.Black;
				txtbxAdress.Enabled = false;
				txtbxAdress.BackColor = Color.White;
				txtbxAdress.ForeColor = Color.Black;
				txtbxMail.Enabled = false;
				txtbxMail.BackColor = Color.White;
				txtbxMail.ForeColor = Color.Black;
				lbPassWord.Visible = false;
				txtbxPassWord.Visible = false;
				bttnSignUp.Text = "Changes";
				lbCheckedPassword.Visible = false;
				txtbxCheckedPassword.Visible = false;

			}
		}
		/// <summary>
		/// it is using to change users information 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bttnSignUp_Click(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((Button)sender).Name);
			if (bttnSignUp.Text == "Changes")
			{
				txtbxName.Text = user.Name;
				txtbxSurname.Text = user.Surname;
				txtbxUserName.Text = user.Username;
				txtbxAdress.Text = user.Adress;
				txtbxMail.Text = user.Email;
				txtbxPassWord.Text = user.Password;
				txtbxName.Enabled = true;
				txtbxName.BackColor = Color.White;
				txtbxName.ForeColor = Color.Black;
				txtbxSurname.Enabled = true;
				txtbxSurname.BackColor = Color.White;
				txtbxSurname.ForeColor = Color.Black;
				txtbxUserName.Enabled = true;
				txtbxUserName.BackColor = Color.White;
				txtbxUserName.ForeColor = Color.Black;
				txtbxAdress.Enabled = true;
				txtbxAdress.BackColor = Color.White;
				txtbxAdress.ForeColor = Color.Black;
				txtbxMail.Enabled = true;
				txtbxMail.BackColor = Color.White;
				txtbxMail.ForeColor = Color.Black;
				lbPassWord.Visible = true;
				txtbxPassWord.Visible = true;
				lbCheckedPassword.Visible = true;
				txtbxCheckedPassword.Visible = true;
				bttnSignUp.Text = "Save";
				txtbxCheckedPassword.Text = user.Password;

			}
			else if (bttnSignUp.Text == "Save")
			{
				if (txtbxSurname.Text != "" && txtbxUserName.Text != "" && Text != "" && txtbxName.Text != "" && txtbxMail.Text != "" && txtbxAdress.Text != "" && txtbxPassWord.Text != "" && txtbxCheckedPassword.Text != "")
				{
					if (txtbxPassWord.Text == txtbxCheckedPassword.Text)
					{
						int countindatabase = 0;
						VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
						string query = "select * from MusteriBilgileriTablosu where userName = '" + txtbxUserName.Text + "'";
						if (txtbxUserName.Text == user.Username)
						{
							countindatabase++;
						}
						if (database.veriCek(query).Rows.Count == countindatabase)
						{
							user.Adress = txtbxAdress.Text;
							user.Email = txtbxMail.Text;
							user.Name = txtbxName.Text;
							user.Password = txtbxPassWord.Text;
							user.Surname = txtbxSurname.Text;
							user.Username = txtbxUserName.Text;
							((Customer)user).saveCustomer();
							MessageBox.Show("Your Information saved succesfully");
							this.Close();
							return;
						}
						MessageBox.Show("Your password dont match");
						return;

					}
					MessageBox.Show("This username is using from another user");
					return;
				}
				else
				{
					MessageBox.Show("there are empty areas");
					return;
				}
			}

		}
		/// <summary>
		/// it is for control user info
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtbxPassWord_TextChanged(object sender, EventArgs e)
		{
			txtbxCheckedPassword.Text = "";
		}
	}
}
