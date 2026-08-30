using System;
using System.Text;

namespace DEPI
{

    enum Day
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }
    internal class Program


    {


        public static void SumAndMultiply(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }

        public static void PrintMessage(string message, int count = 5)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}: {message}");
            }
        }

        public static int SumArray(params int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum;
        }


        static void Main(string[] args)
        {
            #region Problem 1
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //try
            //{
            //    int res = x / y;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{ Console.WriteLine("Operation complete"); }

            #endregion

            #region Problem 2
            //try
            //{
            //    Console.Write("Enter X (positive integer): ");
            //    int x = int.Parse(Console.ReadLine()!);

            //    Console.Write("Enter Y (integer greater than 1): ");
            //    int y = int.Parse(Console.ReadLine()!);

            //    if (x <= 0)
            //    {
            //        throw new ArgumentOutOfRangeException(nameof(x), "X must be a positive integer (greater than 0).");
            //    }

            //    if (y <= 1)
            //    {
            //        throw new ArgumentOutOfRangeException(nameof(y), "Y must be greater than 1.");
            //    }

            //    Console.WriteLine($"\nSuccess! Inputs are valid: X = {x}, Y = {y}");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("\nError: Please enter valid integers only.");
            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    Console.WriteLine($"\nInput Error: {ex.Message}");
            //}

            #endregion

            #region Problem 3


            //int? nullableInt = null;

            //int result = nullableInt ?? 100;
            //Console.WriteLine($"Result using (??) operator: {result}"); // Prints: 100

            //Console.WriteLine("\n--------------------------------------------------\n");

            //Console.WriteLine("--- Case 1: Variable is NULL ---");
            //Console.WriteLine($"HasValue: {nullableInt.HasValue}"); // Prints: False

            //if (nullableInt.HasValue)
            //{
            //    Console.WriteLine($"Value: {nullableInt.Value}");
            //}
            //else
            //{
            //    Console.WriteLine("Value: Cannot access .Value directly because the variable is null!");
            //}

            //Console.WriteLine("\n--- Case 2: Variable has a VALUE ---");
            //nullableInt = 42;

            //Console.WriteLine($"HasValue: {nullableInt.HasValue}"); // Prints: True
            //if (nullableInt.HasValue)
            //{
            //    Console.WriteLine($"Value: {nullableInt.Value}");   // Prints: 42
            //}

            #endregion

            #region Problem 4
            //try
            //{
            //    int[] numbers = new int[5] { 10, 20, 30, 40, 50 };
            //    Console.WriteLine("Attempting to access index 10...");

            //    // 2. Try accessing an index out of bounds
            //    int value = numbers[10];

            //    // This line won't execute because the exception is thrown above
            //    Console.WriteLine($"Value at index 10: {value}");
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    // Handling the exception cleanly
            //    Console.WriteLine("\n[Exception Caught]");
            //    Console.WriteLine($"Error: Index was outside the bounds of the array.");
            //    Console.WriteLine($"Message details: {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("\nProgram execution completed safely.");
            //}
            #endregion

            #region Problem 5
            //int[,] matrix = new int[3, 3];

            //Console.WriteLine("Enter elements for a 3x3 matrix:");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Element [{i},{j}]: ");
            //        matrix[i, j] = int.Parse(Console.ReadLine()!);
            //    }
            //}

            //Console.WriteLine("\n--------------------------------------------------");

            //Console.WriteLine("\n--- Row Sums ---");
            //for (int i = 0; i < 3; i++)
            //{
            //    int rowSum = 0;
            //    for (int j = 0; j < 3; j++)
            //    {
            //        rowSum += matrix[i, j];
            //    }
            //    Console.WriteLine($"Sum of Row {i + 1}: {rowSum}");
            //}

            //Console.WriteLine("\n--- Column Sums ---");
            //for (int j = 0; j < 3; j++)
            //{
            //    int colSum = 0;
            //    for (int i = 0; i < 3; i++)
            //    {
            //        colSum += matrix[i, j];
            //    }
            //    Console.WriteLine($"Sum of Column {j + 1}: {colSum}");

            #endregion


            #region Problem 6
            //int[][] jaggedArray = new int[3][];

            //// Define varying sizes for each row
            //jaggedArray[0] = new int[2]; // Row 0 has 2 elements
            //jaggedArray[1] = new int[4]; // Row 1 has 4 elements
            //jaggedArray[2] = new int[3]; // Row 2 has 3 elements

            //// 2. Populate each row with user input
            //Console.WriteLine("--- Populate Jagged Array ---");
            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    Console.WriteLine($"\nEntering values for Row {i + 1} (Size: {jaggedArray[i].Length}):");
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write($"Element [{i}][{j}]: ");
            //        jaggedArray[i][j] = int.Parse(Console.ReadLine()!);
            //    }
            //}

            //Console.WriteLine("\n--------------------------------------------------\n");

            //// 3. Print all values row by row
            //Console.WriteLine("--- Printing Jagged Array Row by Row ---");
            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    Console.Write($"Row {i + 1}: ");
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write($"{jaggedArray[i][j]} ");
            //    }
            //    Console.WriteLine(); // New line after printing each row
            //}
            #endregion




            #region Problem 7

            //string? userInput = null;

            //Console.Write("Do you want to enter a name? (yes/no): ");
            //string response = Console.ReadLine()?.Trim().ToLower() ?? "";

            //// 2. Assign it a value conditionally based on user input
            //if (response == "yes")
            //{
            //    Console.Write("Enter your name: ");
            //    userInput = Console.ReadLine();
            //}

            //// 3. Using the null-forgiveness operator (!) to suppress compiler warnings
            //// We know business logic guarantees userInput is not null inside this check,
            //// so we use ! to tell the compiler: "Trust me, this is not null."
            //if (userInput != null)
            //{
            //    string nonNullName = userInput!;
            //    Console.WriteLine($"\nHello, {nonNullName.ToUpper()}! Length: {nonNullName.Length}");
            //}
            //else
            //{
            //    Console.WriteLine("\nNo name was provided (userInput is null).");
            //}
            #endregion

            #region Problem 8


            //int num = 42;
            //object boxedNum = num; // Value type is copied to the Heap
            //Console.WriteLine($"Boxed Object Value: {boxedNum}");

            //Console.WriteLine("\n--------------------------------------------------\n");

            //// 2. Successful Unboxing: Extracting the exact value type (int) from the object
            //int unboxedNum = (int)boxedNum;
            //Console.WriteLine($"Successfully Unboxed Int: {unboxedNum}");

            //Console.WriteLine("\n--------------------------------------------------\n");

            //// 3. Invalid Unboxing: Attempting to unbox to an incompatible type (double)
            //try
            //{
            //    Console.WriteLine("Attempting to unbox object to (double)...");

            //    // This throws InvalidCastException because boxedNum contains an int, not a double
            //    double invalidUnboxed = (double)boxedNum;

            //    Console.WriteLine($"Unboxed Double: {invalidUnboxed}");
            //}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine("\n[Exception Caught]");
            //    Console.WriteLine($"Error: {ex.Message}");
            //    Console.WriteLine("Tip: Unboxing requires an explicit cast to the exact underlying type!");
            //}

            #endregion

            #region Problem 9

            //int x = 5;
            //int y = 4;

            //// 2. Calling the method with out parameters
            //SumAndMultiply(x, y, out int totalSum, out int totalProduct);

            //// Printing the results
            //Console.WriteLine($"Inputs: X = {x}, Y = {y}");
            //Console.WriteLine($"Sum: {totalSum}");
            //Console.WriteLine($"Product: {totalProduct}");

            #endregion

            #region Problem 10

            //Console.WriteLine("--- Default Parameter (5 times) ---");
            //PrintMessage("Hello .NET!");

            //Console.WriteLine("\n--------------------------------------------------\n");

            //// 3. Calling with a custom positional value
            //Console.WriteLine("--- Positional Parameter (2 times) ---");
            //PrintMessage("Welcome!", 2);

            //Console.WriteLine("\n--------------------------------------------------\n");

            //// 4. Demonstrating Named Parameters
            //Console.WriteLine("--- Named Parameters ---");
            //// Passing arguments in reverse order using parameter names explicitly
            //PrintMessage(count: 3, message: "Named Argument Output");
            #endregion

            #region Problem 11 

            //int[]? numbers = null;

            //// 2. Safely access its properties using the null propagation operator (?.)
            //// Since numbers is null, numbers?.Length evaluates to null without throwing NullReferenceException
            //int? lengthWhenNull = numbers?.Length;

            //Console.WriteLine($"Array is null -> Length: {lengthWhenNull?.ToString() ?? "null"}");

            //Console.WriteLine("\n--------------------------------------------------\n");

            //// Now initialize the array with elements
            //numbers = new int[] { 10, 20, 30, 40 };

            //// Safely access properties again
            //int? lengthWhenInitialized = numbers?.Length;

            //Console.WriteLine($"Array is initialized -> Length: {lengthWhenInitialized}");
            #endregion


            #region Problem 12

            //Console.Write("Enter a day of the week: ");
            //string? inputDay = Console.ReadLine()?.Trim();

            //int dayNumber;

            //// Classic switch statement
            //switch (inputDay?.ToLower())
            //{
            //    case "monday":
            //        dayNumber = 1;
            //        break;
            //    case "tuesday":
            //        dayNumber = 2;
            //        break;
            //    case "wednesday":
            //        dayNumber = 3;
            //        break;
            //    case "thursday":
            //        dayNumber = 4;
            //        break;
            //    case "friday":
            //        dayNumber = 5;
            //        break;
            //    case "saturday":
            //        dayNumber = 6;
            //        break;
            //    case "sunday":
            //        dayNumber = 7;
            //        break;
            //    default:
            //        dayNumber = -1; // Handling invalid inputs
            //        break;
            //}

            //if (dayNumber != -1)
            //{
            //    Console.WriteLine($"Day number: {dayNumber}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid day name entered!");
            //}
            #endregion

            #region Problem 13
            //int result1 = SumArray(10, 20, 30);
            //Console.WriteLine($"Sum of individual values (10, 20, 30): {result1}");

            //// Calling with more individual values
            //int result2 = SumArray(1, 2, 3, 4, 5);
            //Console.WriteLine($"Sum of individual values (1, 2, 3, 4, 5): {result2}");

            //// 3. Calling with an array
            //int[] myArray = { 5, 15, 25, 35 };
            //int result3 = SumArray(myArray);
            //Console.WriteLine($"Sum of array elements {{ 5, 15, 25, 35 }}: {result3}");

            //// Calling with no arguments (returns 0)
            //int result4 = SumArray();
            //Console.WriteLine($"Sum with no arguments: {result4}");
            #endregion


        }
    }
}


