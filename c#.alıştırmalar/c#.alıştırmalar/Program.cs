using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_.alıştırmalar
{
    internal class Program
    {
        static void Main(string[] args)
          {
            string isim,soyisim,sehir;
            int yas;
            Console.WriteLine("Merhaba");
            Console.WriteLine("isminiz:");
            isim= Console.ReadLine();
            Console.WriteLine("Soyisminiz:");
            soyisim= Console.ReadLine();
            Console.WriteLine("Yasadiginiz sehir");
            sehir= Console.ReadLine();
            Console.WriteLine("Yasiniz kac");
            yas=int.Parse(Console.ReadLine());
            Console.WriteLine(isim);
            Console.WriteLine(soyisim);
            Console.WriteLine(sehir);
            Console.WriteLine(yas);
            Console.ReadLine();
            Console.Clear();    

        }
    }
}
