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
	public partial class MagazineControl : UserControl
	{
		Magazine magazine;
		ShoppingCard shoppingCard;
		public MagazineControl(Magazine magazine,ShoppingCard shoppingCard)
		{
			this.magazine = magazine;
			InitializeComponent();
			this.shoppingCard = shoppingCard;

			txtbxName.Text = magazine.Name;
			lbPrice.Text = magazine.Price.ToString() + "₺ " + magazine.Sale.ToString() + "%";
			txtbxIssue.Text = magazine.Issue;
			lbPrice1.Text = magazine.Price.ToString();
			pctrxPhoto.Image = magazine.Photo1;
			lbPrice1.Text = (magazine.Price * (100 - magazine.Sale) / 100).ToString() + "₺";

		}

		private void pctrbxDetail_Click(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((PictureBox)sender).Name);
			magazine.printProperties();
		}

		private void pctrbxAddToBasket_Click(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((PictureBox)sender).Name);
			AddedBasketForm form;
			shoppingCard.addProduct(new ItemToPurchase(this.magazine, 1));
			form = new AddedBasketForm(magazine);
			form.Show();
		}

		private void pctrxPhoto_Click(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((PictureBox)sender).Name);
			AddedBasketForm form;
			shoppingCard.addProduct(new ItemToPurchase(this.magazine, 1));
			form = new AddedBasketForm(magazine);
			form.Show();
		}
	}
}
