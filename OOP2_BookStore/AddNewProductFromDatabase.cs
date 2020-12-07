using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Drawing;

namespace OOP2_BookStore
{
	public class AddNewProductFromDatabase
	{
		static AddNewProductFromDatabase addNewProductFromDatabase;

		/// <summary>
		/// constructor
		/// </summary>
		private AddNewProductFromDatabase ()
		{

		}

		/// <summary>
		/// creates new item if addNewProductFromDatabase == null else returns addNewProductFromDatabase
		/// </summary>
		/// <returns>addNewProductFromDatabase</returns>
		public static AddNewProductFromDatabase CreateAddNewProductFromDatabase()
		{
			if(addNewProductFromDatabase==null)
			{
				addNewProductFromDatabase = new AddNewProductFromDatabase();
			}
			return addNewProductFromDatabase;
		}

		/// <summary>
		/// it create a product from database
		/// </summary>
		/// <param name="dataRow">the row from urunlertablosu </param>
		/// <returns>product</returns>
		public Product CreateNewItem(DataRow dataRow)
        {
            try
            {
                VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
                Product product=new Book();
                if (Convert.ToInt32(dataRow[6]) == 1)
                {
                    product = new Book();
                    DataTable BookTable = database.veriCek("SELECT * FROM kitapBilgileriTablosu WHERE productId = " + dataRow[0] + " and " + " visibility = 1 ");
                    DataRow BookTableRow = BookTable.Rows[0];
                    //product is filled with database
                    product.Id = Convert.ToInt32(dataRow[0]);
                    product.Name = dataRow[1].ToString();
                    product.Price = Convert.ToInt32(dataRow[2]);
                    product.Photo1 = new Bitmap(dataRow[3].ToString());
                    product.Description = dataRow[4].ToString();
                    product.Sale = Convert.ToInt32(dataRow[5]);
                    ((Book)product).Author = BookTableRow[1].ToString();
                    ((Book)product).Isbn = Convert.ToInt64(BookTableRow[2]);
                    ((Book)product).Publisher = BookTableRow[3].ToString();
                    ((Book)product).Page = Convert.ToInt32(BookTableRow[4]);
                    ((Book)product).size = BookTableRow[5].ToString();
                    ((Book)product).type = (Book.BookType)BookTableRow[6];
                    ((Book)product).l_anguage = (Book.Language)BookTableRow[7];
                    return product;
                }
                else if (Convert.ToInt32(dataRow[6]) == 2)
                {
                    product = new MusicCD();
                    DataTable MusicTable = database.veriCek("SELECT * FROM CdBilgileriTablosu WHERE productId = " + dataRow[0] + " and " + " visibility = 1" );
                    DataRow MusicTableRow = MusicTable.Rows[0];
                    //product is filled with database
                    product.Id = Convert.ToInt32(dataRow[0]);
                    product.Name = dataRow[1].ToString();
                    product.Price = Convert.ToInt32(dataRow[2]);
                    product.Photo1 = new Bitmap(dataRow[3].ToString());
                    product.Description = dataRow[4].ToString();
                    product.Sale = Convert.ToInt32(dataRow[5]);
                    ((MusicCD)product).Mcdtype = (MusicCD.MusicCDType)MusicTableRow[1];
                    ((MusicCD)product).Singer = MusicTableRow[2].ToString();
                    return product;
                }
                else//(Convert.ToInt32(dataRow[6]) == 3)
                {
                    product = new Magazine();
					DataTable magazineTable = database.veriCek("SELECT * FROM MagazineBilgileriTablosu WHERE productId = " + dataRow[0] + " and " + " visibility = 1 ");

					DataRow magazineTableRow = magazineTable.Rows[0];
                    //product is filled with database
                    product.Id = Convert.ToInt32(dataRow[0]);
                    product.Name = dataRow[1].ToString();
                    product.Price = Convert.ToInt32(dataRow[2]);
                    product.Photo1 = new Bitmap(dataRow[3].ToString());
                    product.Description = dataRow[4].ToString();
                    product.Sale = Convert.ToInt32(dataRow[5]);
                    product.Name = dataRow[1].ToString();
                    ((Magazine)product).Issue = magazineTableRow[1].ToString();
                    ((Magazine)product).Mtype = (Magazine.MagazineType)magazineTableRow[2];
                    return product;
                }
            }
            catch (Exception)
            {
				return null;
            }
        }

		/// <summary>
		/// it create specific product from database
		/// </summary>
		/// <param name="datatableRow">the row from urunlertablosu</param>
		/// <param name="productType">product type</param>
		/// <returns>product</returns>
		public Product CreateNewItemfilter(DataRow datatableRow, int productType)//it thakes the rows of product table 
		{
			try
			{
				VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
				Product product;
				if (productType == 1)
				{
					product = new Book();
					DataTable ProductTable = database.veriCek("SELECT * FROM UrunlerTablosu WHERE productId = " + datatableRow[0] + " and visibility = 1");
					DataRow producttablrow = ProductTable.Rows[0];
					//product is filled with database
					product.Id = Convert.ToInt32(producttablrow[0]);
					product.Name = producttablrow[1].ToString();
					product.Price = Convert.ToInt32(producttablrow[2]);
					product.Photo1 = new Bitmap(producttablrow[3].ToString());
					product.Description = producttablrow[4].ToString();
					product.Sale = Convert.ToInt32(producttablrow[5]);
					((Book)product).Author = datatableRow[1].ToString();
					((Book)product).Isbn = Convert.ToInt64(datatableRow[2]);
					((Book)product).Publisher = datatableRow[3].ToString();
					((Book)product).Page = Convert.ToInt32(datatableRow[4]);
					((Book)product).size = datatableRow[5].ToString();
					((Book)product).type = (Book.BookType)datatableRow[6];
					((Book)product).l_anguage = (Book.Language)datatableRow[7];
					return product;
				}
				else if (productType == 2)
				{
					product = new MusicCD();
					DataTable MusicTable = database.veriCek("SELECT * FROM UrunlerTablosu WHERE productId = " + datatableRow[0] + " and visibility = 1");
					DataRow producttablrow = MusicTable.Rows[0];
					//product is filled with database
					product.Id = Convert.ToInt32(producttablrow[0]);
					product.Name = producttablrow[1].ToString();
					product.Price = Convert.ToInt32(producttablrow[2]);
					product.Photo1 = new Bitmap(producttablrow[3].ToString());
					product.Description = producttablrow[4].ToString();
					product.Sale = Convert.ToInt32(producttablrow[5]);
					((MusicCD)product).Mcdtype = (MusicCD.MusicCDType)datatableRow[1];
					((MusicCD)product).Singer = datatableRow[2].ToString();
					return product;
				}
				else//(Convert.ToInt32(dataRow[6]) == 3)
				{
					product = new Magazine();
					DataTable magazineTable = database.veriCek("SELECT * FROM UrunlerTablosu WHERE productId = " + datatableRow[0] + " and visibility = 1");
					DataRow producttablrow = magazineTable.Rows[0];
					//product is filled with database
					product.Id = Convert.ToInt32(producttablrow[0]);
					product.Name = producttablrow[1].ToString();
					product.Price = Convert.ToInt32(producttablrow[2]);
					product.Photo1 = new Bitmap(producttablrow[3].ToString());
					product.Description = producttablrow[4].ToString();
					product.Sale = Convert.ToInt32(producttablrow[5]);
					//product.Name = producttablrow[1].ToString();
					((Magazine)product).Issue = datatableRow[1].ToString();
					((Magazine)product).Mtype = (Magazine.MagazineType)datatableRow[2];
					return product;
				}
			}
			catch
			{
				return null;
			}
		}
	}
}