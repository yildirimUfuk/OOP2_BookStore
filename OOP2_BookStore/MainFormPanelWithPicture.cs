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
	public partial class MainFormPanelWithPicture : UserControl
	{
		MainForm mainform;
		AddNewProductFromDatabase addNewProductFromDatabase;
		public MainFormPanelWithPicture(MainForm mainform)
		{

			this.mainform = mainform;
			InitializeComponent();
			addNewProductFromDatabase = AddNewProductFromDatabase.CreateAddNewProductFromDatabase();
			VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
			int i = 0;
			string query = "select * from UrunlerTablosu where productType = 1 and visibility= 1";
			DataTable table = database.veriCek(query);
			foreach (DataRow item in table.Rows)
			{
				Product book = addNewProductFromDatabase.CreateNewItem(item);
				BookControl cont = new BookControl((Book)book, mainform.shoppingCard);
				flytbBook.Controls.Add(cont);
				i++;
				if(i==6)
				{
					break;
				}
			}
			pctrbxsitephoto.Image = new Bitmap("kitap" + (pictureindex % 3 + 1).ToString() + ".jpg");
			query = "select * from UrunlerTablosu where productType = 2 and visibility= 1";
			table = database.veriCek(query);
			i = 0;
			foreach (DataRow item in table.Rows)
			{
				Product music = addNewProductFromDatabase.CreateNewItem(item);
				MusicCdControl cont = new MusicCdControl((MusicCD)music,mainform.shoppingCard);
				flytbMusic.Controls.Add(cont);
				i++;
				if (i == 6)
				{
					break;
				}
			}
			query = "select * from UrunlerTablosu where productType = 3 and visibility= 1";
			table = database.veriCek(query);
			i = 0;
			foreach (DataRow item in table.Rows)
			{
				Product magazine = addNewProductFromDatabase.CreateNewItem(item);
				MagazineControl cont = new MagazineControl((Magazine)magazine, mainform.shoppingCard);
				flytbMagazine.Controls.Add(cont);
				i++;
				if (i == 6)
				{
					break;
				}
			}
		}

		public void upload()
		{
			flytbBook.Controls.Clear();
			flytbMusic.Controls.Clear();
			flytbMagazine.Controls.Clear();

			VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
			int i = 0;
			string query = "select * from UrunlerTablosu where productType = 1 and visibility= 1";
			DataTable table = database.veriCek(query);
			foreach (DataRow item in table.Rows)
			{
				Product book = addNewProductFromDatabase.CreateNewItem(item);
				BookControl cont = new BookControl((Book)book, mainform.shoppingCard);
				flytbBook.Controls.Add(cont);
				i++;
				if (i == 6)
				{
					break;
				}
			}
			pctrbxsitephoto.Image = new Bitmap("kitap" + (pictureindex % 3 + 1).ToString() + ".jpg");
			query = "select * from UrunlerTablosu where productType = 2 and visibility= 1";
			table = database.veriCek(query);
			i = 0;
			foreach (DataRow item in table.Rows)
			{
				Product music = addNewProductFromDatabase.CreateNewItem(item);
				MusicCdControl cont = new MusicCdControl((MusicCD)music, mainform.shoppingCard);
				flytbMusic.Controls.Add(cont);
				i++;
				if (i == 6)
				{
					break;
				}
			}
			query = "select * from UrunlerTablosu where productType = 3 and visibility= 1";
			table = database.veriCek(query);
			i = 0;
			foreach (DataRow item in table.Rows)
			{
				Product magazine = addNewProductFromDatabase.CreateNewItem(item);
				MagazineControl cont = new MagazineControl((Magazine)magazine, mainform.shoppingCard);
				flytbMagazine.Controls.Add(cont);
				i++;
				if (i == 6)
				{
					break;
				}
			}
		}


		private void MainFormPanelWithPicture_Load(object sender, EventArgs e)
		{

		}
		int pictureindex = 0;
		private void lbProducts_Click(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((Label)sender).Name);
			mainform.pnlShowClear(((Label)sender).Text);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			pctrbxsitephoto.Image = new Bitmap("kitap" + (pictureindex % 4 + 1).ToString() + ".jpg");
			pictureindex++;
		}
	}
}
