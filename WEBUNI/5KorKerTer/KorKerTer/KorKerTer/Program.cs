

 void calc()
{
    Console.WriteLine("Kérem egy kör sugarát (egész számot kérek!):");
    int r = 0;

    while (!int.TryParse(Console.ReadLine(), out r))
    {
        Console.WriteLine("Nem jó szám, másikat kérek");
    }
    //if (int.TryParse(Console.ReadLine(), out r))
    //{
    //    Console.WriteLine("Sikeres, számolok");
    //}
    //else
    //{
    //    Console.WriteLine("ajajj, nem számolok....");
    //}

    // r = int.Parse(Console.ReadLine());

    double ker = 2 * r * Math.PI;
    double ter = Math.Pow(r, 2) * Math.PI;

    Console.WriteLine(ker);
    Console.WriteLine(ter);

    Console.WriteLine("Szeretnél újabb számítást? i/n");
    if (Console.ReadLine() == "i")
    {
        calc();
    }
    else
    {
        Console.WriteLine("Program vége, nyomj meg egy tetszőleges billentyűt.");
    }
}
calc();
Console.ReadLine();