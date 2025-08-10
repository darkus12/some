using System;

namespace ConsoleApplication1
{
    internal class MyClass
    {
        public static void DoSome()
        {
            double imp1, imp2;

            Console.WriteLine("Введіть, будь ласка, перше число:");
            while (!double.TryParse(Console.ReadLine(), out imp1))
            {
                Console.WriteLine("Помилка! Введіть коректне число:");
            }

            Console.WriteLine("Введіть друге число:");
            while (!double.TryParse(Console.ReadLine(), out imp2))
            {
                Console.WriteLine("Помилка! Введіть коректне число:");
            }

            if (imp1 > 0.0)
            {
                if (imp2 > 0.0)
                {
                    Console.WriteLine("Сума: " + (imp1 + imp2));
                }
                else
                {
                    Console.WriteLine("Просимо пробачення, зараз дана функція не працює)");
                }
            }
            else
            {
                Console.WriteLine("Перше число має бути додатним.");
            }

            


        }

        
    }

    
}