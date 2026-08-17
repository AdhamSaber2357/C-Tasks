using System;

namespace DEPI
{
    class Person
    {
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 01
            ///*
            //This program demonstrates how to add two integer numbers.
            //It initializes two variables, calculates their sum, 
            //and prints the result to the console.
            //*/

            //// Initialize the first integer variable
            //int x = 10;

            //// Initialize the second integer variable
            //int y = 20;

            //// Calculate the sum of x and y
            //int sum = x + y;

            //// Display the calculated sum on the console
            //Console.WriteLine(sum);
            #endregion

            #region Problem 02
            // Errors:
            //   1) "10" is a string literal, but x is declared as int
            //      -> type mismatch (cannot implicitly convert string to int).
            //   2) "console" should be "Console" (capital C) - C# is case sensitive.
            //   3) "y" is used but never declared.

            // Fixed code:

            //int x = 10;         // Fixed: use an integer literal, not a string
            //int y = 5;          // Fixed: declare y before using it
            //Console.WriteLine(x + y); // Fixed: capital "Console"
            #endregion

            #region Problem 03
            //string FullName = "Ahmed Mohamed";  // Stores the person's full name
            //int Age = 21;                       // Stores the person's age
            //double MonthlySalary = 8500.50;     // Stores the person's monthly salary
            //bool IsStudent = true;              // Indicates whether the person is a student

            //Console.WriteLine($"Full Name: {FullName}");
            //Console.WriteLine($"Age: {Age}");
            //Console.WriteLine($"Monthly Salary: {MonthlySalary}");
            //Console.WriteLine($"Is Student: {IsStudent}");

            #endregion

            #region Problem 04
            //Console.WriteLine("=== Problem 4: Reference Type Demo ===");

            //Person person1 = new Person();
            //person1.Name = "Sara";

            //// person2 now points to the SAME object as person1
            //Person person2 = person1;

            //Console.WriteLine($"Before change -> person1: {person1.Name}, person2: {person2.Name}");

            //// Changing the Name through person2 also affects person1,
            //// because both variables reference the same object in memory
            //person2.Name = "Mona";

            //Console.WriteLine($"After change  -> person1: {person1.Name}, person2: {person2.Name}");
            #endregion

            #region Problem 05
            //int x = 15;
            //int y = 4;

            //int sum = x + y;
            //int difference = x - y;
            //int product = x * y;
            //double divisionResult = (double)x / y; // cast to double for a precise result
            //int remainder = x % y;

            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Difference: {difference}");
            //Console.WriteLine($"Product: {product}");
            //Console.WriteLine($"Division Result: {divisionResult}");
            //Console.WriteLine($"Remainder: {remainder}");
            #endregion

            #region Problem 06
            //int number = 24; // sample input

            //bool isGreaterThan10 = number > 10;
            //bool isEven = number % 2 == 0;

            //if (isGreaterThan10 && isEven)
            //{
            //    Console.WriteLine($"{number} is greater than 10 and even.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} does not satisfy both conditions.");
            //}
            #endregion

            #region Problem 07
            //Console.Write("Enter a decimal number: ");
            //double doubleValue = Convert.ToDouble(Console.ReadLine());

            //// Explicit casting: required because converting double -> int
            //// can lose data (the fractional part), so C# forces you to
            //// acknowledge that with an explicit cast.
            //int explicitCast = (int)doubleValue;

            //// Implicit casting example (widening, safe, no data loss):
            //// going from int back up to double happens automatically.
            //double implicitCast = explicitCast;

            //Console.WriteLine($"Original double value: {doubleValue}");
            //Console.WriteLine($"Explicitly cast to int: {explicitCast}");
            //Console.WriteLine($"Implicitly cast back to double: {implicitCast}");
            #endregion

            #region Problem 08
            //Console.Write("Enter your age: ");
            //string ageInput = Console.ReadLine();

            //try
            //{
            //    int age = int.Parse(ageInput); // Throws FormatException if input is not numeric

            //    if (age > 0)
            //    {
            //        Console.WriteLine($"Valid age entered: {age}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Age must be greater than 0.");
            //    }
            //}
            //catch (FormatException)
            //{
            //    // Thrown when the input string is not in a valid numeric format
            //    Console.WriteLine("Invalid input: please enter numeric digits only.");
            //}
            //catch (OverflowException)
            //{
            //    // Thrown when the number is too large/small for an int
            //    Console.WriteLine("Invalid input: the number entered is out of range.");
            //}
            #endregion

            #region Problem 09
            //int x = 5;

            //// Postfix: uses the CURRENT value of x, then increments x afterward
            //int postfixResult = x++;
            //Console.WriteLine($"Postfix -> x++ returned {postfixResult}, x is now {x}");

            //x = 5; // reset for a clean comparison
            //// Prefix: increments x FIRST, then uses the new value
            //int prefixResult = ++x;
            //Console.WriteLine($"Prefix  -> ++x returned {prefixResult}, x is now {x}");
            #endregion

        }
    }
}
