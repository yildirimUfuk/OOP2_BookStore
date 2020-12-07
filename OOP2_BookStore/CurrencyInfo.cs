using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
namespace OOP2_BookStore
{
	/// <summary>
	/// it gets the currency on the internet
	/// </summary>
	class CurrencyInfo
	{
		/// <summary>
		/// the setting of currency stores here.
		/// </summary>
		private Currency currency = new Currency();
		/// <summary>
		/// it takes a paramater to take currency rates at given base.
		/// </summary>
		/// <param name="Base">currency base</param>
		public CurrencyInfo(string Base)
		{
			string url = "https://api.exchangeratesapi.io/latest?base=" + Base;
			string json = new WebClient().DownloadString(url);
			currency = JsonConvert.DeserializeObject<Currency>(json);
		}
		/// <summary>
		/// it gets the currency rate accordig to currency.base  
		/// </summary>
		/// <param name="Base"> the currency base </param>
		/// <returns> base </returns>
		public double getCurrency(string Base)
		{
			return currency.getCurrency(Base);
		}
		/// <summary>
		/// it return the base of the currency class
		/// </summary>
		/// <returns></returns>
		public string getBase()
		{
			return currency.getBase();
		}
	}
}
