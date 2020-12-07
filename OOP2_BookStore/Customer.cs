using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_BookStore
{
	/// <summary>
	/// it is used to store customer datails and methods.
	/// </summary>
	class Customer : User
	{
		/// <summary>
		/// it prints the information of the user.
		/// </summary>
		public void printCustomerDetails()
		{
			Profile profile = new Profile(MainForm.user, 1);
			profile.Show();
		}
		/// <summary>
		/// it prints the previous purchases.
		/// </summary>
		public void printCustomerPurchases()
		{
			PurchasesForm form = new PurchasesForm();
			form.Text = "Previous Purchases";
			form.Show();
		}

		/// <summary>
		/// it updates the customer information.
		/// </summary>
		public void saveCustomer()
		{
			VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
			string query = "update MusteriBilgileriTablosu set customerName = '" + Name + "', customerSurname = '" + Surname + "', customerAdress='" + Adress + "', customerEmail='" + Email + "', userName = '" + Username + "', userPassword = '" + Password + "' where customerID=" + UserID;
			database.veriKaydet(query);
		}
	}
}
