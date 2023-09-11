namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Anna", "Pierwsza");
            Person p2 = new Person("Tomasz", "Drugi");
            Person p3 = new Person("Krzysztof", "Trzeci");

            List<Person> persons = new List<Person>();
            persons.Add(p1);
            persons.Add(p2);
            persons.Add(p1);

            Console.WriteLine(persons.Count); //3
            Console.WriteLine(persons.Contains(p1)); //True
            Console.WriteLine(persons.Contains(p3)); //False

            Console.WriteLine(persons.IndexOf(p1)); //0
            persons.Remove(p1);

            foreach(var p in persons)
            {
                Console.WriteLine("Imię i nazwisko: " + p.firstName + " " + p.lastName);
            }

            persons.RemoveAt(0);
            Console.WriteLine();
            Console.WriteLine(persons.Count); //1
            foreach (var p in persons)
            {
                Console.WriteLine("Imię i nazwisko: " + p.firstName + " " + p.lastName);
            }

            persons.Insert(0, p1);
            Console.WriteLine();
            Console.WriteLine(persons.Count); //2

            foreach (var p in persons)
            {
                Console.WriteLine("Imię i nazwisko: " + p.firstName + " " + p.lastName);
            }

            persons.Clear();

            foreach (var p in persons)
            {
                Console.WriteLine("Imię i nazwisko: " + p.firstName + " " + p.lastName);
            }

            persons.Add(new Person("Krzysztof", "Czwarty"));
            persons.Add(new Person("Janina", "Piąta"));
            Console.WriteLine(persons.Count); //2

            foreach (var p in persons)
            {
                Console.WriteLine("Imię i nazwisko: " + p.firstName + " " + p.lastName);
            }

            List<int> intsList = new List<int>();
            int[] intsTab = { 1, 2, 3, 4, 5 };
            int[] intsTab2 = { -10, -20, -30 };
            intsList.AddRange(intsTab);

            foreach(int i in intsList)
            {
                Console.Write(i + " "); //1 2 3 4 5
            }

            intsList.AddRange(intsTab2);
            Console.WriteLine();

            foreach (int i in intsList)
            {
                Console.Write(i + " "); //1 2 3 4 5 -10 -20 -30
            }

            intsList.InsertRange(2, intsTab);
            Console.WriteLine();

            foreach (int i in intsList)
            {
                Console.Write(i + " "); //1 2 1 2 3 4 5 -10 -20 -30
            }

            Console.WriteLine();
            intsList.RemoveRange(2, 8);

            foreach (int i in intsList)
            {
                Console.Write(i + " "); //1 2 -10 -20 -30
            }

            Console.WriteLine();
            //kopiowanie tablicy do listy, listy do tablicy
            var list = new List<int>();
            int[] intArray = { 1, 2, 3 };
            list.AddRange(intArray);
            foreach (int i in list)
            {
                Console.Write(i + " "); //1 2 3
            }

            Console.WriteLine();
            int[] intArrayList = list.ToArray();
            foreach(int i in list)
            {
                Console.WriteLine(i+" "); //1 2 3
            }
            Console.WriteLine();
        }
    }
}