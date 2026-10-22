using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesne_4
{
    public class CocukKitabi : Kitap
    {
        public string Renk;
        public CocukKitabi(string kitapAdi, string yazarAdi, string cKitabiRenk ): base(kitapAdi, yazarAdi)
        {
            this.Renk= cKitabiRenk;
            Console.WriteLine("Çocuk Kitabı sınıfının yapıcı metodu çalıştı.");
        }
       
    }
}
