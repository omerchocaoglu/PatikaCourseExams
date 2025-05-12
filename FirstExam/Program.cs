using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // GetPositiveNumbers();
            // DividedNumbers();
            //JoinWords();
            WordsLength();
            Console.ReadLine();
        }
        public static void GetPositiveNumbers()
        {
            Console.Write("Bir Sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            int[] numberLoop = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Lütfen {0} sayısı giriniz: ", i + 1);
                numberLoop[i] = int.Parse(Console.ReadLine());
            }
            foreach (var number in numberLoop)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"Çift olan: {number}");
                }
            }
        }
        public static void DividedNumbers()
        {
            Console.Write("Lütfen sayı giriniz: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Lüffen bir sayı daha giriniz: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int[] numberLoop = new int[secondNumber];

            for (int i = 0; i < secondNumber; i++)
            {
                Console.WriteLine($"Lütfen {i + 1}. sayısı giriniz: ");
                numberLoop[i] = int.Parse(Console.ReadLine());
            }

            foreach (var number in numberLoop)
            {
                if (number == firstNumber)
                {
                    Console.WriteLine($"{number} sayısı verdiğiniz ilk sayıya eşittir.");
                }
                else if (number % firstNumber == 0)
                {
                    Console.WriteLine($" {firstNumber} sayısına tam bölünen sayı: {number}.");
                }
            }
        }
        public static void JoinWords()
        {
            Console.Write("bir sayı giriniz: ");
            int firstNumber = int.Parse(Console.ReadLine());
            string[] firstWord = new string[firstNumber];
            for (int i = 0; i < firstNumber; i++)
            {
                Console.WriteLine($"Lütfen {i + 1}. harfi giriniz: ");
                firstWord[i] = Console.ReadLine();
            }
            Array.Reverse(firstWord);
            Console.Write("Ters çevrilmiş hali: ");
            foreach (var word in firstWord)
            {
                Console.Write(word);
            }
        }
        public static void WordsLength()
        {
            Console.Write("Lütfen bir cümle yazınız: ");
            string writeSentence = Console.ReadLine();
            Console.WriteLine($"Toplam harf: {writeSentence.Length}");
        }
    }
}
