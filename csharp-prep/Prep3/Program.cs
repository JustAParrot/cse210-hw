using System;

class Program
{
    static void Main(string[] args)
    {
        // Set the magic number
        Random random = new Random();
        int magic_number;
        int guess;

        Console.Write("Enter the magic number: ");
        magic_number = Convert.ToInt32(Console.ReadLine());

        // Loop until the user guesses the magic number
        do
        {
            Console.Write("Enter your guess: ");
            guess = Convert.ToInt32(Console.ReadLine());

            // Check if the guess is higher, lower, or correct
            if (guess < magic_number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magic_number);

        Console.WriteLine("Congratulations! You guessed the magic number.");

        // Stretch Challenge: Keep track of the number of guesses
        int number_of_guesses = 1;
        while (true)
        {
            Console.Write("Do you want to play again? (yes/no): ");
            string play_again = Console.ReadLine().ToLower();

            if (play_again != "yes")
            {
                break;
            }

            magic_number = random.Next(1, 101);
            number_of_guesses = 1;

            do
            {
                Console.Write("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess < magic_number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magic_number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

                number_of_guesses++; // Increment the number of guesses
            } while (guess != magic_number);

            Console.WriteLine($"Congratulations! You guessed the magic number in {number_of_guesses} guesses.");
        }
    }
}
