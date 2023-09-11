using System;

namespace _2_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine('a');
            Console.WriteLine("a");

            Console.WriteLine("Programowanie"[1]); //r

            Console.WriteLine("Programowanie".Equals("programowanie")); //False
            Console.WriteLine("Programowanie".Equals("Programowanie")); //True

            Console.WriteLine("Programowanie".IndexOf("a")); //5
            Console.WriteLine("Programowanie".LastIndexOf("a")); //9

            Console.WriteLine("Łukasz".Length); //6

            Console.WriteLine("Programowanie".Replace("P","$")); //$rogramowanie

            Console.WriteLine("Programowanie".Substring(3)); //gramowanie
            Console.WriteLine("Programowanie".Substring(3,4)); //gram

            Console.WriteLine("Programowanie".Remove(3,4)); //Proowanie
            Console.WriteLine("Programowanie".Insert(3, "123")); //Pro123gramowanie

            Console.WriteLine("  Janusz Kowalski ".Length); //18
            Console.WriteLine("  Janusz Kowalski ".Trim().Length); //15
            Console.WriteLine("  Janusz Kowalski ".TrimStart().Length); //16
            Console.WriteLine("  Janusz Kowalski ".TrimEnd().Length); //17

            Console.WriteLine("Programowanie".ToLower()); //programowanie
            Console.WriteLine("Programowanie".ToUpper()); //PROGRAMOWANIE

            Console.WriteLine("Test".PadLeft(10, '*')); //******Test
            Console.WriteLine("Test".PadRight(10, '*')); //Test******

            Console.WriteLine("file.txt".StartsWith("file")); //True
            Console.WriteLine("file.txt".EndsWith(".txt")); //True

            Console.WriteLine("C:\\Users\\Desktop\\15_11_2022\\2_string");
            Console.WriteLine(@"C:\Users\Desktop\15_11_2022\2_string");

            Console.WriteLine("\tProgramowanie w \b\bC#\n");

            Console.WriteLine("\n\t\u0054 \u0065 \u0073 \u0074 \u263b");
        }
    }
}