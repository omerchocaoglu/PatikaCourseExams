using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test();
            Test2();

            Console.ReadLine();
        }

        static void Test()
        {
            try
            {
                //int a = int.Parse(Console.ReadLine());

                //int b = int.Parse(Console.ReadLine());

                //int c = a + b;
                int c = Convert.ToInt32(Console.ReadLine());
                //int a = int.Parse(null);

                Console.WriteLine(c);
                //Console.WriteLine(a);
            }
            //catch (Exception exception)
            //{
            //    Console.WriteLine("Bir Hata Oluştu: " + exception.Message);
            //}
            catch (ArgumentNullException exception)
            {
                //Console.WriteLine("Bir Hata Oluştu: " + exception.Message);
                Console.WriteLine("Bir Hata Oluştu: ");
                Console.WriteLine(exception);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }
        }

        static void Test2()
        {
            var value = DateTime.Now.Hour;

            if (value == 23)
            {
                Console.WriteLine("The time is {0}", value);
            }
            else
            {
                Console.WriteLine("The time isnt {0}", value);
            }
            ;
            var result = value == 12 ? "The time is 12" : "the time is not 12";
            Console.WriteLine(result);

            int day = 4;
            switch (day)
            {
                case 1:
                case 8:
                case 9:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
        }
    }
}
