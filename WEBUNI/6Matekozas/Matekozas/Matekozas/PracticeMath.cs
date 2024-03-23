


using System;
using System.Linq;
using System.Reflection.PortableExecutable;
namespace Classof;

//namespace Math_task;

public static class Program
{
    public static void Main()
    {
        Reader reader = new Reader();
        Random random = new Random();
        string draw = "";
        string draw2 = "";
        string top = "";
        int task = 0;
        int x = 0;
        int y = 0;
        int z = 0;
        int scores = 0;
        int count = 0;
        int gamercounter = 0;
        int whiler = 0;

        string cont = "";
        string nam = "";

        Dictionary<string, int> names = new Dictionary<string, int>();

        Console.WriteLine("Matek feladat");
        Console.WriteLine("‐‐--‐--------------‐--");
        do
        {
            Console.Write("Add meg a neved: ");
            string name = Console.ReadLine();

            if (!names.ContainsKey(name))
            {
                names.Add(name, 0);
                whiler++;
                Console.Write($"Kedves {name}, Te még nem játszottál, de most hozzáadtalak a játékosokhoz! Max 2 játékos játszhat! " +
                    $"Még {2 - whiler} jöhet. Ha meglátod a műveletet, onnantól 10 másodperced van válaszolni. Jó játékot kívánok! ");
                //Thread.Sleep(10000);
            }
            else
            {
                Console.Write($"Kedves {name}, üdvözöllek újra itt, ismét jó játékot kívánok! ");
            }
            Console.WriteLine("Add meg az eredményt: ");

            task = random.Next(1, 4);
            x = random.Next(0, 25);
            y = random.Next(0, 25);

            switch (task)
            {
                case 1:
                    add(x, y, out z);
                    break;

                case 2:
                    deduct(x, y, out z);
                    break;

                case 3:
                    multiply(x, y, out z);
                    break;
                default:
                    break;
            }
            int tip = 0;
            try
            {
                while (!int.TryParse(Reader.ReadLine(10000), out tip))
                {
                    Console.WriteLine("Az eredmény csak szám lehet");
                }
            }
            catch (TimeoutException)
            {
                Console.WriteLine("Időtúllépés! Játék vége...");
                names[name]--;
                break;
            }

            if (tip == z)
            {
                Console.WriteLine("Talált!");
                names[name]++;
            }
            else
            {
                Console.WriteLine("Rossz válasz!");
            }
            Console.Write("Folytatod a játékot? i/n: ");
            if (names.Count > 2)
            {
                Console.WriteLine("Több játékos nem játszhat!");
                names.Remove(name);
                break;
            }
            cont = Console.ReadLine();

        } while (cont != "n");


        Console.WriteLine("Végeredmény:");
        foreach (KeyValuePair<string, int> item in names)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
        var winner = names.MaxBy(entry => entry.Value);

        foreach (KeyValuePair<string, int> item in names)
        {
            if (item.Value.Equals(winner.Value))
            {
                count++;
                draw = item.Key;
                draw2 = winner.Key;
            }
        }
        if (count > 1)
        {
            Console.WriteLine($"Döntetlen {draw}-nek és {draw2}-nek");
        }
        else
        {
            Console.WriteLine($"A győztes nem más, mint: {names.MaxBy(entry => entry.Value).Key}");
            //Console.WriteLine(count);
        }

        void add(int x, int y, out int z)
        {
            Console.WriteLine($"{x} + {y}");
            z = x + y;
        }
        void deduct(int x, int y, out int z)
        {
            Console.WriteLine($"{x} - {y}");
            z = x - y;
        }
        void multiply(int x, int y, out int z)
        {
            Console.WriteLine($"{x} * {y}");
            z = x * y;
        }


    }
}