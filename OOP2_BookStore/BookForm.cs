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
	public partial class BookForm : Form
	{
		/// <summary>
		/// it contains book object to list its information
		/// </summary>
		private Book book;
		/// <summary>
		/// it contains shoppingCard to add new item to shoping Card
		/// </summary>
		private ShoppingCard shoppingCard;
		/// <summary>
		/// the constructor
		/// </summary>
		/// <param name="book"></param>
		/// <param name="shoppingCard"></param>
		public BookForm(Book book, ShoppingCard shoppingCard)
		{
			InitializeComponent();
			this.Text = book.Name;
			this.shoppingCard = shoppingCard;
			this.book = book;
			lbBookName.Text = this.book.Name;
			lbPublisher.Text = "Publisher : " + this.book.Publisher;
			lbBookAuthor.Text = "Author : " + this.book.Author;
			pctrbxCoverPhoto.Image = this.book.Photo1;
			txtbxDescription.Text = "Description : " + this.book.Description;
			lbNoOfPage.Text = "Page : " + this.book.Page.ToString();
			lbType.Text = "Type : " + this.book.type.ToString();
			lbLanguage.Text = "Language : " + this.book.l_anguage.ToString();
			lbSize.Text = "Size : " + this.book.size;
			lbPrice.Text = book.Price.ToString() + "₺ " + book.Sale.ToString() + "%";
			lbPrice2.Text = (book.Price * (100 - book.Sale) / 100).ToString() + "₺";
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
			shoppingCard.addProduct(new ItemToPurchase(this.book, Convert.ToInt32(nudquantity.Value)));
			form = new AddedBasketForm(book);
			form.Show();
		}
	}
}
