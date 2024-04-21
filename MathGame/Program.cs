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
    GetDivisionNumbers();

}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {


        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} * {secondNumber}");
        var result = Console.ReadLine();
        var score = 0;

        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect.");
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {


        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = Console.ReadLine();
        var score = 0;

        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect.");
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }
}

void AdditionGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++) 
    {

        
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();
        var score = 0;

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect.");
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }
}


int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(0, 99);
    var secondNumber = random.Next(0, 99);

    var result = new int[2];

    result[0] = firstNumber;
    result[1] = secondNumber;


    return result;
}