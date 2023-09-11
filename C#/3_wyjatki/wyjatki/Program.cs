namespace wyjatki
{
    internal class Program
    {
        static float square(float x)
        {
            return x*x;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Podaj dane: ");
                float x = float.Parse(Console.ReadLine());
                float result = square(x);
                //Console.WriteLine(float.MinValue);
                //Console.WriteLine(float.MaxValue);
                if(x> Math.Sqrt(float.MaxValue)) throw new Exception("Przekroczony zakres liczby");
                if (x <= 0) throw new Exception("Bok nie może być równy lub krótszy od 0");
                Console.WriteLine($"Pole kwadratu o boku {x} wynosi: {result}");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Błędne dane wprowadzone z klawiatury: "+e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Wyjątek: "+e.Message);
            }
         
        }
    }
}