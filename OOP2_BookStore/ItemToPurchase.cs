using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_BookStore
{
	/// <summary>
	/// it is added to shopping card to store item information
	/// </summary>
	public class ItemToPurchase
	{
		/// <summary>
		/// stored item
		/// </summary>
		public Product product;
		/// <summary>
		/// the quantity of the item
		/// </summary>
		public int quantity;
		/// <summary>
		/// the contructor 
		/// </summary>
		/// <param name="product"></param>
		/// <param name="quantity"></param>
		public ItemToPurchase(Product product, int quantity)
		{
			this.product = product;
			this.quantity = quantity;
		}
	}
}