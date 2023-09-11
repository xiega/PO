namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Swap<T>(ref T x, ref T y)
            {
                T pom = x;
                x= y;
                y = pom;
            }

            float a = 5, b = 10;
            Swap<float>(ref a, ref b);
            Console.WriteLine($"{a} {b}");
        }
    }
}