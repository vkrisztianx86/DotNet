namespace Autonyilvantarto
{
    public class Auto
    {
        static int OsszAllomany;

        public string Rendszam { get;  }

        public AutoEnum Tipus { get; }

        List<double> Fogyasztasok;

        double amortizacio = 100;

        static Auto()
        {
            OsszAllomany = 0;
        }

        public Auto(string rsz, AutoEnum tip)
        {
            Rendszam = rsz;
            Tipus = tip;
            Fogyasztasok = new List<double>();
            OsszAllomany++;
        }

        public static int Allomany()
        {
            return OsszAllomany;
        }

        public void Megy(double atlagfogy)
        {
            Fogyasztasok.Add(atlagfogy);
        }

        public double AtlagFogy()
        {
            double ossz = 0;
            foreach (double egyfogy in Fogyasztasok)
            {
                ossz += egyfogy;
            }

            Amortizalodik();

            return ossz / Fogyasztasok.Count;
        }

        private void Amortizalodik()
        {
            amortizacio *= 0.001;
        }

    }
}
