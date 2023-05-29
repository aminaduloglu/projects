using System;

//В качестве пунктов меню предложить: «*.JPG», «*.GIF», «*.PNG», «*.BMP», «*.SVG», «Выход». Реализовать «пролистывание» меню без
//контроля границ диапазона.
//Подтверждение выбранного пункта меню реализовать по клавише «Enter».
//Выбор пункта вне диапазона реализует возврат курсора в диапазон.

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menu = { "*.JPG", "*.GIF", "*.PNG", "*.BMP", "*.SVG", "Выход" };
            int currentSelection = 0;

            while (true)
            {
                Console.Clear();

                for (int i = 0; i < menu.Length; i++)
                {
                    if (i == currentSelection)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }

                    Console.WriteLine(menu[i]);
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        currentSelection--;
                        break;
                    case ConsoleKey.DownArrow:
                        currentSelection++;
                        break;
                    case ConsoleKey.Enter:
                        if (currentSelection >= 0 && currentSelection < menu.Length - 1)
                        {
                            Console.WriteLine("Выбран пункт меню: " + menu[currentSelection]);
                            Console.ReadKey();
                        }
                        else if (currentSelection == menu.Length - 1)
                        {
                            return;
                        }
                        else
                        {
                            currentSelection = 0;
                        }
                        break;
                }

                if (currentSelection < 0)
                {
                    currentSelection = menu.Length - 1;
                }
                else if (currentSelection >= menu.Length)
                {
                    currentSelection = 0;
                }
            }
        }
    }
}
