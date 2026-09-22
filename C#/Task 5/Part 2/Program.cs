using System;
using System.Linq;

namespace Task05_Part02
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1();
            Problem2();
            Problem3();
            Problem4();
            Problem5();
            Problem6();
            Problem7();
            Problem8();
        }

        #region Problem 1 - Print Numbers in a Range
        static void Problem1()
        {
            Console.WriteLine("=== Problem 1: Print Numbers in a Range ===");

            Console.Write("Enter a positive integer: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.Write(i);
                if (i != number) Console.Write(", ");
            }
            Console.WriteLine();

            Console.WriteLine();
        }
        #endregion

        #region Problem 2 - Display Multiplication Table
        static void Problem2()
        {
            Console.WriteLine("=== Problem 2: Display Multiplication Table ===");

            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.Write(number * i);
                if (i != 12) Console.Write(", ");
            }
            Console.WriteLine();

            Console.WriteLine();
        }
        #endregion

        #region Problem 3 - List Even Numbers
        static void Problem3()
        {
            Console.WriteLine("=== Problem 3: List Even Numbers ===");

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i);
                    if (i != number) Console.Write(", ");
                }
            }
            Console.WriteLine();

            Console.WriteLine();
        }
        #endregion

        #region Problem 4 - Compute Exponentiation
        static void Problem4()
        {
            Console.WriteLine("=== Problem 4: Compute Exponentiation ===");

            Console.Write("Enter the base number: ");
            int baseNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the exponent: ");
            int exponent = int.Parse(Console.ReadLine());

            long result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNumber;
            }

            Console.WriteLine($"{baseNumber}^{exponent} = {result}");

            Console.WriteLine();
        }
        #endregion

        #region Problem 5 - Reverse a Text String
        static void Problem5()
        {
            Console.WriteLine("=== Problem 5: Reverse a Text String ===");

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            char[] characters = input.ToCharArray();
            Array.Reverse(characters);
            string reversed = new string(characters);

            Console.WriteLine($"Reversed: {reversed}");

            Console.WriteLine();
        }
        #endregion

        #region Problem 6 - Reverse an Integer Value
        static void Problem6()
        {
            Console.WriteLine("=== Problem 6: Reverse an Integer Value ===");

            Console.Write("Enter an integer: ");
            string input = Console.ReadLine();

            // Reverse the digits as text, then convert back to an integer
            char[] digits = input.ToCharArray();
            Array.Reverse(digits);
            string reversedText = new string(digits);
            int reversedNumber = int.Parse(reversedText);

            Console.WriteLine($"Reversed: {reversedNumber}");

            Console.WriteLine();
        }
        #endregion

        #region Problem 7 - Find Longest Distance Between Matching Elements
        static void Problem7()
        {
            Console.WriteLine("=== Problem 7: Find Longest Distance Between Matching Elements ===");

            Console.Write("Enter the number of elements in the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxDistance = 0;

            // For every pair of equal elements, track the largest gap between their indices
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        int distance = j - i - 1; // number of cells between the two matching elements
                        if (distance > maxDistance)
                        {
                            maxDistance = distance;
                        }
                    }
                }
            }

            Console.WriteLine($"Longest distance between matching elements: {maxDistance}");

            Console.WriteLine();
        }
        #endregion

        #region Problem 8 - Reverse Words in a Sentence
        static void Problem8()
        {
            Console.WriteLine("=== Problem 8: Reverse Words in a Sentence ===");

            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');
            Array.Reverse(words);

            Console.WriteLine(string.Join(" ", words));

            Console.WriteLine();
        }
        #endregion
    }
}