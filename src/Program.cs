using System;

namespace FunctionChallenges
{
    class Program
    {
        public static void StringNumberProcessor(params object[] inputs)
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
        static void Main(string[] args)
        {
            // Challenge 1: String and Number Processor
            Console.WriteLine("Challenge 1: String and Number Processor");
            StringNumberProcessor("Hello", 100, 200, "World"); // Expected outcome: "Hello World; 300"

            
        }
    }
}
