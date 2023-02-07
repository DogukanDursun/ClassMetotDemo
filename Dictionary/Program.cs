using System;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary< string> urunler = new MyDictionary<string>();
            urunler.Add("Masa");
            urunler.Add("Sandalye");
            urunler.Add("Kitap");
            urunler.Add("Bilgisayar");
            Console.WriteLine(urunler.Length);
            Console.ReadLine();

        }
    }
}
