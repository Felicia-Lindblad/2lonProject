namespace _2lönProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till lönmätaren");
            Console.WriteLine("Skriv in din lön här;");

            string lönString = Console.ReadLine()!;
            double lön = Convert.ToDouble(lönString);

            Console.WriteLine($"Din lön innan skatt är {lön}");
            Console.WriteLine("Skriv in din skatt i procent");

            string skattString = Console.ReadLine()!;
            double skatt = Convert.ToDouble(skattString);

            Converter converter = new Converter();

            double lönEfterSkatt = converter.BeräknaLönEfterSkatt(lön, skatt);

            Console.WriteLine($"Din lön efter skatt är : {lönEfterSkatt}");
        }
    }
}
