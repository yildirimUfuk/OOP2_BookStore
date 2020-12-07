using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_BookStore
{
	public class Logger : Observer
	{
		/// <summary>
		/// it records the log info
		/// </summary>
		/// <param name="formname"> form name to record </param>
		/// <param name="bttnname"> button name to record </param>
		public override void record(string formname, string bttnname)
		{
			VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
			string query = "";
			if (MainForm.user != null)
			{
				query = "INSERT INTO logtablosu (formName,buttonName,UserID,Date) VALUES('" + formname + "','" + bttnname + "', " + MainForm.user.UserID + " ,'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
			}
			else
			{
				query = "INSERT INTO logtablosu (formName,buttonName,UserID,Date) VALUES('" + formname + "','" + bttnname + "', " + 0 + " ,'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
			}
			database.veriKaydet(query);
		}
	}
}
