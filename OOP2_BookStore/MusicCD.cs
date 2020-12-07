using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_BookStore
{
	/// <summary>
	/// it stores the MusicCD product information
	/// </summary>
	public class MusicCD : Product
	{
		private string singer;
		private MusicCDType mcdtype;

		/// <summary>
		/// Singer of MusicCD
		/// </summary>
		public string Singer { get => singer; set => singer = value; }

		/// <summary>
		/// MusicCD type
		/// </summary>
		public MusicCDType Mcdtype { get => mcdtype; set => mcdtype = value; }

		/// <summary>
		/// it lists the information of the MusicCD
		/// </summary>
		public override void printProperties()
		{
			MusicCdForm form = new MusicCdForm(this, Program.mainform.shoppingCard);
			form.ShowDialog();
		}

		/// <summary>
		/// musicCd types
		/// </summary>
		public enum MusicCDType
		{
			Romans, HardRock, Country//.....
		};
	}
}
