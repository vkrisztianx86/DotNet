
bool b = true;

int x = 123;

string s = "alma";

int[] xek = new int[3] { 1, 2, 3 };


Console.WriteLine(b);
Console.WriteLine(x);
Console.WriteLine(s);
Console.WriteLine(xek[0]);
Console.WriteLine(xek[1]);
Console.WriteLine(xek[2]);

Valtoztato(b, x, s, xek);

Console.WriteLine(b);
Console.WriteLine(x);
Console.WriteLine(s);
Console.WriteLine(xek[0]);
Console.WriteLine(xek[1]);
Console.WriteLine(xek[2]);



static void Valtoztato(bool b1, int x1, string s1, int[] xek1)
{
    b1 = false;
    x1 = 321;
    s1 = " Körte";
    xek1[1] = 88;
}