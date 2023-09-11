using System;

namespace zad2
{
    internal class Program
    {
        static void show()
        {
            Console.WriteLine("Metoda show");
        }

        static void show(string text)
        {
            Console.WriteLine(text);
        }

        static void show(string text, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
        }

        static void Main(string[] args)
        {
            show();
            show("Programowanie");
            show("C#", ConsoleColor.Cyan);
        }
    }
}
