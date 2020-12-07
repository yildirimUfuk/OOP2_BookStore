using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_BookStore
{
    class MagazineOperations
    {
        VeritabaniIslemleri dataBase = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
        /// <summary>
        /// yeni bir dergi ekleyen metot
        /// </summary>
        /// <param name="magazine"></param>
        /// <param name="maxId"></param>
        public void addNewMagazine(Magazine magazine,string maxId)
        {
            string magazineValues = maxId + ",'" + magazine.Issue + "'," + Convert.ToInt16(magazine.Mtype);
            dataBase.veriKaydet("productId,productIssue,productType", magazineValues, "MagazineBilgileriTablosu");
        }
        /// <summary>
        /// dergi güncelleyen metot
        /// </summary>
        /// <param name="magazine"></param>
        /// <param name="maxId"></param>
        public void updateMagazine(Magazine magazine,string maxId)
        {
            string magazineValues = magazine.Id + "#'" + magazine.Issue + "'#" + Convert.ToInt16(magazine.Mtype);
            dataBase.dataUpdate("productId,productIssue,productType", magazineValues, "MagazineBilgileriTablosu", "ProductId=" + magazine.Id);
        }
    }
}
