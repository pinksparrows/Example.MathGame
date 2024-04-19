Console.WriteLine("Please type your name");
var name = Console.ReadLine();
var date = DateTime.UtcNow;

Menu(name, date);

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

void Menu(string? name, DateTime date)
{
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

    switch (gameSelected.Trim().ToLower())
    {
        case "a":
            AdditionGame("Addition game selected");
            break;
        case "s":
            SubtractionGame("Subtraction game selected");
            break;
        case "m":
            MultiplicationGame("Multiplication game selected");
            break;
        case "d":
            DivisionGame("Division game selected");
            break;
        case "q":
            Console.WriteLine("Goodbye");
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Invalid input.");
            Environment.Exit(1);
            break;
    }
}