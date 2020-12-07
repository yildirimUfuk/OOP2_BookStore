using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP2_BookStore
{
	/// <summary>
	/// it stores the book product information
	/// </summary>
	public class Book : Product
	{
		private long isbn;
		private string author;
		private string publisher;
		private int page;
		/// <summary>
		/// the language of the book
		/// </summary>
		public Language l_anguage;
		/// <summary>
		/// the type of the book
		/// </summary>
		public BookType type;
		/// <summary>
		/// the ISBN number of the book
		/// </summary>
		public long Isbn { get => isbn; set => isbn = value; }
		/// <summary>
		/// the author of the book
		/// </summary>
		public string Author { get => author; set => author = value; }
		/// <summary>
		/// the publisher of the book
		/// </summary>
		public string Publisher { get => publisher; set => publisher = value; }
		/// <summary>
		/// the no of page of the book
		/// </summary>
		public int Page { get => page; set => page = value; }
		/// <summary>
		/// the size of cover page of the book
		/// </summary>
		public string size;
		/// <summary>
		/// book type 
		/// </summary>
		public enum BookType
		{
			ScienceFiction, satire, drama//, ActionandAdventure, Romance, mystery, horror, selfhelp, guide, travel, childrens, religious, science, history, math, anthologies, poetry, encyclopedia, dictionaries, comics, art, cookbooks, diaries, prayerbooks, series, trilogies, biographies, autobiographies, fantasy
		}

		/// <summary>
		/// language type
		/// </summary>
		public enum Language
		{
			Turkish, English
		}
		/// <summary>
		/// it lists the information of the book
		/// </summary>
		public override void printProperties()
		{
			try
			{
				BookForm form = new BookForm(this, Program.mainform.shoppingCard);
				form.ShowDialog();
			}
			catch { }
		}
	}
}