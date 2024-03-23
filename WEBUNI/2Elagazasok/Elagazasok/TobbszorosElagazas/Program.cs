

Console.ForegroundColor = ConsoleColor.Blue;

switch (Console.ForegroundColor)
{
    case ConsoleColor.Green:
        Console.WriteLine("Zölddel írok");
        break;
    case ConsoleColor.Red:
        Console.WriteLine("Pirossal írok");
        break;
    default:
        Console.WriteLine("Ezt a színt nem ismerem");
        break;
}