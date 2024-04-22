using System;
using System.Threading.Tasks.Sources;
using static System.Formats.Asn1.AsnWriter;

var date = DateTime.UtcNow;

var games = new List<string>();


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

    var isGameOn = true;

    do
    {
        Console.Clear();
        Console.WriteLine($@"What game would you like to play today? Please choose from the options below:
V - View Previous Games
A - Add
S - Sub
M - Mult
D - Div
Q - Quit the Prog");
        Console.WriteLine("----------------------------------------------------------");
        var gameSelected = Console.ReadLine();

        switch (gameSelected.Trim().ToLower())
        {
            case "v":
                GetGames();
                break;
            case "a":
                AdditionGame("Addition game");
                break;
            case "s":
                SubtractionGame("Subtraction game");
                break;
            case "m":
                MultiplicationGame("Multiplication game");
                break;
            case "d":
                DivisionGame("Division game");
                break;
            case "q":
                Console.WriteLine("Goodbye");
                isGameOn = false;
                break;
            default:
                Console.WriteLine("Invalid input.");
                break;
        }
    } while (isGameOn);

    
}

void GetGames()
{
    Console.Clear();
    Console.WriteLine("Games History:");
    Console.WriteLine("----------------------------------------------------------");
    foreach (var game in games)
    {
        Console.WriteLine(game);
    }
    Console.WriteLine("----------------------------------------------------------\n");
    Console.WriteLine("Press any key to return to the Main Menu");
    Console.ReadLine();
}

void DivisionGame(string message)
{
    var score = 0;

    for (int  i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Correct! Type any key for the next question!");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Incorrect. Type any key for the next question!");
            Console.ReadLine();
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }

}

void MultiplicationGame(string message)
{
    

    var random = new Random();

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} * {secondNumber}");
        var result = Console.ReadLine();
        var score = 0;

        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("Correct! Type any key for the next question!");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Incorrect. Type any key for the next question!");
            Console.ReadLine();
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }
}

void SubtractionGame(string message)
{
    

    var random = new Random();

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = Console.ReadLine();
        var score = 0;

        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("Correct! Type any key for the next question!");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Incorrect. Type any key for the next question!");
            Console.ReadLine();
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }
}

void AdditionGame(string message)
{
    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++) 
    {
        Console.Clear();
        Console.WriteLine(message);

        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Correct! Type any key for the next question!");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Incorrect. Type any key for the next question!");
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the menu.");
            Console.ReadLine();
        }

        }

    AddToHistory(score, "Addition");

    games.Add($"{DateTime.Now} - Addition: Score={score}");
    }

void AddToHistory(int score, string v)
{
    throw new NotImplementedException();
}

int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(0, 99);
    var secondNumber = random.Next(0, 99);

    var result = new int[2];

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    

    return result;
}