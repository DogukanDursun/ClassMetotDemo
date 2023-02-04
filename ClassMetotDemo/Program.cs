using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Doğukan ";
            musteri1.Soyadi = "Dursun";
            musteri1.DogumYeri = "Ankara";
            musteri1.TcNo = 11111111111;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "İsmail ";
            musteri2.Soyadi = "Yıldırım";
            musteri2.DogumYeri = "Ankara";
            musteri2.TcNo = 11111111122;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.TcNo);
                Console.WriteLine(musteri.DogumYeri);
                Console.WriteLine("----------------");

            }
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            Console.ReadLine();
        }

    }
}
