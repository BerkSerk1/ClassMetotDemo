using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteriler musteriBilgi = new Musteriler();
            musteriBilgi.Ad = "Berk Güngör";
            musteriBilgi.TcNo = "15182437437";
            musteriBilgi.Yas = 20;
            musteriBilgi.Sehir = "Bursa";

            Musteriler musteriBilgi2 = new Musteriler();
            musteriBilgi2.Ad = "Yusuf Bilal";
            musteriBilgi2.TcNo = "11111111111";
            musteriBilgi2.Yas = 20;
            musteriBilgi2.Sehir = "Bursa";

            MusteriManager musteriIsleri = new MusteriManager();
            musteriIsleri.ekle(musteriBilgi);
            musteriIsleri.ekle(musteriBilgi2);

            musteriIsleri.liste(musteriBilgi);
            musteriIsleri.liste(musteriBilgi2);

            musteriIsleri.silme(musteriBilgi);
            musteriIsleri.silme(musteriBilgi2);
        }
    }
}
