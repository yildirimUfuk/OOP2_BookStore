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
	public partial class PaymentDatailControl : UserControl
	{
		/// <summary>
		/// the constructor to create invoice from database
		/// </summary>
		/// <param name="dataTable"> products </param>
		/// <param name="dataRow"> shopingcard </param>
		public PaymentDatailControl(DataTable dataTable, DataRow dataRow)
		{
			InitializeComponent();
			lbDate.Text ="Date : "+ (dataRow[3]).ToString();
			lbInvoiceID.Text = "Invoice Id : " + dataRow[1].ToString();
			lbOrderName.Text = "To : " + MainForm.user.Name.ToString() + " " + MainForm.user.Surname;

			foreach (DataRow row in dataTable.Rows)
			{
				VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
				string query = "select * from UrunlerTablosu where productId = " + row[1];
				DataTable table = database.veriCek(query);
				ListViewItem lvi = new ListViewItem();
				string s = (table.Rows[0])[1].ToString();
				lvi.SubItems.Add(s);
				s = row[3].ToString();
				lvi.SubItems.Add(s);
				s = row[4].ToString();
				lvi.SubItems.Add(s);
				lwproductlist.Items.Add(lvi);
				lbShip.Text = "Shipment : " + (Convert.ToDouble(dataRow[5])).ToString("0.##");
				lbtotal.Text = "Total : " + (Convert.ToDouble(dataRow[2])).ToString("0.##");
			}
			txtbxAdress.Text = dataRow[6].ToString();
		}	
	}
}
