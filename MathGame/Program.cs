Console.WriteLine("Please type your name");
var name = Console.ReadLine();
var date = DateTime.UtcNow;

Console.WriteLine("----------------------------------------------------------");
Console.WriteLine($"Hello {name}. It's {date.DayOfWeek}. This is your math's game. That's great that you're working on improving yourself!");
Console.WriteLine("\n");
Console.WriteLine($@"What game would you like to play today? Please choose from the options below:
A - Add
S - Sub
M - Mult
D - Div
Q - Quit the Prog");
Console.WriteLine("----------------------------------------------------------");
var gameSelected = Console.ReadLine();

if (gameSelected.Trim().ToLower() == "a")
{
    AdditionGame("Addition game selected");
}
else if (gameSelected.Trim().ToLower() == "s")
{
    SubtractionGame("Subtraction game selected");

}
else if (gameSelected.Trim().ToLower() == "m")
{
    MultiplicationGame("Multiplication game selected");
}
else if (gameSelected.Trim().ToLower() == "d")
{
    DivisionGame("Division game selected");
}
else if (gameSelected.Trim().ToLower() == "q")
{
    Console.WriteLine("Goodbye!");
    Environment.Exit(1);
}
else
{
    Console.WriteLine("Invalid input.");
}

void DivisionGame(string message)
{
    Console.WriteLine(message);
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);
}

void AdditionGame(string message)
{
    Console.WriteLine(message);

}
