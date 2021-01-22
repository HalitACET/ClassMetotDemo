using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();

            musteri1.MusteriAd_Soyad = "Ahmet AKKAYA";
            musteri1.TCNO = "12345678910";
            musteri1.TelNo = "05465326895";
            musteri1.Sehir = "Bursa";

            Musteri musteri2 = new Musteri();

            musteri2.MusteriAd_Soyad = "Ertan CEVHER";
            musteri2.TCNO = "98745632106";
            musteri2.TelNo = "05689632545";
            musteri2.Sehir = "İstanbul";

            Musteri musteri3 = new Musteri();

            musteri3.MusteriAd_Soyad = "Halit ACET";
            musteri3.TCNO="123659874560";
            musteri3.TelNo = "5486932145";
            musteri3.Sehir = "Yozgat";

            MusteriManager musterimanager = new MusteriManager();
            Console.WriteLine("-----MÜŞTERİ EKLEME METOTLARI-----");
            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);
            musterimanager.Ekle(musteri3);

            Console.WriteLine("");
            Console.WriteLine("-----MÜŞTERİ LİSTELEME METOTLARI-----");
            musterimanager.Listele(musteri1);
            musterimanager.Listele(musteri2);
            musterimanager.Listele(musteri3);

            Console.WriteLine("");
            Console.WriteLine("-----MÜŞTERİ SİLME METOTLARI-----");
            musterimanager.Sil(musteri1);
            musterimanager.Sil(musteri2);
            musterimanager.Sil(musteri3);

            Console.Read();
        }
    }
}
