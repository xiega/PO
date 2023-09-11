using System.ComponentModel.DataAnnotations;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tabInt = { 1, 2, 3, 4, -5, 10, -20, 0, 2, 11 };

            for (int i = 0; i < tabInt.Length; i++)
            {
                Console.Write($"{tabInt[i]} ");
            }
            Console.WriteLine();

            foreach (int x in tabInt)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();


            for (int i = 0; i < tabInt.Length; i++)
            {
                tabInt[i] += 2;
                Console.Write($"{tabInt[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("Minimum {0}", tabInt.Min());
            Console.WriteLine("Maximum {0}", tabInt.Max());

            Array.Reverse(tabInt);
            for (int i = 0; i < tabInt.Length; i++)
            {
                Console.Write($"{tabInt[i]} ");
            }
            Console.WriteLine();

            Array.Sort(tabInt);
            for (int i = 0; i < tabInt.Length; i++)
            {
                Console.Write($"{tabInt[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine(Array.BinarySearch(tabInt, 0));
            Console.WriteLine(Array.BinarySearch(tabInt, 1000));

            tabInt[0] = 100;
            Console.WriteLine(Array.BinarySearch(tabInt, 100));
            Array.Sort(tabInt);
            Console.WriteLine(Array.BinarySearch(tabInt, 100));

            Console.WriteLine("Ilość elementów: " + tabInt.Length);
            Console.WriteLine("---------------------------------------------------------");

            //---------------------------------------------------------

            Person[] persons = new Person[5];

            Person p1 = new Person("Janusz", "Nowak");
            Person p2 = new Person("Anna", "Kowalska");
            Person p3 = new Person("Franciszek", "Bąk");
            Person p4 = new Person("Franciszek", "Bąk");
            Person p5 = new Person("Franciszek", "Bąk");

            persons[0] = p1;
            persons[1] = p2;
            persons[2] = p3;
            persons[3] = p4;
            persons[4] = p5;

            foreach (Person p in persons)
            {
                Console.WriteLine("Imię i nazwisko: " + p.firstName + " " + p.lastName);
            }

            Console.WriteLine(persons.Length);
            Console.WriteLine("---------------------------------------------------------");

            //---------------------------------------------------------

            object[] objects = new object[6];
            objects[0] = 10;
            objects[1] = 10.1f;
            objects[2] = "Janusz";
            objects[3] = 'a';
            objects[4] = null;
            objects[5] = new Person("Janusz", "Kowalski"); ;

            foreach (object item in objects)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------------------------");
            //---------------------------------------------------------

            Console.Clear();

            //------------------------- Tablice wielowymiarowe --------------------------------

            int[,,] tabInts = new int[2, 4, 10];
            Console.WriteLine(tabInts.GetLength(0));
            Console.WriteLine(tabInts.GetLength(1));
            Console.WriteLine(tabInts.GetLength(2));

            Console.WriteLine(tabInts.Length);
            /*int[,] intArray = new int[2, 3];
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    Console.Write($"{intArray[i, j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            */

            int[][] tab = new int[3][];

            Console.WriteLine(tab.Length);

            for(int i = 0; i < tab.Length; i++)
            {
                tab[i] = new int[i + 1];
            }
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
            Console.Clear();
            int[,,,] tab4 = new int[2, 3, 4, 5];
            int count = 0;
            Console.WriteLine("Ilość elementów: " + tab4.Length);

            for(int i=0; i<tab4.GetLength(0); i++)
            {
                Console.WriteLine($"tab[{i}]");
                for (int j = 0; j < tab4.GetLength(1); j++)
                {
                    Console.WriteLine($"\ttab[{i},{j}]");
                    for (int k = 0; k < tab4.GetLength(2); k++)
                    {
                        Console.WriteLine($"\t\ttab[{i},{j},{k}]");
                        for (int l = 0; l < tab4.GetLength(3); l++)
                        {
                            Console.WriteLine($"\t\t\ttab[{i},{j},{k},{l}] = {++count}");
                        }
                    }
                }
            }
        }
    }
}