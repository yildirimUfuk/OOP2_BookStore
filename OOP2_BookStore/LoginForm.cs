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
	/// <summary>
	/// it shows the login form
	/// </summary>
	public partial class LoginForm : Form
	{
		/// <summary>
		/// the constructor
		/// </summary>
		public LoginForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lbSignUp_MouseMove(object sender, MouseEventArgs e)
		{
			lbSignUp.Font = new Font(lbSignUp.Font, FontStyle.Bold);
			lbSignUp.ForeColor = Color.Maroon;
			Cursor.Current = Cursors.Hand;
		}

		private void lbSignUp_MouseLeave(object sender, EventArgs e)
		{
			lbSignUp.Font = new Font(lbSignUp.Font, FontStyle.Regular);
			lbSignUp.ForeColor = Color.Black;
		}

		/// <summary>
		/// when this button is clicked the new customer are going to register. so we show a sign up secreen.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lbSignUp_Click(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((Label)sender).Name);
			SignUpForm signUpForm = new SignUpForm();
			this.Hide();
			signUpForm.ShowDialog();
			this.Close();
		}

		/// <summary>
		/// when user wants to login, this method select the user if it is admin or customer.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bttnLogIn_Click(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((Button)sender).Name);
			VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeriTabani");
			string query = "SELECT * FROM MusteriBilgileriTablosu WHERE userName='" + txtbcUserName.Text + "'and userPassword='" + txtbxPassWord.Text + "'";
			DataTable table = database.veriCek(query);
			//bir sınıfa atılcak
			if (table.Rows.Count == 1 && Convert.ToInt16(((DataRow)table.Rows[0])[7]) == 0)
			{
				DataRow row = table.Rows[0];
				MainForm.user = new Customer();
				MainForm.user.UserID = Convert.ToInt32(row[0]);
				MainForm.user.Name = row[1].ToString();
				MainForm.user.Surname = row[2].ToString();
				MainForm.user.Adress = row[3].ToString();
				MainForm.user.Email = row[4].ToString();
				MainForm.user.Username = row[5].ToString();
				MainForm.user.Password = row[6].ToString();
				this.DialogResult = DialogResult.Yes;
			}
			else if (table.Rows.Count == 1 && Convert.ToInt16(((DataRow)table.Rows[0])[7]) == 1)
			{
                MainForm.user = Admin.createAdmin();
				DataRow row = table.Rows[0];
				MainForm.user = new Customer();
				MainForm.user.UserID = Convert.ToInt32(row[0]);
				MainForm.user.Name = row[1].ToString();
				MainForm.user.Surname = row[2].ToString();
				MainForm.user.Adress = row[3].ToString();
				MainForm.user.Email = row[4].ToString();
				MainForm.user.Username = row[5].ToString();
				MainForm.user.Password = row[6].ToString();
				this.DialogResult = DialogResult.Yes;
			}
			else
			{
				MessageBox.Show("INVALID PASSWORD OR USER NAME");
			}
		}
	}
}
