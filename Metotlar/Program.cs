using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number(2,2);
            
            Methods methods = new Methods(); // burada instance'ını oluşturduk kullanmak için bunu yapmak zorundayız
            methods.WriteToConsole("Hello world");

            methods.IncreaseAndSum(2, 2);
            
            Console.ReadLine();

        }
        // Static bir class sadece static classlar çağırabilir.
        public static int Number(int a, int b) // static'i kaldırırsak bu metotu main'den çağıramayız
        {
            var result = a + b;
            Console.WriteLine(result);
            return result;
        }
    }
    class Methods
    {
        public void WriteToConsole(string data) // public yapmazsak default olarak private'tır.
        {
            Console.WriteLine(data);
        }
        public int IncreaseAndSum (ref int value1,ref int value2) // referans tipi veri tipidir. Bunun anlamı sadece buradan işlem yapıyor global olarak tanımlamış olduk
        {
            value1 += 1;
            value2 += 1;
            Console.WriteLine(value1 + value2);
            return value1 + value2;
        }
    }
}
