using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesne_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kitap kitapNesnesi= new Kitap("Sefiller", "Deneme Yazar");
            //Roman romanNesnesi= new Roman("Roman Ad","Yazar Adı","Romanın Türü");
            //CocukKitabi cocukKitabiNesnesi= new CocukKitabi("Cocuk Kitap Adı","C. Kitabı Yazar Adı","Kırmızı");
            //cocukKitabiNesnesi.BilgiYazdir();
            //cocukKitabiNesnesi.Renk = "Mavi";

            Roman romanNesnesi= new Roman("Sefiller", "Victor Hugo", "Tarihsel Roman");

            Kitap kitapNesnesi = romanNesnesi; // Upcasting

            kitapNesnesi.BilgiYazdir();
           

            Roman romanNesnesi2 = (Roman)kitapNesnesi; // Downcasting
            Console.WriteLine(romanNesnesi2.Tur);

            Console.ReadLine();
        }
    }
}
