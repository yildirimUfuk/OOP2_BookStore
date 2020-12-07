using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP2_BookStore
{
	/// <summary>
	/// it stores the products' info
	/// </summary>
	public abstract class Product
	{
		private int id;
		private string name;
		private double price;
		private Image Photo;
		private string description;
		private int sale;
		/// <summary>
		/// products ID
		/// </summary>
		public int Id { get => id; set => id = value; }
		/// <summary>
		/// the name of product
		/// </summary>
		public string Name { get => name; set => name = value; }
		/// <summary>
		/// the price of product
		/// </summary>
		public double Price { get => price; set => price = value; }
		/// <summary>
		/// phoro of product
		/// </summary>
		public Image Photo1 { get => Photo; set => Photo = value; }
		/// <summary>
		/// description of product
		/// </summary>
		public string Description { get => description; set => description = value; }
		/// <summary>
		/// the sale rate of product
		/// </summary>
		public int Sale { get => sale; set => sale = value; }
		/// <summary>
		/// it shows the product detail in another form
		/// </summary>
		public abstract void printProperties();
	}
}
