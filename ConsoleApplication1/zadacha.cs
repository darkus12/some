using System;

namespace ConsoleApplication1
{

    internal class NewClass
    {
        public static void DoNothing()
        {


            Console.Write("Введіть число від 1 до 7: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Помилка: ви нічого не ввели!");
                return;
            }

            bool success = int.TryParse(input, out int dayNumber);

            if (!success)
            {
                Console.WriteLine("Помилка: потрібно ввести ціле число!");
                return;
            }

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Понеділок");
                    break;
                case 2:
                    Console.WriteLine("Вівторок");
                    break;
                case 3:
                    Console.WriteLine("Середа");
                    break;
                case 4:
                    Console.WriteLine("Четвер");
                    break;
                case 5:
                    Console.WriteLine("П’ятниця");
                    break;
                case 6:
                    Console.WriteLine("Субота");
                    break;
                case 7:
                    Console.WriteLine("Неділя");
                    break;
                default:
                    Console.WriteLine("Помилка: потрібно ввести число від 1 до 7!");
                    break;
            }
        }
    }
}