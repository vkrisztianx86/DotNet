namespace DaraboloOsztalyLib
{
    public class Szodarabolo
    {
        // field
        string s;
        int meret;
        string[] darabok;

        // property
        public bool Sikeres { get; set; }

        public void Kiiras()
        {
            if (Sikeres)
            {
                foreach (string darab in darabok)
                {
                    Console.WriteLine(darab);
                }
            }
        }

        public bool AdatBekeres()
        {
            Bekeres(out s, out meret);
            darabok = Meretezes(s, meret);
            Darabolas(s, meret, darabok);
            Sikeres = true;
            return true;
        }

        private void Bekeres(out string sp, out int meretp)
        {
            Console.WriteLine("Kérem a szöveget!");
            sp = Console.ReadLine();

            Console.WriteLine("Mérete?");

            while (!int.TryParse(Console.ReadLine(), out meretp))
            {
                Console.WriteLine("Nem jó a méret");
            }
        }

        private string[] Meretezes(string s, int meret)
        {
            string[] darabok2;
            if (s.Length % meret == 0)
            {
                darabok2 = new string[s.Length / meret];
            }
            else
            {
                darabok2 = new string[s.Length / meret + 1];
            }
            return darabok2;
        }

        private void Darabolas(string s, int meret, string[] dbk)
        {
            int counter = 0;

            while (s.Length > 0)
            {
                if (s.Length <= meret)
                {
                    dbk[counter] = s;
                    s = String.Empty;
                }
                else
                {
                    dbk[counter] = s.Substring(0, meret);
                    s = s.Substring(meret);
                }
                counter++;
            }
        }
    }
}
