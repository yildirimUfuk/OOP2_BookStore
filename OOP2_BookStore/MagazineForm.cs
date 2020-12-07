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
	/// it is used to list the Magazine
	/// </summary>
	public partial class MagazineForm : Form
	{
		/// <summary>
		/// it contains magazine object to list its information
		/// </summary>
		Magazine magazine;
		/// <summary>
		/// it contains shoppingCard to add new item to shoping Card
		/// </summary>
		ShoppingCard shoppingCard;
		/// <summary>
		/// the constructor
		/// </summary>
		/// <param name="magazine"></param>
		/// <param name="shoppingCard"></param>
		public MagazineForm(Magazine magazine, ShoppingCard shoppingCard)
		{
			InitializeComponent();
			this.magazine = magazine;
			this.shoppingCard = shoppingCard;
			this.Text = magazine.Name;
			lbType.Text = "Type : " + magazine.Mtype.ToString();
			lbMagazineName.Text = magazine.Name;
			txtbxDescription.Text = magazine.Description;
			pctrbxCoverPhoto.Image = this.magazine.Photo1;
			lbIssue.Text = "Issue : " + this.magazine.Issue;
			lbPrice.Text = magazine.Price.ToString() + "₺ " + magazine.Sale.ToString() + "%";
			lbPrice2.Text = (magazine.Price * (100 - magazine.Sale) / 100).ToString() + "₺";
		}

		/// <summary>
		/// it adds the product to shopping card
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pctrbxAddToBasket_Click(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((PictureBox)sender).Name);
			AddedBasketForm form;
			shoppingCard.addProduct(new ItemToPurchase(this.magazine, Convert.ToInt32(nudquantity.Value)));
			form = new AddedBasketForm(magazine);
			form.Show();
		}

		private void pctrbxCoverPhoto_Click(object sender, EventArgs e)
		{

		}
	}
}
