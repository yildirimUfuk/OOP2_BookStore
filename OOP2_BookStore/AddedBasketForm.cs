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
	public partial class AddedBasketForm : Form
	{
		/// <summary>
		/// when an item added to shoping card appaear, it says that the item added successfully
		/// </summary>
		/// <param name="product"></param>
		public AddedBasketForm(Product product)
		{
			InitializeComponent();
			lbName.Text = product.Name;
			if (product.Sale != 0)
			{
				lbPriceSale.Text = product.Price + " %" + product.Sale.ToString();
				lbPrice.Text = (product.Price - ((double)product.Price * product.Sale / 100)).ToString() + "₺";
			}
			else
			{
				lbPriceSale.Visible = false;
				lbPrice.Text = product.Price.ToString();
			}
			pctrbxProductPhoto.Image = product.Photo1;
		}
	}
}
