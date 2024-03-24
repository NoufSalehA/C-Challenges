using System;

public class Program
{
    public static void SwapObjects(ref object obj1, ref object obj2)
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

    public static void Main(string[] args)
    {
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
    }
}
