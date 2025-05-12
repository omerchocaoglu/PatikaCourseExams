using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test();
            Console.ReadLine();
        }

        static void Test()
        {
            int number1 = 10;
            long number2 = 2147483648;
            short number3 = 3434;
            byte number4 = 255;
            bool condition = true;
            char character = 'A';
            double number5 = 10.5;
            decimal number6 = 10.5m;
            var number7 = 10;
            int degisken = 5;

            // Değişken DOnüşümlerı

            string str20 = "20";

            int int20 = 20;

            string yeniDeger = str20 + int20.ToString(); 
            Console.WriteLine(yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20); 
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22);

            // DateTime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy"); 
            Console.WriteLine(datetime2);
        }
    }
}
