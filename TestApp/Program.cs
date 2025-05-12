using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello();
            Math(2, 2);

            //for another class
            Ayar ayar = new Ayar();
            ayar.Hello2();
            ayar.Math2(10, 10);
            ayar.Math2(10, 10, 10);
            ayar.GetParams(50, 50);

            Console.ReadLine();
        }
        static void Hello ()
        {
            string hello = "Hello";
            Console.WriteLine(hello);
        }
        static int Math (int x, int y)
        {
            var result = x + y;
            Console.WriteLine("This comes from another static and the result is= {0}", result);
            return result;
        }
    }
    class Ayar
    {
        public void Hello2()
        {
            string hello = "Hello from another class";
            Console.WriteLine(hello);
        }
        public int Math2(int x, int y)
        {
            var result = x + y;
            Console.WriteLine("This math comes another class and the result is= {0}", result);
            return result;
        }
        public int Math2(int x, int y, int b)
        {
            var result = x + y + b;
            Console.WriteLine("This math comes another class but its overloading and the result is= {0}", result);
            return result;
        }
        public int GetParams(params int[] numbers)
        {
            var getNumbers = numbers.Sum();
            Console.WriteLine("Your result is coming from params and its: {0}", getNumbers);
            return getNumbers;
        }
    }
}
