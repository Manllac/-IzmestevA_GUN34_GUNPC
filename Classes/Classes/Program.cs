using System;
using System.Collections.Generic;

namespace Classes
{
    internal static class Program
    {
        static void Main()
        {
            Console.WriteLine("Подготовка к бою:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите начальное здоровье бойца (10-100):");
            int.TryParse(Console.ReadLine(), out int health);
            var unit = new Unit(name, health);
        }
    }
}
