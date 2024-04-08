Console.WriteLine("Kérem a szöveget!");
string s = Console.ReadLine();

Console.WriteLine("Kérem a darabolási méretet!");
int size;
int counter = 0;    

while(!int.TryParse(Console.ReadLine(), out size))
{
    Console.WriteLine("Számot kell írni!");
}


string[] parts; 

if(s.Length % size == 0)
{
    parts = new string[s.Length / size];
}
else
{
    parts = new string[s.Length / size + 1];
}

while(s.Length > 0)
{
    if(s.Length <= size)
    {
        parts[counter] = s;
        s = String.Empty;
    }
    else
    {
        parts[counter] = s.Substring(0, size);
        s = s.Substring(size);
    }
    counter++;  
}

