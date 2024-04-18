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
    AdditionGame();
}
else if (gameSelected.Trim().ToLower() == "s")
{
    SubtractionGame();

}
else if (gameSelected.Trim().ToLower() == "m")
{
    MultiplicationGame();
}
else if (gameSelected.Trim().ToLower() == "d")
{
    DivisionGame();
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

void DivisionGame()
{
    Console.WriteLine("Division game selected");
}

void MultiplicationGame()
{
    Console.WriteLine("Multiplication game selected");
}

void SubtractionGame()
{
    Console.WriteLine("Subtraction game selected");
}

void AdditionGame()
{
    Console.WriteLine("Addition game selected.");

}
