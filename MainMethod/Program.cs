using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello();
            Console.ReadLine();

        }

        static void Hello()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("İsminizi Giriniz");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi Giriniz");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba" + " " +  name + " " + surname);
        }
    }
}
