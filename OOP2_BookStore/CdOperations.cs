using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_BookStore
{
    class CdOperations
    {
        VeritabaniIslemleri dataBase = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
        /// <summary>
        /// yeni bir CD ekleyen metot
        /// </summary>
        /// <param name="cd"></param>
        /// <param name="maxId"></param>
        public void addNewCd(MusicCD cd,string maxId)
        {
            string cdValues = maxId + "," + Convert.ToInt32(cd.Mcdtype) + ",'" + cd.Singer + "'";
            dataBase.veriKaydet("productId,productType,productSinger", cdValues, "CdBilgileriTablosu");
        }
        /// <summary>
        /// cd güncelleyen metot
        /// </summary>
        /// <param name="cd"></param>
        /// <param name="maxId"></param>
        public void updateCd(MusicCD cd,string maxId)
        {
            string cdValues = cd.Id + "#" + Convert.ToInt16(cd.Mcdtype) + "#'" + cd.Singer + "'";
            dataBase.dataUpdate("productId,productType,productSinger", cdValues, "CdBilgileriTablosu", "productId=" + cd.Id);
        }
    }
}
