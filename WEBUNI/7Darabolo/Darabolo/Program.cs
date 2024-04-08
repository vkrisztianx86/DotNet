string s;
int meret;
string[] darabok;

Bekeres(out s, out meret);
darabok = Meretezes(s, meret);
Darabolas(s, meret, darabok);
Kiiras(darabok);

static void Kiiras(string[] darabok)
{
    foreach (string darab in darabok)
    {
        Console.WriteLine(darab);
    }
}

static void Bekeres(out string sp, out int meretp)
{
    Console.WriteLine("Kérem a szöveget!");
    sp = Console.ReadLine();

    Console.WriteLine("Mérete?");

    while (!int.TryParse(Console.ReadLine(), out meretp))
    {
        Console.WriteLine("Nem jó a méret");
    }
}

static string[] Meretezes(string s, int meret)
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

static void Darabolas(string s, int meret, string[] dbk)
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