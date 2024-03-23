foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
{
    Console.ForegroundColor = color;
    Console.WriteLine("Hello, World!");
}