using System;

namespace FunctionChallenges
{
    class Program
    {

        public static void GuessingGame()
        {

            Random random = new Random();
            int randomNumber = random.Next(1, 1000);
            int guesses = 0;
            bool isItCorecct = false;

            while (!isItCorecct)//true
            {
                Console.WriteLine("Enter a number from (1-1000), type quit to exit");
                string input = Console.ReadLine() ?? "";

                if (input != null)
                {

                    if (input.ToLower() == "quit")
                    {
                        Console.WriteLine("===============Quit The Game============");
                        break;

                    }
                }
                try
                {

                    if (int.TryParse(input, out int guess))
                    {
                        guesses++;


                        if (guess == randomNumber)
                        {

                            Console.WriteLine("****You guessed the right number !****");
                            isItCorecct = true;


                        }
                        else if (guess < randomNumber)
                        {

                            Console.WriteLine("===Too small!===");

                        }
                        else if (guess > randomNumber)
                        {
                            Console.WriteLine("===Too Big!===");

                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Invalid Value :{e.Message}");

                }

            }


        }
        static void Main(string[] args)
        {

            //Challenge 3: Guessing Game
            // Uncomment to test the GuessingGame method
            // Expected outcome: User input until the correct number is guessed or user inputs `Quit`
            Console.WriteLine($"Welcome !\nChallenge 3: Guessing Game");
            GuessingGame();


        }
    }
}
