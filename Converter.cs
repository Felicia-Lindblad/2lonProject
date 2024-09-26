namespace _2lönProject
{
    public class Converter
    {
        public double BeräknaLönEfterSkatt(double lönInnanSkatt, double skatt)
        {
            return lönInnanSkatt - (lönInnanSkatt * (skatt / 100));
        }
    }
}
