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
	/// it is used to list the musicCDs
	/// </summary>
	public partial class MusicCdControl : UserControl
	{
		/// <summary>
		/// it contains MusicCD object to list its information
		/// </summary>
		MusicCD musicCD;

		/// <summary>
		/// it contains shoppingCard to add new item to shoping Card
		/// </summary>
		ShoppingCard shoppingCard;

		/// <summary>
		/// the constructor
		/// </summary>
		/// <param name="music"></param>
		/// <param name="shoppingCard"></param>
		public MusicCdControl(MusicCD music, ShoppingCard shoppingCard)
		{
			InitializeComponent();
			this.musicCD = music;
			this.shoppingCard = shoppingCard;
			txtbxName.Text = musicCD.Name;
			lbPrice.Text = musicCD.Price.ToString() + "₺ " + musicCD.Sale.ToString() + "%";
			txtbxSinger.Text = musicCD.Singer;
			lbPrice1.Text = musicCD.Price.ToString();
			pctrxPhoto.Image = musicCD.Photo1;
			lbPrice1.Text = (music.Price * (100 - music.Sale) / 100).ToString() + "₺";
		}

		/// <summary>
		/// it shows the information of the music. so it shows a BookmusicCD object
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pctrbxDetail_Click(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((PictureBox)sender).Name);
			musicCD.printProperties();
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
			shoppingCard.addProduct(new ItemToPurchase(this.musicCD, 1));
			form = new AddedBasketForm(musicCD);
			form.Show();
		}

		private void pctrxPhoto_Click(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((PictureBox)sender).Name);
			AddedBasketForm form;
			shoppingCard.addProduct(new ItemToPurchase(this.musicCD, 1));
			form = new AddedBasketForm(musicCD);
			form.Show();
		}
	}
}
