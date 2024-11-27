using System;

namespace MyProject
{
    class Program
    {
        static void Main()
        {   // 1 задание
            /*
            Console.Write("Введите свое имя ну пожалуйста: """);
            string? name = Console.ReadLine("");
            Console.WriteLine($"Привет {name}""");
            */
            // 2 задание
            Console.Write("Введите ваш год рождения: ");
            // Считать введенный год и преобразовать его в целое число
            int year = Convert.ToInt32(Console.ReadLine());
            // Рассчитать возраст
            int age = 2024 - year;
            // Вывести результат
            Console.WriteLine($"Ваш возраст: {age}");

        }
    }
}