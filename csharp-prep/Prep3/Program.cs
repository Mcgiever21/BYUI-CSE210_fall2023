using System;

class Program
{
    static void Main(string[] args)
    {
        string input;
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("Do you want to play a guessing game? ");
        input = Console.ReadLine();
        if (input != "yes"){
            return;
            }
        else{
            Program.GuessingGame(input);
        }
        int a = 1;
        while (a == 1)
        {
            Console.WriteLine("would you like to play again?");
            input = Console.ReadLine();
            if (input != "yes"){
                return;
                }
            else{
                Program.GuessingGame(input);
            }
        }
        return;
    }
    static void GuessingGame(string input)
    {
        Console.WriteLine("I am going to pick a number between 1 and 50 \n You have 5 guesses to guess my number.");
        Random randomGenerator = new Random();
        int answer = randomGenerator.Next(1,50);
        int guesses = 5;
        do
        {
            Console.WriteLine("what is your guess? ");
            int guess = int.Parse(Console.ReadLine());
            guesses-=1;
            if (guess==answer){
                Console.WriteLine("Congratulations, You Win");
                return;
            }
            else if (guess>answer){
                Console.WriteLine("too high, guess again.");
                Console.WriteLine($"guesses left:{guesses}");
            }
            else if (guess<answer){
                Console.WriteLine("too low, Guess again.");
                Console.WriteLine($"guesses left:{guesses}");
            }
        }while (guesses>0);
        Console.WriteLine($"Sorry, out of guesses, I Win.\n The answer was {answer}");
        return;
    }
}