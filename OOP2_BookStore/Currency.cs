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
	/// it takes the currency rates on the internet given Base
	/// </summary>
	class Currency
	{
		/// <summary>
		/// the base of the currency
		/// </summary>
		public string Base;

		/// <summary>
		/// the rates of the currency
		/// </summary>
		public Dictionary<string, double> rates;

		/// <summary>
		/// it returns the currency at given 
		/// </summary>
		/// <param name="Base"></param>
		/// <returns></returns>
		public double getCurrency(string Base)
		{
			try
			{
				return rates[Base];
			}
			catch
			{
				return 0.0;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns> the base </returns>
		public string getBase()
		{
			return Base;
		}

		/// <summary>
		/// the constructor
		/// </summary>
		public Currency() { }
	}
}
