using System;


//1. Определить, является введённое слово «перевёртышем» (например, «потоп», «казак»).
//PR5V8_Duloglu
namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово: ");
            string word = Console.ReadLine();

            bool isPalindrome = true;

            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("Слово является перевертышем.");
            }
            else
            {
                Console.WriteLine("Слово не является перевертышем.");
            }

            Console.ReadKey();
        }
    }
}