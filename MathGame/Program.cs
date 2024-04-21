var date = DateTime.UtcNow;

string? name = GetName();

Menu(name);

string GetName()
{
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine();
    return name;
}

void Menu(string name)
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
    var random = new Random();
    int firstNumber = random.Next(1, 9);
    int secondNumber = random.Next(1, 9);

    Console.WriteLine($"{firstNumber} - {secondNumber}");
    var result = Console.ReadLine();

    if (int.Parse(result) == firstNumber - secondNumber)
    {
        Console.WriteLine("Correct!");
    }
    else
    {
        Console.WriteLine("Incorrect.");
    }
}

void AdditionGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    int firstNumber = random.Next(1, 9);
    int secondNumber = random.Next(1, 9);

    Console.WriteLine($"{firstNumber} + {secondNumber}");
    var result = Console.ReadLine();

    if (int.Parse(result) == firstNumber + secondNumber)
    {
        Console.WriteLine("Correct!");
    } else
    {
        Console.WriteLine("Incorrect.");
    }

}


