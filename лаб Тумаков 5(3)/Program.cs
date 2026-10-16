using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб_Тумаков_5_3_
{
    class Program
    {
        private static readonly Dictionary<int, string[]> DigitPatterns = new Dictionary<int, string[]>
        {
            [0] = new[]
            {
                "#####",
                "#   #",
                "#   #",
                "#   #",
                "#####"
            },
            [1] = new[]
            {
                "  #  ",
                " ##  ",
                "# #  ",
                "  #  ",
                "#####"
            },
            [2] = new[]
            {
                "#####",
                "    #",
                "#####",
                "#    ",
                "#####"
            },
            [3] = new[]
            {
                "#####",
                "    #",
                "#####",
                "    #",
                "#####"
            },
            [4] = new[]
            {
                "#   #",
                "#   #",
                "#####",
                "    #",
                "    #"
            },
            [5] = new[]
            {
                "#####",
                "#    ",
                "#####",
                "    #",
                "#####"
            },
            [6] = new[]
            {
                "#####",
                "#    ",
                "#####",
                "#   #",
                "#####"
            },
            [7] = new[]
            {
                "#####",
                "    #",
                "   # ",
                "  #  ",
                " #   "
            },
            [8] = new[]
            {
                "#####",
                "#   #",
                "#####",
                "#   #",
                "#####"
            },
            [9] = new[]
            {
                "#####",
                "#   #",
                "#####",
                "    #",
                "#####"
            }
        };

        static void Main()
        {
            while (true)
            {
                Console.Write("Введите число (или 'exit' / 'закрыть' для выхода): ");
                string input = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(input))
                    continue;

                // Проверка на завершение работы
                if (input.ToLower() == "exit" || input.ToLower() == "закрыть")
                {
                    Console.WriteLine("Программа завершена.");
                    break;
                }

                // Попытка преобразовать ввод в число
                if (!int.TryParse(input, out int number))
                {
                    Console.WriteLine("Ошибка: введено не число!");
                    continue;
                }

                if (number >= 0 && number <= 9)
                {
                    PrintDigit(number);
                }
                else
                {
                    ShowErrorRed();
                }
            }
        }

        static void PrintDigit(int digit)
        {
            foreach (var line in DigitPatterns[digit])
            {
                Console.WriteLine(line);
            }
        }

        static void ShowErrorRed()
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка: число должно быть в диапазоне от 0 до 9!");
            System.Threading.Thread.Sleep(3000); // 3 секунды
            Console.ForegroundColor = originalColor; // возвращаем цвет
        }
    }
}
//lkgjeiorjgaoierj