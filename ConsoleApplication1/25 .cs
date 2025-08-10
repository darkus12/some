using System;

namespace ConsoleApplication1
{
    internal class MyClass
    {
        public static void DoSome()
        {
            Console.WriteLine("введіть, будь ласка, число");
            double imp1 = double.Parse(Console.ReadLine());
            double imp2 = double.Parse(Console.ReadLine());
            if (imp1 > 0.0)
            {
                if (imp2 > 0.0)
                {
                    Console.WriteLine( imp1 + imp2 );
                } else
                {
                    Console.WriteLine("просимо пробачення, зараз дана функція не працює)");
                }
            }
            else
            {
                Console.WriteLine("перше число не правильне");
            }
            

            


        }

        
    }

    
}