using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите симовол");
            char symbol = Convert.ToChar(Console.ReadLine());
            name = symbol + name +symbol;

            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
            Console.WriteLine(name);
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(symbol);
            }
        }
    }
}