using System;

namespace Building_a_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)  // We use a while loop if we can keep doing something repeatedly until a condition is false.
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;  //Is going to tell us if the user is out of guesses.  If the users still has guesses left, it will be equal to false.  If the user is out of guesses it will be equal to true.

            while(guess != secretWord && !outOfGuesses) // We want the code to keep looping if the user has not guessed the secret word and they're not out of guesses.
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter Guess: ");
                    guess = Console.ReadLine(); // Stores the users guess inside the guess vairable and keep checking it everytime we go through the loop.
                    guessCount++;
                }
                else 
                {
                    outOfGuesses = true; // Means the user is out of guesses.  Sometimes people call this statement a flag or boolean flag.
                }

            }
            if (outOfGuesses)
            {
                Console.Write("You Lose!");
            }
            else 
            {
                Console.Write("You Win!");
            }

        }
    }
}
