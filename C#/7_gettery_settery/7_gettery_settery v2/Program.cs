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
            Console.Clear();

            kowal.setAge(30);
            Console.WriteLine("Wiek obiektu kowal: " + kowal.getAge() + " lat");

            kowal.setAge((byte)(kowal.getAge()+1));
            Console.WriteLine("Wiek obiektu kowal: " + kowal.getAge() + " lat");

            kowal.Height = 180.5f;
            Console.WriteLine("Wzrost Kowala: " + kowal.Height + " cm");

            kowal.Height -= 2;
            Console.WriteLine("Wzrost Kowala: " + kowal.Height + " cm"); 
            
            kowal.Height += 2;
            Console.WriteLine("Wzrost Kowala: " + kowal.Height + " cm");

            kowal.Weight = 100;
            Console.WriteLine("Waga Kowala: " + kowal.Weight + " kg");

            kowal.Weight += 800;
            Console.WriteLine("Waga Kowala: " + kowal.Weight + " kg"); //nadal 100

            Console.ReadKey();

        }
    }
}