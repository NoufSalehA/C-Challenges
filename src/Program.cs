using System;

namespace FunctionChallenges
{
    class Program
    {
        public static string ReverseWords(string sentence)
        {

      var WordReverse=string.Join(" ",sentence.Split(' ').Select(X=>new string(X.Reverse().ToArray())));
      return WordReverse;

        }

        static void Main(string[] args)
        {
            // Challenge 4: Simple Word Reversal
            Console.WriteLine("\nChallenge 4: Simple Word Reversal");
            string sentence = "This is the original sentence!";
            string reversed = ReverseWords(sentence);
            Console.WriteLine(reversed); // Expected outcome: "sihT si eht lanigiro !ecnetnes"



        }
    }

}