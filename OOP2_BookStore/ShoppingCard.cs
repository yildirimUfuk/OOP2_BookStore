using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Data;

namespace OOP2_BookStore
{
	public class ShoppingCard
	{
		private SendEmail mailsender;
		private long customerID;
		private double paymentAmount;
		private PaymnetTYPE paymentType;
		/// <summary>
		/// shipment price
		/// </summary>
		public int shipment = 0;
		/// <summary>
		/// it stores the items in list and product id's as pair
		/// </summary>
		public Dictionary<long, ItemToPurchase> items = new Dictionary<long, ItemToPurchase>();
		/// <summary>
		/// listed components
		/// </summary>
		public List<ShoppingCartControlc> shoppingCartControlcs = new List<ShoppingCartControlc>();
		/// <summary>
		/// it uses to list shopping card details
		/// </summary>
		public ShoppingCartForm shoppingCartform;
		/// <summary>
		/// customer's ID 
		/// </summary>
		public long CustomerID { get => customerID; set => customerID = value; }
		/// <summary>
		/// total price
		/// </summary>
		public double PaymentAmount { get => paymentAmount; set => paymentAmount = value; }
		/// <summary>
		/// payment type
		/// </summary>
		public PaymnetTYPE PaymentType { get => paymentType; set => paymentType = value; }
		/// <summary>
		/// constructor
		/// </summary>
		public ShoppingCard()
		{
			shoppingCartform = new ShoppingCartForm(this);
		}
		/// <summary>
		/// paynemt type
		/// </summary>
		public enum PaymnetTYPE
		{
			cash, Creditcard
		};
		/// <summary>
		/// it shows the shoping cart details
		/// </summary>
		public void printProducts()
		{
			shoppingCartform.Show();
		}
		/// <summary>
		/// add new item inproduct list
		/// </summary>
		/// <param name="item"> product to be added</param>
		public void addProduct(ItemToPurchase item)
		{
			try
			{
				items[item.product.Id].quantity += item.quantity;
			}
			catch
			{
				items.Add(item.product.Id, item);
				shoppingCartControlcs.Add(new ShoppingCartControlc(item.product, this));
			}
		}

		/// <summary>
		/// delete the item from product list
		/// </summary>
		/// <param name="item"> product to be deleted</param>
		public void removeProduct(ItemToPurchase item)
		{
			items.Remove(item.product.Id);
		}

		/// <summary>
		/// it writes order information on database and clears the shoping card
		/// </summary>
		/// <param name="address"></param>
		public void placeOrder(string address)
		{
			///writing on database
			string invoiceID = MainForm.user.UserID.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();

			sendInvoidcebyEmail(invoiceID);

			VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
			database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
			int shiping = 0;
			if (this.paymentAmount < 50)
			{
				this.paymentAmount += 5;
				shiping = 5;
			}
			string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			int i = (int)paymentType;
			string payment = this.PaymentAmount.ToString();
			payment = payment.Replace(',', '.');
			string query = "insert into ShoppingCartTable(CustomerId,siparisId,paymentType,shipingPrice,totalPrice,dateOfPurchase,Address) values(" + MainForm.user.UserID + ",'" + invoiceID + "','" + (int)paymentType + "'," + shiping + "," + payment + ", '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,'" + address + "')";
			database.veriKaydet(query);
			for (int j = 0; j < items.Count; j++)
			{
				double currentprice = (100 - items.ElementAt(j).Value.product.Sale) * items.ElementAt(j).Value.product.Price / 100;
				string str = currentprice.ToString();
				str = str.Replace(',', '.');
				query = "insert into SepetTablosu(customerId,urunId,siparisId,urunAdedi,adetFiyati) values(" + MainForm.user.UserID + "," + items.ElementAt(j).Value.product.Id + ", '" + invoiceID + "' , " + items.ElementAt(j).Value.quantity + "," + str + ")";
				database.veriKaydet(query);
			}

			///end of writing
			shoppingCartControlcs.Clear();
			items.Clear();
			shoppingCartform.Hide();
			PurchasesForm form = new PurchasesForm(invoiceID);
			form.Text = "Purchases Details";
			form.ShowDialog();

			paymentAmount = 0;
		}

		/// <summary>
		/// it deletes all products in shopping card
		/// </summary>
		public void cancelOrder()
		{
			shoppingCartControlcs.Clear();
			items.Clear();
			paymentAmount = 0;
		}

		/// <summary>
		/// it sends email to user
		/// </summary>
		public void sendInvoidcebyEmail(string invoiceID)
		{
			int shipment=0;
			if(paymentAmount<50)
			{
				shipment = 5;
			}
			String mailtext = "<br>Spariş Numarası : " + invoiceID + "<br>" + "<br>Tutar : " + PaymentAmount.ToString() + "₺<br>Kargo ücreti = " + shipment.ToString() + "₺<br>";

			foreach (ItemToPurchase item in items.Values)
			{
				mailtext += item.product.Name + "&emsp;&emsp;&emsp;" + item.quantity + "&emsp;&emsp;&emsp;" + item.quantity * item.product.Price * (100 - item.product.Sale) / 100 + "₺<br>";
			}

			VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
			DataTable mailAdresi = database.veriCek("SELECT customerEmail FROM MusteriBilgileriTablosu WHERE customerID=" + MainForm.user.UserID);
			string eMail = mailAdresi.Rows[0][0].ToString();

			mailsender = SendEmail.CreateSendEmail();
			mailsender.sendmail(eMail, "fatura", mailtext);
        }
	}
}
