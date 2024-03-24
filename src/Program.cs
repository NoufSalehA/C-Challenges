using System;

public
class Program
{
    public static void StringNumberProcessor(params object[] inputs)// Challenge 1: String and Number Processor

    {
        string connactionString = " ";
        int sum = 0;
        foreach (var input in inputs)
        {
            if (input is string)
            {
                connactionString += input + " ";

            }
            else
            {
                sum += (int)input;

            }

        }
        Console.WriteLine($"{connactionString} ; {sum}");


    }
    public static void SwapObjects(ref object obj1, ref object obj2)//Challenge 2: Object Swapper
    {
        if (obj1.GetType() != obj2.GetType())
        {
            Console.WriteLine("Error: Objects must be of the same type");
            return;
        }

        if (obj1 is int)
        {
            int num1 = (int)obj1;
            int num2 = (int)obj2;
            if (num1 > 18 && num2 > 18)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
                obj1 = num1;
                obj2 = num2;
            }
            else
            {
                Console.WriteLine("Error: Value must be more than 18");
            }
        }
        else if (obj1 is string)
        {
            string str1 = (string)obj1;
            string str2 = (string)obj2;

            if (str1.Length > 5 && str2.Length > 5)
            {
                string temp = str1;
                str1 = str2;
                str2 = temp;
                obj1 = str1;
                obj2 = str2;
            }
            else
            {
                Console.WriteLine("Error: Length must be more than 5");
            }
        }
        else
        {
            Console.WriteLine("Error: Unsupported type");
        }
    }


    public static void GuessingGame()//Challenge 3: Guessing Game

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

        // Challenge 4: Simple Word Reversal

        public static string ReverseWords(string sentence)
        {

            var WordReverse = string.Join(" ", sentence.Split(' ').Select(X => new string(X.Reverse().ToArray())));
            return WordReverse;

        }

        public static void Main(string[] args)

        {
            // Challenge 1: String and Number Processor
            Console.WriteLine("Challenge 1: String and Number Processor");
            StringNumberProcessor("Hello", 100, 200, "World"); // Expected outcome: "Hello World; 300"
                                                               
          //Challenge 2: Object Swapper     
            object num1 = 25, num2 = 30;
            SwapObjects(ref num1, ref num2);
            Console.WriteLine($"Values after swap: {num1}, {num2}");

            object str1 = (object)"HelloWorld", str2 = (object)"Programming"; // Casting strings to objects
            SwapObjects(ref str1, ref str2);
            Console.WriteLine($"Values after swap: {str1}, {str2}");

            object str3 = (object)"Hi", str4 = (object)"Programming"; // Casting strings to objects
            SwapObjects(ref str3, ref str4);

            object num3 = 10, num4 = 30;
            SwapObjects(ref num3, ref num4);

            object num5 = 10;
            object str5 = (object)"Hello"; // Casting string to object
            SwapObjects(ref num5, ref str5);

            object bool1 = true, bool2 = false;
            SwapObjects(ref bool1, ref bool2);


            //Challenge 3: Guessing Game
            // Uncomment to test the GuessingGame method
            // Expected outcome: User input until the correct number is guessed or user inputs `Quit`
            Console.WriteLine($"Welcome !\nChallenge 3: Guessing Game");
            GuessingGame();



            // Challenge 4: Simple Word Reversal
            Console.WriteLine("\nChallenge 4: Simple Word Reversal");
            string sentence = "This is the original sentence!";
            string reversed = ReverseWords(sentence);
            Console.WriteLine(reversed); // Expected outcome: "sihT si eht lanigiro !ecnetnes"



        }
    }
}