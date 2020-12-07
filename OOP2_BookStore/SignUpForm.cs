using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace OOP2_BookStore
{
	public partial class SignUpForm : Form
	{
		/// <summary>
		/// constructor
		/// </summary>
		public SignUpForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// it saves the user
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bttnSignUp_Click(object sender, EventArgs e)
		{
			if (txtbxName.Text == "")
			{
				lbName.ForeColor = Color.Maroon;
			}
			else if (txtbxAdress.Text == "")
			{
				lbAdress.ForeColor = Color.Maroon;
			}
			else if (txtbxMail.Text == "")
			{
				lbMail.ForeColor = Color.Maroon;
			}
			else if (txtbxcheck.Text == "")
			{
				lbcheck.ForeColor = Color.Maroon;
			}
			else if (txtbxPassWord.Text == "")
			{
				lbPassWord.ForeColor = Color.Maroon;
			}
			else if (txtbxSurname.Text == "")
			{
				lbSurname.ForeColor = Color.Maroon;
			}
			else if (txtbxUserName.Text == "")
			{
				lbUserName.ForeColor = Color.Maroon;
			}
			else if (txtbxcheck.Text == txtbxPassWord.Text)
			{
				if (IsValidEmail(txtbxMail.Text))
				{
					try
					{
						VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
						string checkQuery = "select * from MusteriBilgileriTablosu where userName ='" + txtbxUserName.Text + "'";
						DataTable check = database.veriCek(checkQuery);
						if (check.Rows.Count == 0)
						{
							string query = "INSERT INTO MusteriBilgileriTablosu(customerName,customerSurname,customerAdress,customerEmail,userName,userPassword,userAuthorization) VALUES('" + txtbxName.Text + "','" + txtbxSurname.Text + "','" + txtbxAdress.Text + "','" + txtbxMail.Text + "','" + txtbxUserName.Text + "','" + txtbxPassWord.Text + "'," + 0 + ")";
							database.veriKaydet(query);

							Task.Delay(5000).Wait();

							query = "SELECT * FROM MusteriBilgileriTablosu WHERE userName='" + txtbxSurname.Text + "'and userPassword='" + txtbxPassWord.Text + "'";
							DataTable table = database.veriCek(query);
							DataRow row = table.Rows[0];
							MainForm.user = new Customer();
							MainForm.user.UserID = Convert.ToInt32(row[0]);
							MainForm.user.Name = row[1].ToString();
							MainForm.user.Surname = row[2].ToString();
							MainForm.user.Adress = row[3].ToString();
							MainForm.user.Email = row[4].ToString();
							MainForm.user.Username = row[5].ToString();
							MainForm.user.Password = row[6].ToString();

							this.Close();
						}
						else
						{
							MessageBox.Show("This user name using by another user");
							lbUserName.ForeColor = Color.Maroon;
						}
					}
					catch { }
				}
				else
				{
					MessageBox.Show("This mail was not found");
				}
			}
		}
		/// <summary>
		/// it check given is an email
		/// </summary>
		/// <param name="email">checking email</param>
		/// <returns>if correction of email</returns>
		bool IsValidEmail(string email)
		{
			try
			{
				var addr = new System.Net.Mail.MailAddress(email);
				return addr.Address == email;
			}
			catch
			{
				return false;
			}
		}
	}
}
