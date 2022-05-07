using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            string border = "";
            Console.WriteLine("Введите симовол");
            char symbol = Convert.ToChar(Console.ReadLine());
            name = symbol + name + symbol;

            for (int i = 0; i < name.Length; i++)
            {
                border += symbol;
            }

            Console.WriteLine(border);
            Console.WriteLine(name);
            Console.WriteLine(border);
        }
    }
}