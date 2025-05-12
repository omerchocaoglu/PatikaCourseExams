using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.Numbers(3,3);
            test.Numbers(4,4,4);
            test.Params(3,3, 3,3,10);
            
            Console.ReadLine();
        }
    }
    public class Test
    {
        public int Numbers(int number1, int number2)
        {
            var result = number2 + number1;
            Console.WriteLine(result);
            return result;
        }
        public int Numbers(int number1, int number2, int number3)
        {
            var result = number1 + number2 + number3;
            Console.WriteLine(result);
            return result;
        }
        public void Params(params int[] numbers)
        {
            int sumNumbers = numbers.Sum();
            Console.WriteLine(sumNumbers);
        }
    } }
