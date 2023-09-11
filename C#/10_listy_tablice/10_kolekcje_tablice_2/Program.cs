namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //City c = new City("Poznań", "61-001", "Polska", 534800, 2, 1);

            string filePath = @"C:\Users\student\Desktop\10_kolekcje_tablice_2\csv\population.csv";

            CsvReader csvReader = new CsvReader(filePath);
            City[] cities = csvReader.ReadFirstNcities(5);

            //foreach (var city in cities)
            //{
            //    Console.WriteLine("Miasto");
            //}

            StreamReader sr = new StreamReader(filePath);
            string line = sr.ReadLine();
            City c = csvReader.readCityFromCsvLine(line);
            Console.WriteLine(c.cityName);
        }
    }
}