using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];
            string[] hayvanlar = { "kediler", "köpekler", "kuşlar" };
            int[] sayılar;
            sayılar = new int[5];
            sayılar.Append(1);
            Console.WriteLine(sayılar[0]);

            Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
            int diziUzunlugu = int.Parse( Console.ReadLine() );
            int[] sayiDizisi = new int[diziUzunlugu];
            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayısı giriniz: ", i + 1);
                sayiDizisi[i] = int.Parse( Console.ReadLine() );
            }
            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;    
            }
            Console.WriteLine("Ortalama: " + toplam / diziUzunlugu);

            Console.ReadLine();
        }
    }
}
