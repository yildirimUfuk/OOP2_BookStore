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
	/// it is using to list details of purchases
	/// </summary>
	public partial class PurchasesForm : Form
	{
		/// <summary>
		/// it lists previous purchases
		/// </summary>
		public PurchasesForm()
		{
			InitializeComponent();
			VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
			string query = "select * from ShoppingCartTable where CustomerId = " + MainForm.user.UserID.ToString();
			DataTable table = database.veriCek(query);
			foreach (DataRow row in table.Rows)
			{
				if (row[1].ToString() != "none")
				{
					query = "select * from SepetTablosu where siparisId = '" + row[1] + "'";
					DataTable tabledetails = database.veriCek(query);
					PaymentDatailControl control = new PaymentDatailControl(tabledetails, row);
					flpdetails.Controls.Add(control);
				}
			}
		}
		/// <summary>
		/// it shows the details of the given id
		/// </summary>
		/// <param name="PruchaseID"> to find purchase from database </param>
		public PurchasesForm(string PruchaseID)
		{
			InitializeComponent();
			VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
			string query = "select * from ShoppingCartTable where siparisId = '" + PruchaseID + "'";
			DataTable table = database.veriCek(query);
			DataRow row = table.Rows[0];
			query = "select * from SepetTablosu where siparisId = '" + row[1] + "'";
			DataTable tabledetails = database.veriCek(query);
			PaymentDatailControl control = new PaymentDatailControl(tabledetails, row);
			flpdetails.Controls.Add(control);
		}

		private void PurchasesForm_Load(object sender, EventArgs e)
		{

		}
	}
}
