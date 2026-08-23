using System;
using System.Text;

namespace DEPI
{
    class Box
    {
        public int Value;

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Problem 01
            //Console.Write("Enter a whole number: ");
            //string input = Console.ReadLine();

            //try
            //{
            //    int parsedValue = int.Parse(input);       
            //    int convertedValue = Convert.ToInt32(input); 

            //    Console.WriteLine($"int.Parse result: {parsedValue}");
            //    Console.WriteLine($"Convert.ToInt32 result: {convertedValue}");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid input: the text entered is not a valid number.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Invalid input: the number entered is out of range for an int.");
            //}

            //Console.WriteLine();


            #endregion

            #region Problem 02
            //Console.Write("Enter a number: ");
            //string input = Console.ReadLine();

            //bool isValid = int.TryParse(input, out int number);

            //if (isValid)
            //{
            //    Console.WriteLine($"Valid number entered: {number}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: the input is not a valid integer.");
            //}

            //Console.WriteLine();
            #endregion

            #region Problem 03
            //object obj = 42; // int
            //Console.WriteLine($"int value: {obj}, HashCode: {obj.GetHashCode()}");

            //obj = "Hello"; // string
            //Console.WriteLine($"string value: {obj}, HashCode: {obj.GetHashCode()}");

            //obj = 3.14; // double
            //Console.WriteLine($"double value: {obj}, HashCode: {obj.GetHashCode()}");

            //Console.WriteLine();

            #endregion

            #region Problem 04
            //Box box1 = new Box();     // Create an object and assign it a value
            //box1.Value = 10;

            //Box box2 = box1;          // Create a second reference to the same object

            //box2.Value = 99;          // Modify the value using one reference

            //Console.WriteLine($"box1.Value: {box1.Value}"); // Print the value using the other reference
            //Console.WriteLine($"box2.Value: {box2.Value}");
            //Console.WriteLine($"ReferenceEquals(box1, box2): {ReferenceEquals(box1, box2)}");

            //Console.WriteLine();
            #endregion

            #region Problem 05
            //string text = "Hello";
            //Console.WriteLine($"Before modification: \"{text}\", HashCode: {text.GetHashCode()}");

            //text = text + " Hi Willy"; // Creates a brand-new string object; the original is unchanged
            //Console.WriteLine($"After modification: \"{text}\", HashCode: {text.GetHashCode()}");

            //Console.WriteLine();

            #endregion

            #region Problem 06
            //StringBuilder sb = new StringBuilder("Hello");
            //Console.WriteLine($"Before modification: \"{sb}\", HashCode: {sb.GetHashCode()}");

            //sb.Append(" Hi Willy"); // Modifies the SAME StringBuilder instance in place
            //Console.WriteLine($"After modification: \"{sb}\", HashCode: {sb.GetHashCode()}");

            //Console.WriteLine();
            #endregion

            #region Problem 07
            Console.Write("Enter the first integer: ");
            int input1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int input2 = int.Parse(Console.ReadLine());

            int sum = input1 + input2;

            // 1) Concatenation using the + operator
            string concatResult = "Sum is " + (input1 + input2);
            Console.WriteLine(concatResult);

            // 2) Composite formatting using string.Format
            string formatResult = string.Format("Sum is {0}", sum);
            Console.WriteLine(formatResult);

            // 3) String interpolation using $
            string interpolationResult = $"Sum is {sum}";
            Console.WriteLine(interpolationResult);

            Console.WriteLine();
            #endregion

            #region Problem 08
            //StringBuilder sb = new StringBuilder("Hello World");
            //Console.WriteLine($"Initial: \"{sb}\"");

            //sb.Append("!!!"); // Append text
            //Console.WriteLine($"After Append: \"{sb}\"");

            //sb.Replace("World", "C#"); // Replace a substring
            //Console.WriteLine($"After Replace: \"{sb}\"");

            //sb.Insert(0, "Say: "); // Insert a string at a specific position
            //Console.WriteLine($"After Insert: \"{sb}\"");

            //sb.Remove(0, 5); // Remove a portion of text ("Say: ")
            //Console.WriteLine($"After Remove: \"{sb}\"");
            #endregion


        }
}
}

