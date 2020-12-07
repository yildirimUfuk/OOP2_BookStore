using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_BookStore
{
    class BookOperations
    {
        VeritabaniIslemleri dataBase = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
        /// <summary>
        ///  yeni bir kitap ekleyen metot
        /// </summary>
        /// <param name="book"></param>
        /// <param name="maxId"></param>
        public void addNewBook(Book book,string maxId)
        {
            string bookValues = maxId + ",'" + book.Author + "'," + book.Isbn + ",'" + book.Publisher + "'," + book.Page + ",'" + book.size + "'," + Convert.ToInt16(book.type) + "," + Convert.ToInt16(book.l_anguage);
            dataBase.veriKaydet("productId,productAuthor,isbn,publisher,page,size,type,language", bookValues, "kitapBilgileriTablosu");
        }
        /// <summary>
        /// kitap güncelleyen metot
        /// </summary>
        /// <param name="book"></param>
        /// <param name="maxId"></param>
        public void updateBook(Book book,string maxId)
        {
            string bookValues = book.Id + "#'" + book.Author + "'#" + book.Isbn + "#'" + book.Publisher + "'#" + book.Page + "#'" + book.size + "'#" + Convert.ToInt16(book.type) + "#" + Convert.ToInt16(book.l_anguage);
            dataBase.dataUpdate("productId,productAuthor,isbn,publisher,page,size,type,language", bookValues, "kitapBilgileriTablosu", "productId=" + book.Id);
        }
    }
}
