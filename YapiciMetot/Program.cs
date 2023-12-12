using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiciMetot
{ 
    class Kisi
    {
        int yas;
        string ad;
        public Kisi() 
        {
            yas = 15;
            ad = "Levent";
            Console.WriteLine("Yapıcı Metot Çalıştıtır");
        }
        public int Yas 
        {
         get { return yas; }    
        }
        public string Ad
        {
            get { return ad; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pogram başladı.");
            Kisi K = new Kisi();
            Console.WriteLine("ad:{0},Yaşı:{0}",K.Ad,K.Yas);
        }
    }
}
