using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Toplama(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + toplam);
        }

        public void Carpma(int sayi1, int sayi2)
        {
            int carpim = sayi1 * sayi2;
            Console.WriteLine("Çarpım : " + carpim);
        }

        public void Bolme(double sayi1, double sayi2)
        {
            double bolum = sayi1 / sayi2;
            Console.WriteLine("Bölüm : "+ bolum);
        }

        public void Cikartma(int sayi1, int sayi2)
        {
            int cikartma = sayi1 - sayi2;
            Console.WriteLine("Çıkartma : " + cikartma);
        }

    }
}
