using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_BookStore
{
	class Admin : User
	{
        private static Admin admin=null;
        VeritabaniIslemleri dataBase = VeritabaniIslemleri.bagOlustur("SatisVeritabani");


        string maxId;


        private Admin()
        { }

        /// <summary>
        /// singleton patern için daha önce oluşturulan admin nesnesi var ise var olanı yok ise yeni admin nesnesini döndüren metot
        /// </summary>
        /// <returns></returns>
        public static Admin createAdmin()
        {
            if (admin==null)
            {
                admin = new Admin();
            }
            
            return admin;
        }
        /// <summary>
        /// ürün ID lerini verebilmek için benzersiz Id tanımlamasında kullanılacak veri tabanındaki en büyük ID yi bulan metot
        /// </summary>
        private void getMaxId()
        {
            try
            {
                DataTable maxIdtTable = dataBase.veriCek("SELECT Max(productId) FROM UrunlerTablosu");
                maxId = (Convert.ToInt32(maxIdtTable.Rows[0][0]) + 1).ToString();
            }
            catch (Exception)
            {
                if (maxId==null)
                {
                    maxId = 1.ToString();
                }
                //throw;
            }
        }
        /// <summary>
        /// yeni eleman ekleyen metot. Factory patern kullanarak eleman türüne göre ekleme yapıyor
        /// </summary>
        /// <param name="product"></param>
        /// <param name="path"></param>
        public void addNewItem(Product product,string path)
        {
            Type sendedObject = product.GetType();
            getMaxId();
			string productValues = maxId + ",'" + product.Name.Replace("'"," ") + "'," + product.Price.ToString().Replace(',', '.') + ",'" + path + "','" + (product.Description.Replace('\'', ' ')) + "'," + product.Sale + ",";
            if (sendedObject.Name == "Book")
            {
                dataBase.veriKaydet("productId,productName,productPrice,productImage,productDescription,productSale,productType", productValues+"1", "UrunlerTablosu");
                AddNewBook((Book)product);
            }
            else if (sendedObject.Name == "MusicCD")
            {
                dataBase.veriKaydet("productId,productName,productPrice,productImage,productDescription,productSale,productType", productValues + "2", "UrunlerTablosu");
                AddNewMusicCD((MusicCD)product);
            }
            else if (sendedObject.Name == "Magazine")
            {
                dataBase.veriKaydet("productId,productName,productPrice,productImage,productDescription,productSale,productType", productValues + "3", "UrunlerTablosu");
                AddNewMagazine((Magazine)product);
            }
            else
                System.Windows.Forms.MessageBox.Show("INVALID PRODUCT");
        }
        /// <summary>
        /// yeni bir kitap ekleyen metot
        /// </summary>
        /// <param name="book"></param>
        private void AddNewBook(Book book)
		{
            string bookValues = maxId + ",'" + book.Author + "'," + book.Isbn+ ",'" + book.Publisher+ "'," + book.Page+ ",'" + book.size+ "'," + Convert.ToInt16(book.type) + "," + Convert.ToInt16(book.l_anguage);
            dataBase.veriKaydet("productId,productAuthor,isbn,publisher,page,size,type,language", bookValues, "kitapBilgileriTablosu");
        }
        /// <summary>
        /// yeni bir dergi ekleyen metot
        /// </summary>
        /// <param name="magazine"></param>
		private void AddNewMagazine(Magazine magazine)
		{
            string magazineValues = maxId + ",'" + magazine.Issue + "'," + Convert.ToInt16(magazine.Mtype);
            dataBase.veriKaydet("productId,productIssue,productType", magazineValues, "MagazineBilgileriTablosu");
        }
        /// <summary>
        /// yeni bir CD ekleyen metot
        /// </summary>
        /// <param name="cd"></param>
		private void AddNewMusicCD(MusicCD cd)
		{
            string cdValues = maxId + "," + Convert.ToInt32(cd.Mcdtype) + ",'" + cd.Singer+ "'";
            dataBase.veriKaydet("productId,productType,productSinger", cdValues, "CdBilgileriTablosu");
        }
        /// <summary>
        /// elemanları güncellemeye yarayan metot Factory patern kullanıldı
        /// </summary>
        /// <param name="product"></param>
        /// <param name="path"></param>
        public void updateItem(Product product,string path)
        {
            Type sendedObjectType = product.GetType();

            string productValues = product.Id+"#'" + product.Name.Replace("'"," ") + "'#" + product.Price.ToString().Replace(',', '.') + "#'" + path + "'#'" + (product.Description.Replace('\'',' ')) + "'#" + product.Sale+"#";

            if (sendedObjectType.Name=="Book")
            {
                dataBase.dataUpdate("productId,productName,productPrice,productImage,productDescription,productSale,productType", productValues+"1", "UrunlerTablosu", "productId=" + product.Id);
                //burada kaldık.
                updateBook((Book)product);
            }
            else if (sendedObjectType.Name=="MusicCD")
            {
                dataBase.dataUpdate("productId,productName,productPrice,productImage,productDescription,productSale,productType", productValues+"2", "UrunlerTablosu", "productId=" + product.Id);
                updateCd((MusicCD)product);
            }
            else if (sendedObjectType.Name=="Magazine")
            {
                dataBase.dataUpdate("productId,productName,productPrice,productImage,productDescription,productSale,productType", productValues+"3", "UrunlerTablosu", "ProductId=" + product.Id);
                updateMagazine((Magazine)product);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("INVALID TYPE");
            }
        }
        /// <summary>
        /// kitap güncelleyen metot
        /// </summary>
        /// <param name="book"></param>
        private void updateBook(Book book)
        {
        //  string bookValues = book.Id+",'" + book.Author + "'," + book.Isbn + ",'" + book.Publisher + "'," + book.Page + ",'" + book.size + "'," + Convert.ToInt16(book.type) + "," + Convert.ToInt16(book.l_anguage);
            string bookValues = book.Id + "#'" + book.Author + "'#" + book.Isbn + "#'" + book.Publisher + "'#" + book.Page + "#'" + book.size + "'#" + Convert.ToInt16(book.type) + "#" + Convert.ToInt16(book.l_anguage);
            dataBase.dataUpdate("productId,productAuthor,isbn,publisher,page,size,type,language", bookValues, "kitapBilgileriTablosu", "productId=" + book.Id);
        }
        /// <summary>
        /// cd güncelleyen metot
        /// </summary>
        /// <param name="cd"></param>
        private void updateCd(MusicCD cd)
        {
            string cdValues =  cd.Id+"#"+Convert.ToInt16(cd.Mcdtype) + "#'" + cd.Singer + "'";
            dataBase.dataUpdate("productId,productType,productSinger", cdValues, "CdBilgileriTablosu", "productId=" + cd.Id);
        }
        /// <summary>
        /// dergi güncelleyen metot
        /// </summary>
        /// <param name="magazine"></param>
        private void updateMagazine(Magazine magazine)
        {
            string magazineValues = magazine.Id+ "#'" + magazine.Issue + "'#" + Convert.ToInt16(magazine.Mtype);
            dataBase.dataUpdate("productId,productIssue,productType", magazineValues, "MagazineBilgileriTablosu", "ProductId=" + magazine.Id);
        }
        public DataTable deleteData(string productType, string productId)
        {
            VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
            if (productType == "1")
                database.deleteData("productId=" + productId, "kitapBilgileriTablosu");
            else if (productType == "2")
                database.deleteData("productId=" + productId, "CdBilgileriTablosu");
            else if (productType == "3")
                database.deleteData("productId=" + productId, "MagazineBilgileriTablosu");
            else
                System.Windows.Forms.MessageBox.Show("invalid product type");
            database.deleteData("productId=" + productId, "UrunlerTablosu");
            return (database.veriCek("SELECT * FROM UrunlerTablosu"));
        }
    }
}
