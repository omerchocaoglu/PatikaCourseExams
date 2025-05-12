using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            While();

            Console.ReadLine();
        }
        public static void While()
        {
            Console.Write("Bir sayı yazınız= "); // sadece write ı kullandığımız için ikisi de aynı satırda gözükecek
            int number = int.Parse(Console.ReadLine()); // console her zaman string okur o yüzden int yazdırırken böyle kullanmalıyız
            for (int i = 0; i < number; i++)
            {
                if ( i%2 == 1 ) // böyle tek sayı halinde alacağız
                {
                    Console.WriteLine(i);
                }
            }
            int sayac = 1;
            while (sayac <= 5)
            {
                Console.WriteLine(sayac);
                sayac++;
            }
            int[] sayiDizisi = { 2, 4, 5, 1, 2, 4 };
            int toplam = 0;

            foreach (int i in sayiDizisi)
            {
                toplam += i;
                Console.WriteLine(i);
            }
        }
    }
}
