namespace _4_klasy
{
    internal class Program
    {
        class Animal
        {
            public string name;
            public void getVoice()
            {
                Console.WriteLine("Hau Hau Hau");
            }
        }

        static class Calculator
        {
            //public static int Add(int a, int b)
            //{
            //    return a + b;
            //}
            public static T Add<T>(T a, T b)
            {
                dynamic x = a;
                dynamic y = b;
                return x + y;
            }
        }

        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.name = "Reksio";
            Console.WriteLine(animal.name);
            animal.name = "Edi";
            Console.WriteLine(animal.name);
            animal.getVoice();
            //Console.WriteLine(Calculator.Add(2,4));
            Console.WriteLine(Calculator.Add<int>(2, 4));

            float y1 = 4.5F, y2 = 6;
            Console.WriteLine(Calculator.Add<float>(y1,y2));
        }
    }
}