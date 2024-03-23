
// CTRL + K + C

//for (int i = 32; i < 1024; i++)
//{
//    Console.WriteLine($"{i} - {(char)i}");
//}

//int j = 1;

//do
//{
//    Console.WriteLine("{0} * {1} = {2}", j, 7, j*7);
//    j++;
//} while (j<11);

//int k = 1;

//while (k<11)
//{
//    Console.WriteLine("{0} * {1} = {2}", k, 7, k * 7);
//    k++;
//}


// F12
foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
{
    Console.ForegroundColor = color;
    Console.BackgroundColor = 15 - color;
    Console.WriteLine("Hello világ!");
}

Console.BackgroundColor = ConsoleColor.Black;
