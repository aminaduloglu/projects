using System;

//2. Дан текст, среди элементов которого есть символы «двоеточие». Получить все символы, 
//расположенные между первым и вторым встреченными символами «двоеточие». Если 
//второго двоеточия нет, то получить все символы, расположенные после единственного 
//двоеточия. В качестве текста для тестового примера (тестовых примеров) взять не менее 
//пяти предложений.
//PR5V8_Duloglu

namespace ColonSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            int firstColonIndex = text.IndexOf(':');
            int secondColonIndex = text.IndexOf(':', firstColonIndex + 1);

            if (secondColonIndex == -1)
            {
                string result = text.Substring(firstColonIndex + 1);
                Console.WriteLine("Символы после первого двоеточия: " + result);
            }
            else
            {
                string result = text.Substring(firstColonIndex + 1, secondColonIndex - firstColonIndex - 1);
                Console.WriteLine("Символы между первым и вторым двоеточиями: " + result);
            }

            Console.ReadKey();
        }
    }
}
