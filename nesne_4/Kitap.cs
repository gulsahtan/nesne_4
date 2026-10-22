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

        public void BilgiYazdir()
        {
            Console.WriteLine("Kitap Adı: " + Ad);
            Console.WriteLine("Yazar: " + Yazar);
        }
    }
}
