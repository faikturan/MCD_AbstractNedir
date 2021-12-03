using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Abstract ve Interface Kavramları
             * 
             * Kendimize işi yapacak bir rol model çıkartırız. Nasıl olacağının kurallarını hazırlar ve nesnelerimizde kurallarımızı kullanırız.
             * 
             * Bu bölümde oluşturmuş olduğumuz nesnelerimizi nasıl kurallar ile şartlayabileceğimizi konuşacağız.
             * 
             */

            //temelSinif T1 = new temelSinif();//Abstract class new anahtar kelimesi ile bir örneği alınamaz.

            superMusteri SP1 = new superMusteri();
            SP1.testAbctract();

            musteri M1 = new musteri();
            M1.test();
            M1.testAbctract();

            Console.ReadKey();
        }
    }
}
