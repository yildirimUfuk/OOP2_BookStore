using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace OOP2_BookStore
{
	public partial class MainForm : Form
	{
		/// <summary>
		/// shopping cart of main Form
		/// </summary>
		public ShoppingCard shoppingCard = new ShoppingCard();

		public AddNewProductFromDatabase addNewProductFromDatabase;

		public MainFormPanelWithPicture mainFormPanelWithPicture;
		/// <summary>
		/// the constructor of main form
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
			addNewProductFromDatabase = AddNewProductFromDatabase.CreateAddNewProductFromDatabase();
			bttnUserName.Text = "Sign In";
			pnlUserNameClicked.Visible = false;
			mainFormPanelWithPicture = new MainFormPanelWithPicture(this);
			pnlShow.Controls.Add(mainFormPanelWithPicture);
			tvFilter.Visible = false;

			CurrencyInfo currency = new CurrencyInfo("TRY");
			lbEUR.Text = "EUR : " + (1.0 / currency.getCurrency("EUR")).ToString("0.##") + "₺";
			lbUSD.Text = "USD : " + (1.0 / currency.getCurrency("USD")).ToString("0.##") + "₺";

			fillthethreeviever();
		}

		/// <summary>
		/// it fills the tvFilter component with text and pictures
		/// </summary>
		public void fillthethreeviever()
		{
			ImageList photoList = new ImageList();
			photoList.TransparentColor = Color.Blue;
			photoList.ColorDepth = ColorDepth.Depth32Bit;
			photoList.ImageSize = new Size(30, 30);

			photoList.Images.Add(Image.FromFile(@"PhotoTreeView\Book.png"));
			photoList.Images.Add(Image.FromFile(@"PhotoTreeView\Music.png"));
			photoList.Images.Add(Image.FromFile(@"PhotoTreeView\Magazine.png"));

			tvFilter.ImageList = photoList;

			tvFilter.Nodes.Add("book", "Book", 0);
			tvFilter.Nodes[0].SelectedImageIndex = 0;
			for (int i = 0; i < Convert.ToInt32(Enum.GetNames(typeof(Book.BookType)).Length); i++)
			{
				Book.BookType type = (Book.BookType)i;
				tvFilter.Nodes[0].Nodes.Add(type.ToString());
				tvFilter.Nodes[0].Nodes[i].SelectedImageIndex = 0;

			}
			tvFilter.Nodes.Add("music", "Music CD", 1);
			tvFilter.Nodes[1].SelectedImageIndex = 1;

			for (int i = 0; i < Convert.ToInt32(Enum.GetNames(typeof(MusicCD.MusicCDType)).Length); i++)
			{
				MusicCD.MusicCDType type = (MusicCD.MusicCDType)i;
				tvFilter.Nodes[1].Nodes.Add(type.ToString(), type.ToString(), 1);
				tvFilter.Nodes[1].Nodes[i].SelectedImageIndex = 1;

			}
			tvFilter.Nodes.Add("magazine", "Magazine", 2);
			tvFilter.Nodes[2].SelectedImageIndex = 2;

			for (int i = 0; i < Convert.ToInt32(Enum.GetNames(typeof(Magazine.MagazineType)).Length); i++)
			{
				Magazine.MagazineType type = (Magazine.MagazineType)i;
				tvFilter.Nodes[2].Nodes.Add(type.ToString(), type.ToString(), 2);
				tvFilter.Nodes[2].Nodes[i].SelectedImageIndex = 2;

			}
		}


		/// <summary>
		/// mainForm User
		/// </summary>
		public static User user = null;

		/// <summary>
		/// when this button clicked, 
		/// if user == null the login page appear
		/// else the pnlUserNameClicked appear or vice versa
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bttnUserName_Click(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((Button)sender).Name);
			if (user == null)
			{
				LoginForm login = new LoginForm();
				DialogResult result = login.ShowDialog();
				if (result == DialogResult.Yes)
				{
					bttnUserName.Text = user.Name;
					VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
					string query = "select * from SepetTablosu where customerId = " + user.UserID + " and siparisId = 'none'";
					DataTable table= database.veriCek(query);
					foreach (DataRow item in table.Rows)
					{
						query = "select * from UrunlerTablosu where productId = '" + item[1].ToString() + "'";
						DataTable tablee = database.veriCek(query);
						shoppingCard.addProduct(new ItemToPurchase(addNewProductFromDatabase.CreateNewItem(tablee.Rows[0]), Convert.ToInt32(item[3])));
					}
					query = "delete from SepetTablosu where customerId = " + user.UserID + " and siparisId = 'none'";
					database.veriKaydet(query);
					query = "delete from ShoppingCartTable where CustomerId = " + user.UserID + " and siparisId = 'none'";
					database.veriKaydet(query);
				}
			}
			else
			{
				if (pnlUserNameClicked.Visible == false)
				{
					pnlUserNameClicked.Visible = true;
				}
				else
				{
					pnlUserNameClicked.Visible = false;
				}
			}
			this.MainForm_Activated(this, new EventArgs());
		}
		//when user != null
		private void pctcrbxUserPhoto_Click(object sender, EventArgs e)
		{ 
			if (pnlUserNameClicked.Visible == false)
			{
				pnlUserNameClicked.Visible = true;
			}
			else
			{
				pnlUserNameClicked.Visible = false;
			}

		}

		/// <summary>
		/// when main form load 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_Load(object sender, EventArgs e)
		{
			//Point p = new Point();
			//p = panel1.Location;
			//p.Y += panel1.Height;
			//pnlSearch.Location = p;
			//p = bttnUserName.Location;
			//p.Y += bttnUserName.Height;
			//pnlUserNameClicked.Location = p;

			if (MainForm.user == null)
			{
				bttnUserName.Text = "Sign In";
			}

			//VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
			//DataTable table = database.veriCek("SELECT * FROM UrunlerTablosu");
			//List<Product> productList = new List<Product>();
			//Product product;
			//foreach (DataRow dataRow in table.Rows)
			//{
			//	AddNewProductFromDatabase databaseproduct = new AddNewProductFromDatabase();
			//	product = databaseproduct.CreateNewItem(dataRow);
			//	productList.Add(product);
			//}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void flytbProduxtList_Paint(object sender, PaintEventArgs e)
		{
			FlowLayoutPanel panel = (FlowLayoutPanel)sender;
		}

		/// <summary>
		/// when the user wants to log out 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bttnlogout_Click(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((Button)sender).Name);
			try
			{
				VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
				string query = "";
				for (int i = 0; i < shoppingCard.items.Count; i++)
				{
					query = "insert into SepetTablosu (customerId,urunId,siparisId,urunAdedi ) values(" + user.UserID + "," + shoppingCard.items.ElementAt(i).Value.product.Id + " ,'none' ," + shoppingCard.items.ElementAt(i).Value.quantity + " )";
					database.veriKaydet(query);
				}
			}
			catch
			{ }
			user = null;
			pnlUserNameClicked.Visible = false;
			bttnUserName.Text = "Sign In";
			shoppingCard.cancelOrder();
			btnAdminPaneli.Visible = false;
			this.MainForm_Activated(this, new EventArgs());
		}

		/// <summary>
		/// 
		/// </summary>
		string authorizationDegre;

		/// <summary>
		/// it refresh the main form after a form opened
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_Activated(object sender, EventArgs e)
		{
			if (user != null)
			{
				bttnUserName.Text = user.Name;
                VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
                DataTable authorizationTable = database.veriCek("SELECT userAuthorization FROM MusteriBilgileriTablosu WHERE customerID =" + user.UserID);
                authorizationDegre = authorizationTable.Rows[0][0].ToString();
            }
			this.updateShoppingCart();
            if (authorizationDegre=="1")
            {
                btnAdminPaneli.Visible = true;
            }
		}

		/// <summary>
		/// when filter is activated it works.
		/// </summary>
		/// <param name="type"> the product type </param>
		public void pnlShowClear(string type)
		{
			pnlShow.Controls.Clear();
			FlowLayoutPanel panel = new FlowLayoutPanel();
			//p.Controls.Add(panel);
			VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
			if (type == "Book")//it list the products which are books
			{
				string query = "select * from UrunlerTablosu where productType = 1 AND  visibility = 1 ";
				DataTable table = database.veriCek(query);
				foreach (DataRow item in table.Rows)
				{
					Product book = addNewProductFromDatabase.CreateNewItem(item);//factory pattern
					BookControl cont = new BookControl((Book)book, shoppingCard);
					pnlShow.Controls.Add(cont);

				}
			}
			else if (type == "Music")//it list the products which are music
			{
				string query = "select * from UrunlerTablosu where productType = 2 AND  visibility = 1 ";
				DataTable table = database.veriCek(query);
				foreach (DataRow item in table.Rows)
				{
					Product music = addNewProductFromDatabase.CreateNewItem(item);//factory pattern
					MusicCdControl cont = new MusicCdControl((MusicCD)music, shoppingCard);
					pnlShow.Controls.Add(cont);

				}
			}
			else if (type == "Magazine")//it list the products which are books
			{
				string query = "select * from UrunlerTablosu where productType = 3 AND  visibility = 1 ";
				DataTable table = database.veriCek(query);
				foreach (DataRow item in table.Rows)
				{
					Product magazine = addNewProductFromDatabase.CreateNewItem(item);//factory pattern
					MagazineControl cont = new MagazineControl((Magazine)magazine, shoppingCard);
					pnlShow.Controls.Add(cont);

				}
			}
		}

		/// <summary>
		/// when this label is clicked it shows the all products so it creates a object which type is MainFormPanelWithPicture
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lb_Click(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((Label)sender).Name);
			pnlShow.Controls.Clear();
			pnlShow.Controls.Add(new MainFormPanelWithPicture(this));

		}

		/// <summary>
		/// it shows the product in shopping Card (so it opens a new form)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bttnShopingCart_Click_1(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((Button)sender).Name);
			shoppingCard.shoppingCartform.Show();
		}

		/// <summary>
		/// when added new item to shoping Cart it updates the thxt of button of shoping card
		/// </summary>
		public void updateShoppingCart()
		{
			int countItemInCart = 0;
			for (int i = 0; i < shoppingCard.items.Count;i++)
			{
				countItemInCart += shoppingCard.items.ElementAt(i).Value.quantity;
			}
			bttnShopingCart.Text = "Shopping Cart (" + countItemInCart.ToString() + ")";
		}

		/// <summary>
		/// this event for filter panel
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tvFilter_AfterSelect(object sender, TreeViewEventArgs e)
		{
			Program.NotifyObserver(this.Name, ((TreeView)sender).Name);
			int index = e.Node.Index;
			int level = e.Node.Level;
			if (level == 0)
			{
				switch (index)
				{
					case 0:
						pnlShow.Controls.Clear();
						this.pnlShowClear("Book");
						break;
					case 1:
						pnlShow.Controls.Clear();
						this.pnlShowClear("Music");
						break;
					case 2:
						pnlShow.Controls.Clear();
						this.pnlShowClear("Magazine");
						break;
					default:
						break;
				}
			}
			if (level == 1)
			{
				int parentindex = e.Node.Parent.Index;
				VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
				string query;
				//DataTable dataTable = database.veriCek(query);

				switch (parentindex)
				{
					case 0:
						pnlShow.Controls.Clear();
						query = "select * from kitapBilgileriTablosu where type = " + index+ " and  visibility = 1";
						DataTable dataTable = database.veriCek(query);
						foreach (DataRow row in dataTable.Rows)
						{
							Product book = addNewProductFromDatabase.CreateNewItemfilter(row, 1);
							BookControl cont = new BookControl((Book)book,shoppingCard);
							pnlShow.Controls.Add(cont);
						}
						break;
					case 1:
						pnlShow.Controls.Clear();
						query = "select * from CdBilgileriTablosu where productType = " + index+ " and  visibility = 1";
						DataTable dataTabl = database.veriCek(query);
						foreach (DataRow row in dataTabl.Rows)
						{
							Product book = addNewProductFromDatabase.CreateNewItemfilter(row, 2);
							MusicCdControl cont = new MusicCdControl((MusicCD)book,shoppingCard);
							pnlShow.Controls.Add(cont);
						}
						break;
					case 2:
						pnlShow.Controls.Clear();
						query = "select * from MagazineBilgileriTablosu where productType = " + index+ " and  visibility = 1";
						DataTable dataTabe = database.veriCek(query);
						foreach (DataRow row in dataTabe.Rows)
						{
							Product book = addNewProductFromDatabase.CreateNewItemfilter(row, 3);
							MagazineControl cont = new MagazineControl((Magazine)book,shoppingCard);
							pnlShow.Controls.Add(cont);
						}
						break;
					default:
						break;
				}
			}
		}

		/// <summary>
		///  it shows a panel to filter product
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pctrbxMenu_Click(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((PictureBox)sender).Name);
			if (tvFilter.Visible == false)
			{
				tvFilter.Visible = true;
			}
			else
			{
				tvFilter.Visible = false;
			}
		}

		/// <summary>
		/// it show the details of user in another form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bttnProfile_Click(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((Button)sender).Name);
			if (true)
			{
				((Customer)user).printCustomerDetails();
			}
		}

		/// <summary>
		/// it shows the previous purchases' details
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bttnPuch_Click(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((Button)sender).Name);
			((Customer)user).printCustomerPurchases();
		}

		/// <summary>
		/// it works when form closing. 
		/// if user != null it records the items in the shoping card in database
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			//try
			//{
			//	VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
			//	for (int i = 0; i <= shoppingCard.items.Count; i++)
			//	{
			//		string query = "insert into ShoppingCartTable (CustomerId,siparisId) values(" + user.UserID + ",'none')";
			//		database.veriKaydet(query);
			//		query = "insert into SepetTablosu (customerId,urunId,siparisId,urunAdedi ) values(" + user.UserID + "," + shoppingCard.items.ElementAt(i).Value.product.Id + " ,'none' ," + shoppingCard.items.ElementAt(i).Value.quantity + " )";
			//		database.veriKaydet(query);

			//	}
			//}
			//catch
			//{

			//}
			Program.NotifyObserver(this.Name, "formclosing");
			try
			{
				VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
				string query = "";
				for (int i = 0; i < shoppingCard.items.Count; i++)
				{
					query = "insert into SepetTablosu (customerId,urunId,siparisId,urunAdedi ) values(" + user.UserID + "," + shoppingCard.items.ElementAt(i).Value.product.Id + " ,'none' ," + shoppingCard.items.ElementAt(i).Value.quantity + " )";
					database.veriKaydet(query);
				}
			}
			catch
			{ }
			user = null;
			pnlUserNameClicked.Visible = false;
			bttnUserName.Text = "Sign In";
			shoppingCard.cancelOrder();
			btnAdminPaneli.Visible = false;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void BtnAdminPaneli_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
            admin.ShowDialog();
        }

        private void TbAra_Click(object sender, EventArgs e)
        {
            tbAra.Text = " ";
        }

        private void TbAra_TextChanged(object sender, EventArgs e)
        {
            pnlSearch.Controls.Clear();
            DataTable dt = new DataTable();
            pnlSearch.Visible = true;
            string aranan = tbAra.Text;
            VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
            dt = database.veriCek("SELECT * FROM UrunlerTablosu WHERE productName LIKE '%" + tbAra.Text + "%' AND visibility = 1");
            Point p = new Point();
            p.Y = 0;
            p.X = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LinkLabel lbl = new LinkLabel();
				lbl.Text = dt.Rows[i]["productName"].ToString();// + " " + dt.Rows[i]["productPrice"].ToString() + " " + dt.Rows[i]["productSale"].ToString();
                lbl.Location = p;
                p.Y += lbl.Height;
                pnlSearch.Controls.Add(lbl);
				lbl.Name = dt.Rows[i][0].ToString();
                lbl.AutoSize = true;
                lbl.Visible = true;
                lbl.Click += new System.EventHandler(this.LinkLabel_Click);
            }
        }

		private void LinkLabel_Click(object sender, EventArgs e)
		{
			LinkLabel lLbl = ((LinkLabel)sender);
			VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
			DataTable table = database.veriCek("select * from UrunlerTablosu WHERE productId = " + lLbl.Name);
			try
			{
				Product product = addNewProductFromDatabase.CreateNewItem(table.Rows[0]);
				product.printProperties();
			}
			catch { }

		}
		private void MainForm_Click(object sender, EventArgs e)
		{
			pnlSearch.Visible = false;
		}

		private void pnlSearch_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}