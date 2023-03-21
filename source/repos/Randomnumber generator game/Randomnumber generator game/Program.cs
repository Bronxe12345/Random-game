Random random = new Random();
int randomNumber = random.Next(1, 10);
int Count = 0;

while (Count < 3)
{
    Console.Write("Guess the number (between 1 and 9): ");
    string guessString = Console.ReadLine();
    int guess;// Declare an integer variable guess to store the user's guess after it is parsed from guessString

    if (int.TryParse(guessString, out guess))// Try to parse the user's guess from guessString to an integer and store it in guess variable.
    {
        Count++;

        if (guess == randomNumber)
        {
            Console.WriteLine("Congratulations!");
            break;
        }
        else if (guess < randomNumber)
        {
            Console.WriteLine("Number is too low!");
        }
        else
        {
            Console.WriteLine("Number is too high");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
    }
}

Console.WriteLine($"The number was {randomNumber}.");
Console.WriteLine("Press any key to exit.");
Console.ReadKey();
