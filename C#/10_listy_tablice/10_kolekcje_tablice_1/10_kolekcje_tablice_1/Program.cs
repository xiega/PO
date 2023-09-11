namespace _10_kolekcje_tablice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string styczen = "January";
            Console.WriteLine("Pierwszy miesiąc: " + styczen);

            string[] monthsOfYear =
            {
                "Styczeń",
                "Luty",
                "Marzec",
                "Kwiecień",
                "Maj",
                "Czerwiec",
                "Lipiec",
                "Sierpień",
                "Wrzesień",
                "Październik",
                "Listopad",
                "Grudzień"
            };

            Console.WriteLine(monthsOfYear[0]);

            foreach (string month in monthsOfYear)
            {
                Console.WriteLine(month);
            }

            int[] arrayInt = { 1, 2, 3, 4 };
            char[] arrayChar = { 'a', 'b', 'c' };
            Console.Clear();

            Console.WriteLine("1-styczeń, 2-luty, itd. ");
            Console.Write("Podaj numer miesiąca: ");
            int chosenMonth = int.Parse(Console.ReadLine());
            Console.WriteLine($"Miesiąc wybrany przez użytkownika: {monthsOfYear[chosenMonth-1]}");
        }
    }
}