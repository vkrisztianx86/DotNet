using System.Text; //CTRL + .

// CTRL + K + D
int[] xek = new int[4] { 22, 55, 23, 9 };

foreach (int i in xek)
{
    Console.WriteLine(i);
}


Console.WriteLine("---");

List<int> xek2 = new List<int>();
xek2.Add(22);
xek2.Add(66);

foreach (int i in xek2)
{
    Console.WriteLine(i);
}

// xek[0] = 11;

Dictionary<string, string> angolMagyar = new Dictionary<string, string>();

angolMagyar.Add("Dog", "Kutya");
angolMagyar.Add("Cat", "Macska");

Dictionary<string, List<string>> RealAngolMagyar = new Dictionary<string, List<string>>();

List<string> forditasok = new List<string>();
forditasok.Add("Wait");
forditasok.Add("Castle");

RealAngolMagyar.Add("Vár", forditasok);

foreach (KeyValuePair<string, string> szo in angolMagyar)
{
    Console.WriteLine($"{szo.Key} - {szo.Value}");
}

// CTRL + .
StringBuilder stringBuilder = new StringBuilder();


//string ak = string.Empty;
//for (int i = 0; i < 100000; i++)
//{
//    ak += 'a';
//}

for (int i = 0; i < 100000; i++)
{
    stringBuilder.Append("a");
}


Console.WriteLine("kész");

Console.WriteLine(int.MaxValue);
Console.WriteLine(double.MaxValue);

