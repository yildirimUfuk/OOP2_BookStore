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
	public partial class ShoppingCartForm : Form
	{
		/// <summary>
		/// shoping card details
		/// </summary>
		public ShoppingCard shoppingCard;

		/// <summary>
		/// constructor
		/// </summary>
		/// <param name="card"></param>
		public ShoppingCartForm(ShoppingCard card)
		{
			shoppingCard = card;
			
			InitializeComponent();
			for (int i = 0; i < shoppingCard.items.Count; i++)
			{
				flpList.Controls.Add(shoppingCard.shoppingCartControlcs[i]);
			}
			int year = DateTime.Now.Year;
			for(int i=0;i<5;i++)
			{
				cbYear.Items.Add(year.ToString());
				year++;
			}
		}

		/// <summary>
		/// it list shopping card details
		/// </summary>
		public void Show()
		{
			list();
			this.ShowDialog();
		}

		/// <summary>
		/// it list the product
		/// </summary>
		private void list()
		{
			flpList.Controls.Clear();
			for (int i = 0; i < shoppingCard.items.Count; i++)
			{
				flpList.Controls.Add(shoppingCard.shoppingCartControlcs[i]);
			}
		}

		/// <summary>
		/// it refresh the list
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ShoppingCartForm_Activated(object sender, EventArgs e)
		{
			list();
			shoppingCard.PaymentAmount = 0;
			for (int i = 0; i < shoppingCard.items.Count; i++)
			{
				shoppingCard.PaymentAmount += shoppingCard.items.ElementAt(i).Value.quantity * shoppingCard.items.ElementAt(i).Value.product.Price * (100 - shoppingCard.items.ElementAt(i).Value.product.Sale) / 100;
			}
			tcShoppingCart.SelectedIndex = 0;
			lbTotal.Text = shoppingCard.PaymentAmount.ToString();
			lbTotalShopingCard.Text = shoppingCard.PaymentAmount.ToString();
			lbTotal.Text = "Total : " + shoppingCard.PaymentAmount.ToString();
			lbTotalShopingCard.Text = "Total : " + shoppingCard.PaymentAmount.ToString();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ShoppingCartForm_Load(object sender, EventArgs e)
		{
			tcShoppingCart.SelectedIndex = 0;
			shoppingCard.PaymentAmount = 0;
			for (int i = 0; i < shoppingCard.items.Count; i++)
			{
				shoppingCard.PaymentAmount += shoppingCard.items.ElementAt(i).Value.quantity * shoppingCard.items.ElementAt(i).Value.product.Price * (100 - shoppingCard.items.ElementAt(i).Value.product.Sale) / 100;
			}
			//tcShoppingCart.SelectedIndex = 1;
			lbTotal.Text = "Total : " + shoppingCard.PaymentAmount.ToString();
			lbTotalShopingCard.Text = "Total : " + shoppingCard.PaymentAmount.ToString();

		}

		/// <summary>
		/// it delete all things in shopping card
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bttnCancelOrder_Click(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((Button)sender).Name);
			shoppingCard.cancelOrder();
			MessageBox.Show("Your Card is empty");
		}

		/// <summary>
		/// it pass next index
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bttnContinue_Click(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((Button)sender).Name);
			if (MainForm.user == null)
			{
				if (shoppingCard.PaymentAmount != 0)
				{
					LoginForm login = new LoginForm();
					DialogResult result = login.ShowDialog();
					if (result == DialogResult.Yes)
					{
						tcShoppingCart.SelectedIndex = 1;
					}
				}
				else
				{
					MessageBox.Show("Your Cart is empty");
				}
			}
			else
			{
				if (shoppingCard.PaymentAmount == 0)
				{
					MessageBox.Show("Your Cart is empty");
					tcShoppingCart.SelectedIndex = 0;
				}
				else
				{
					tcShoppingCart.SelectedIndex = 1;

				}
			}
		}

		/// <summary>
		/// event its control the payment types
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rdbCreditCard_CheckedChanged(object sender, EventArgs e)
		{
            gbxCreditCartInfo.Visible = true;
		}

		/// <summary>
		/// event its control the payment types
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tcShoppingCart_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tcShoppingCart.SelectedIndex == 1)
			{
				if (shoppingCard.items.Count == 0)
				{
					tcShoppingCart.SelectedIndex = 0;
					MessageBox.Show("Your Cart is empty");
					return;
				}
				if (MainForm.user == null)
				{
					tcShoppingCart.SelectedIndex = 0;
					tcShoppingCart.SelectedIndex = 0;
					LoginForm loginForm = new LoginForm();
					DialogResult result = loginForm.ShowDialog();
					if (result == DialogResult.Yes)
					{
						tcShoppingCart.SelectedIndex = 1;
					}
					else
					{
						tcShoppingCart.SelectedIndex = 0;
					}

				}
				if (shoppingCard.PaymentAmount < 50)
				{
					lbTotal.Text = "Total Price + Shiping = " + (shoppingCard.PaymentAmount + 5);
				}
				
			}
		}

		/// <summary>
		/// it pass next index
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bttnOk_Click(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((Button)sender).Name);
			if (txtbxAdress.Text != "")
			{
				if (rdbCreditCard.Checked == true)
				{
					if (maskedTextBox1.Text == "" || maskedTextBox2.Text == "" || cbMounth.Text == "" || cbYear.Text == "")
					{
						MessageBox.Show("Your information is missing");
						return;
					}
					else
					{
						shoppingCard.placeOrder(txtbxAdress.Text);
						this.Close();
						return;
					}
				}
				else
				{ 					
					shoppingCard.placeOrder(txtbxAdress.Text);
					this.Close();
					return;
				}
			}
			MessageBox.Show("Your Adress Box is Empty");
		}

		/// <summary>
		/// event its control the payment types
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RdbCash_CheckedChanged(object sender, EventArgs e)
        {
            gbxCreditCartInfo.Visible = false;
        }

		/// <summary>
		/// it controls the order adress
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void chcbxMyAdress_CheckedChanged(object sender, EventArgs e)
		{
			if (((CheckBox)sender).Checked == true)
			{
				txtbxAdress.Text = MainForm.user.Adress;
			}
			else
			{
				txtbxAdress.Text = "";
			}
		}
	}
}
