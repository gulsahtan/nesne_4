using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesne_4
{
    public class Kitap
    {
        public string Ad;
        public string Yazar;

        public Kitap(string kitapAdi, string yazarAdi)
        {
            this.Ad = kitapAdi;
            this.Yazar = yazarAdi;
            Console.WriteLine("Kitap sınıfının yapıcı metodu çalıştı.");
        }

        public void BilgiYazdir()
        {
            Console.WriteLine("Kitap Adı: " + Ad);
            Console.WriteLine("Yazar: " + Yazar);
        }
    }
}
