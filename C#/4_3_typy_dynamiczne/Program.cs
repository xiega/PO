namespace typy_dynamiczne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic x;
            x = 10;
            Console.WriteLine("Typ zmiennej: " + x.GetType() + ", x = " + x); //Typ zmiennej: System.Int32, x = 10
            x = 10L;
            Console.WriteLine("Typ zmiennej: " + x.GetType() + ", x = " + x); //Typ zmiennej: System.Int64, x = 10
            x = "Janusz";
            Console.WriteLine("Typ zmiennej: " + x.GetType() + ", x = " + x); //Typ zmiennej: System.String, x = Janusz
            x = 10.5F;
            Console.WriteLine("Typ zmiennej: " + x.GetType() + ", x = " + x); //Typ zmiennej: System.Single, x = 10,5
        }
    }
}