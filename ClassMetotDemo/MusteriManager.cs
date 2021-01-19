using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void ekle(Musteriler musteriEk)
        {
            Console.WriteLine("Müşteriniz Sisteme eklenmiştir :"+musteriEk.Ad);
        }
        public void liste(Musteriler musteriLi)
        {
            Console.WriteLine("Müşterileriniz Listelenmiştir ->"+musteriLi.Ad+"-"+musteriLi.Sehir+"-"+musteriLi.Yas);
        }
        public void silme(Musteriler musteriSi)
        {
            Console.WriteLine("Müşteriniz Sistemden Silinmiştir! :"+musteriSi.TcNo+"-"+musteriSi.Ad);
        }
    }
}
