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
	/// <summary>
	/// it is used to list the books
	/// </summary>
	public partial class BookControl : UserControl
	{
		/// <summary>
		/// it contains book object to list its information
		/// </summary>
		Book book;
		/// <summary>
		/// it contains shoppingCard to add new item to shoping Card
		/// </summary>
		ShoppingCard shoppingCard;
		/// <summary>
		/// the constructor
		/// </summary>
		/// <param name="book"></param>
		/// <param name="shoppingCard"></param>
		public BookControl(Book book,ShoppingCard shoppingCard)
		{
			this.book = book;
			InitializeComponent();
			this.shoppingCard = shoppingCard;
			txtbxAuthor.Text = book.Author;
			lbPrice.Text = book.Price.ToString() + "₺ "+ book.Sale.ToString() + "%";
			txtbxPublisher.Text = book.Publisher;
			txtbxName.Text = book.Name;
			pctrxPhoto.Image = book.Photo1;
			lbPrice1.Text = (book.Price * (100 - book.Sale) / 100).ToString() + "₺";
		}
		/// <summary>
		/// it shows the information of the book. so it shows a BookForm object
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pctrbxDetail_Click(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((PictureBox)sender).Name);
			book.printProperties();
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
			shoppingCard.addProduct(new ItemToPurchase(this.book, 1));
			form = new AddedBasketForm(book);
			form.Show();
		}
	}
}
