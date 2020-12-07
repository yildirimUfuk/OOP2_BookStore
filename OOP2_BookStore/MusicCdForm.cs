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
	/// it is used to list the MusicCdForm
	/// </summary>
	public partial class MusicCdForm : Form
	{
		/// <summary>
		/// it contains musicCD object to list its information
		/// </summary>
		MusicCD musicCD;
		/// <summary>
		/// it contains shoppingCard to add new item to shoping Card
		/// </summary>
		ShoppingCard shoppingCard;
		/// <summary>
		/// the constructor
		/// </summary>
		/// <param name="musicCD"></param>
		/// <param name="shoppingCard"></param>
		public MusicCdForm(MusicCD musicCD, ShoppingCard shoppingCard)
		{
			InitializeComponent();
			this.shoppingCard = shoppingCard;
			this.Text = musicCD.Name;
			this.musicCD = musicCD;
			lbType.Text = "Type : " + this.musicCD.Mcdtype.ToString();
			lbMusicCDName.Text = this.musicCD.Name;
			lbsinger.Text = "Singer : " + this.musicCD.Singer;
			txtbxDescription.Text = "Description : " + this.musicCD.Description;
			pctrbxCoverPhoto.Image = this.musicCD.Photo1;
			lbPrice.Text = musicCD.Price.ToString() + "₺ " + musicCD.Sale.ToString() + "%";
			lbPrice2.Text = (musicCD.Price * (100 - musicCD.Sale) / 100).ToString() + "₺";
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
			shoppingCard.addProduct(new ItemToPurchase(this.musicCD, Convert.ToInt32(nudquantity.Value)));
			form = new AddedBasketForm(musicCD);
			form.Show();
		}
	}
}
