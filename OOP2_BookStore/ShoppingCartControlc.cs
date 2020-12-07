using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_BookStore
{
	public partial class ShoppingCartControlc : UserControl
	{
		Product product;
		ShoppingCard shoppingCart;
		
		public ShoppingCartControlc(Product product,ShoppingCard shoppingCart)
		{
			this.shoppingCart = shoppingCart;
			this.product = product;

			InitializeComponent();
			ptbxProductPhoto.Image = product.Photo1;
			lbName.Text = product.Name;
			lbSale.Text = product.Sale.ToString() + "%";
			lbPrice.Text = ((double)product.Price * (1 - (double)product.Sale / 100)).ToString() + "₺";
			nudpiece.Value = shoppingCart.items[product.Id].quantity;
		}

		private void bttnDelete_Click(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((Button)sender).Name);
			shoppingCart.removeProduct(shoppingCart.items[product.Id]);
			shoppingCart.shoppingCartControlcs.Remove(this);
			MessageBox.Show("The Item Deleted From Shopping Card. ");
			this.Dispose();
		}

		private void nudpiece_ValueChanged(object sender, EventArgs e)
		{
			shoppingCart.items[product.Id].quantity = (int)nudpiece.Value;
			lbPrice.Text = (shoppingCart.items[product.Id].quantity * (shoppingCart.items[product.Id].product.Price * (100 - shoppingCart.items[product.Id].product.Sale)) / 100).ToString();
		}

		private void ShoppingCartControlc_Load(object sender, EventArgs e)
		{
			nudpiece.Value = shoppingCart.items[product.Id].quantity;
		}
	}
}
