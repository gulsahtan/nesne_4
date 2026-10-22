using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesne_4
{
    public class Roman :Kitap
    {
        public string Tur;
        public Roman(string kitapAdi, string yazarAdi, string romanTuru):base(kitapAdi, yazarAdi)
        {
            this.Tur= romanTuru;    
            Console.WriteLine("Roman sınıfının yapıcı metodu çalıştı.");

        }
       
    }
}
