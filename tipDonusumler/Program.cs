using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipDonusumler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            implicitConversion();
            expicitConversion();
            toStringMethod();
            toInt();

            Console.ReadLine();
        }

        //implicit conversion (bilinçsiz dönüşüm)
        static void implicitConversion()
        {
            byte a = 5;
            sbyte b = 5;
            short c = 30;
            int d = a + b + c;
            Console.WriteLine("implicit conversion {0}",d);
        }

        //explicit conversion (Bilinçli Dönüşüm)
        static void expicitConversion ()
        {
            int x = 4;
            byte y = (byte) x;
            Console.WriteLine ("expicit conversion {0}", y);
        }

        // ToString
        static void toStringMethod ()
        {
            int x = 5;
            x.ToString();

            Console.WriteLine("toStringMethod {0}", x);
        }

        static void toInt()
        {
            string value = "k";
            int number = (int)value[0];
            Console.WriteLine(value);

            string x = "12";
            Convert.ToInt32(x);
            Console.WriteLine(x);
        }
    }
}
