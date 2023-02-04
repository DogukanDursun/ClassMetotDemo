using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Sayın " + musteri.Adi + " " + musteri.Soyadi + " Aramıza Hoşgeldiniz");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.TcNo + " Kimlik Numaralı Müşteri Sistemden Çıkarıldı");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + musteri.DogumYeri + musteri.TcNo);
        }
    }
}
