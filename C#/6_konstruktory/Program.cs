namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Janusz" , "Nowak", 20);
            p.showData();

            Person kowal = new Person();
            kowal.showData();
            Console.WriteLine("Number: " + kowal.getNumber());

            Person p1 = new Person();
            Console.WriteLine("Number: " + p1.getNumber());

            p1 = null;
            Console.WriteLine("Number: " + kowal.getNumber());

            Console.ReadKey();

        }
    }
}