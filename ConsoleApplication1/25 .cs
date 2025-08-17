using System;

namespace ConsoleApplication1
{
    internal class MyClass
    {
        public static void DoSome()
        {
/*double imp1, imp2;

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
*/

// 134 задача
    Console.Write("Введіть, будь ласка, ваше ім'я: ");
string name = Console.ReadLine();

int age;
Console.Write("Введіть ваш вік: ");
while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
{
    Console.WriteLine("Помилка! Введіть коректний вік (більше 0 ): ");
}

string category;

if (age > 1 && age <= 10)
{
    category = "дитина";
}
else if (age > 11 && age <= 15)
{
    category = "підліток";
}
else if (age > 16 && age <= 20)
{
    category = "юнак (юнка)";
}
else if (age > 21 && age <= 30)
{
    category = "молода людина";
}
else
{
    category = "доросла людина";
}

Console.WriteLine($"{name}, ви належите до категорії: {category}");


}


}


}