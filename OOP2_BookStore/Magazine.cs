using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_BookStore
{
	/// <summary>
	/// it stores the magazine product information
	/// </summary>
	public class Magazine : Product
	{
		/// <summary>
		/// magazine types
		/// </summary>
		public enum MagazineType
		{
			Actual, News, Sport, Computer, Technology
		};
		private string issue;
		private MagazineType mtype;
		/// <summary>
		/// issue of magazine
		/// </summary>
		public string Issue { get => issue; set => issue = value; }
		/// <summary>
		/// magazine type
		/// </summary>
		public MagazineType Mtype { get => mtype; set => mtype = value; }
		/// <summary>
		/// it lists the information of the magazine
		/// </summary>
		public override void printProperties()
		{
			MagazineForm form = new MagazineForm(this, Program.mainform.shoppingCard);
			form.ShowDialog();
		}
	}
}
