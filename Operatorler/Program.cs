using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test();

            Console.ReadLine();
        }
        public static void Test()
        {
            // OPERATÖRLER
            int x = 3;
            int y = 4;
            y += 2; // buna işlemli atama deniyor
            Console.WriteLine(y += 2); // çıktı 8
            Console.WriteLine(y /= 2); // çıktı 4

            // MANTIKSAL OPERATÖRLER
            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess == true)
            {
                isSuccess = true;
            } else
            {
                isSuccess = false;
            }
            Console.WriteLine(isSuccess);

            if (isSuccess &&  isCompleted == true)
            {
                Console.WriteLine("These are true!");
            } else
            {
                Console.WriteLine("One of them is false!");
            }
            
            if (isSuccess || isCompleted == true)
            {
                Console.WriteLine("These are true!");
            }
            else
            {
                Console.WriteLine("One of them is false!");
            }

            // İLİŞKİSEL OPERATÖRLER
            int a = 3;
            int b = 4;
            int c = 5;
            Console.WriteLine(a > b); // false dönecek
            Console.WriteLine(c > b); // true dönecek


            // ARİTMATİK OPERATÖRLER
            int number1 = 10;
            int number2 = 20;
            int number3 = 5;

            int result1 = number1 / number2;
            int result2 = number2 / number3;
            int result3 = number1 * number2 / number3;

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            // MOD ALMA
            int getNumber = 20;
            int resultNumber = getNumber % 3;
            Console.WriteLine(resultNumber);
        }
    }
}
