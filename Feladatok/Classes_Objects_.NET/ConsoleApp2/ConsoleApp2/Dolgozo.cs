namespace ConsoleApp2
{
    public abstract class Dolgozo : IJelszo
    {
        public int Hianyzas { get; set; }
        public string Nev { get; set; }
        public string Jelszo { get; set; }
        public bool Belepett { get; set; }

        public void Belepes(string tipp)
        {
            if (tipp == Jelszo)
            {
                Belepett = true;
                Console.WriteLine($"Belépett a {Nev} nevű dolgozó");
                Console.WriteLine($"A továbblépéshez nyomjon meg egy tetszőleges gombot!");
                Console.ReadKey();
            }
            else{
                Console.WriteLine($"Jelszó nem megfelelő a {Nev} nevű dolgozóhoz");
                Console.WriteLine($"A továbblépéshez nyomjon meg egy tetszőleges gombot!");
                Console.ReadKey();
            }
                
        }

        public virtual void Eredmeny() { }

        public override string ToString()
        {
            return Nev;
        }
    }
}
