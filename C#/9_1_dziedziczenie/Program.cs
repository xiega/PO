namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Janusz", "Person");
            Console.WriteLine(p.Info());

            Employee e = new Employee("Janusz", "Employee", 50.50f, 168);
            Console.WriteLine(e.Info());

            Student s = new Student("Janusz", "Student", Student.classesAtSchool._2a);
            Console.WriteLine(s.Info());
        }
    }
}