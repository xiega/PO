namespace _10_3_kolekcje_listy_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            Person p1 = new Person("Janusz");
            persons.Add(p1);

            Person p2 = new Person("Anna");
            persons.Add(p2);

            Console.WriteLine(persons.Count); //2

            persons.Insert(2, p1);
            Console.WriteLine(persons.Count); //3

            Console.WriteLine(persons.Contains(p1)); //True

            Person p3 = new Person("xyz");
            Console.WriteLine(persons.Contains(p3)); //False

            Console.WriteLine(persons.IndexOf(p1)); //0

            persons.Remove(p2);
            persons.RemoveAt(0);

            Console.WriteLine(persons.Count); //1

            persons.Clear();
            Console.WriteLine(persons.Count); //0
        }
    }
}