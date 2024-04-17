Console.WriteLine("Please type your name");
var name = Console.ReadLine();
var date = DateTime.UtcNow;

Console.WriteLine("----------------------------------------------------------");
Console.WriteLine($"Hello {name}. It's {date.DayOfWeek}. This is your math's game. That's great that you're working on improving yourself!");
Console.WriteLine("\n");
var gameSelected = Console.ReadLine();
