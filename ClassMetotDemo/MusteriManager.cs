using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Adı Soyadı: "+musteri.MusteriAd_Soyad);
            Console.WriteLine("TCNO'su: "+musteri.TCNO);
            Console.WriteLine("TelNO'su: "+musteri.TelNo);
            Console.WriteLine("Yaşadığı Şehir: "+musteri.Sehir);
            Console.WriteLine("*******************************");
        }
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd_Soyad+" Ekleme İşleminiz Yapılmıştır...");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd_Soyad+" Silme İşleminiz Tamamlanmıştır...");
        }

    }
}
