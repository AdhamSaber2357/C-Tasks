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
        static void Main(string[] args)
        {
            #region Problem 1
            //int[] arr1 = new int[5];
            //int[] arr2 = new int[5] {1,2,3,4,5 } ;
            //int[] arr3 = {1,2,3,4,5 } ;

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.Write($"{arr2[i]} ");
            //}

            //try
            //{
            //    int x = arr2[10];
            //}
            //catch(IndexOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            #endregion

            #region Problem 2
            //// Shallow copy 
            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //int[] arr2 = arr1;

            //arr2[0] = 100;
            //Console.WriteLine(arr1[0]); // 100


            //// Deep copy
            //int[] arr3 = { 1, 2, 3, 4, 5 };
            //int[] arr4 = (int[])arr1.Clone();
            //arr4[0] = 100;

            //Console.WriteLine(arr3[0]); // 1

            #endregion

            #region Problem 3

            //int[,] Grades = new int[3, 3];

            //for(int i=0;i<Grades.GetLength(0); i++)
            //{
            //    Console.WriteLine("Student " + (i+1));
            //    for (int j = 0; j < Grades.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Subject " + (j+1));
            //        Grades[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < Grades.GetLength(0); i++)
            //{
            //    Console.WriteLine("Student " + (i + 1));
            //    for (int j = 0; j < Grades.GetLength(1); j++)
            //    {
            //        Console.Write(Grades[i, j] +  " ");

            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Problem 4
            //int[] arr = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}


            //Array.Reverse(arr);
            //Console.WriteLine("\nAfter reverse :");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}


            //Array.Sort(arr);
            //Console.WriteLine("\nAfter sort :");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();

            //Console.WriteLine(Array.IndexOf(arr,4));

            //int[] arr2 = new int[5];
            //Array.Copy(arr,arr2,5);

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.Write(arr2[i] + " ");
            //}
            //Console.WriteLine();

            //Array.Clear(arr,2,3);

            //Console.WriteLine(arr.Length);
            #endregion

            #region Problem 5
            //int[] numbers = { 10, 20, 30, 40, 50 };

            //Console.Write("for loop: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}
            //Console.WriteLine();

            //Console.Write("foreach loop: ");
            //foreach (int num in numbers)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();

            //Console.Write("while loop (reverse): ");
            //int index = numbers.Length - 1;
            //while (index >= 0)
            //{
            //    Console.Write(numbers[index] + " ");
            //    index--;
            //}
            //Console.WriteLine();
            #endregion

            #region Problem 6

            //int number;
            //bool isValid;

            //do
            //{
            //    Console.Write("Enter a positive odd number: ");
            //    string input = Console.ReadLine();

            //    isValid = int.TryParse(input, out number) && number > 0 && number % 2 != 0;

            //    if (!isValid)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a positive odd integer.");
            //    }
            //}
            //while (!isValid);

            //Console.WriteLine($"Thank you! You entered a valid positive odd number: {number}");

            //Console.WriteLine();
            #endregion

            #region Problem 7
            //int[,] matrix = {
            //    { 1, 2, 3 },
            //    { 4, 5, 6 },
            //    { 7, 8, 9 }
            //};

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j].ToString().PadLeft(4)); // Fixed-width columns for alignment
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Problem 8
            //Console.Write("Enter a month number (1-12): ");
            //int month = int.Parse(Console.ReadLine());

            //// Using if-else
            //string monthNameIfElse;
            //if (month == 1) monthNameIfElse = "January";
            //else if (month == 2) monthNameIfElse = "February";
            //else if (month == 3) monthNameIfElse = "March";
            //else if (month == 4) monthNameIfElse = "April";
            //else if (month == 5) monthNameIfElse = "May";
            //else if (month == 6) monthNameIfElse = "June";
            //else if (month == 7) monthNameIfElse = "July";
            //else if (month == 8) monthNameIfElse = "August";
            //else if (month == 9) monthNameIfElse = "September";
            //else if (month == 10) monthNameIfElse = "October";
            //else if (month == 11) monthNameIfElse = "November";
            //else if (month == 12) monthNameIfElse = "December";
            //else monthNameIfElse = "Invalid month";

            //Console.WriteLine("if-else result: " + monthNameIfElse);

            //// Using switch
            //string monthNameSwitch;
            //switch (month)
            //{
            //    case 1: monthNameSwitch = "January"; break;
            //    case 2: monthNameSwitch = "February"; break;
            //    case 3: monthNameSwitch = "March"; break;
            //    case 4: monthNameSwitch = "April"; break;
            //    case 5: monthNameSwitch = "May"; break;
            //    case 6: monthNameSwitch = "June"; break;
            //    case 7: monthNameSwitch = "July"; break;
            //    case 8: monthNameSwitch = "August"; break;
            //    case 9: monthNameSwitch = "September"; break;
            //    case 10: monthNameSwitch = "October"; break;
            //    case 11: monthNameSwitch = "November"; break;
            //    case 12: monthNameSwitch = "December"; break;
            //    default: monthNameSwitch = "Invalid month"; break;
            //}

            //Console.WriteLine("switch result: " + monthNameSwitch);
            #endregion

            #region Problem 9
            //int[] numbers = { 7, 2, 9, 2, 5, 1 };
            //Console.WriteLine("Before sort: " + string.Join(", ", numbers));

            //Array.Sort(numbers);
            //Console.WriteLine("After sort: " + string.Join(", ", numbers));

            //int firstIndex = Array.IndexOf(numbers, 2);
            //int lastIndex = Array.LastIndexOf(numbers, 2);

            //Console.WriteLine($"First index of value 2: {firstIndex}");
            //Console.WriteLine($"Last index of value 2: {lastIndex}");

            #endregion

            #region Problem 10
            //int[] numbers = { 4, 8, 15, 16, 23, 42 };

            //int sumFor = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sumFor += numbers[i];
            //}
            //Console.WriteLine($"Sum using for loop: {sumFor}");

            //int sumForeach = 0;
            //foreach (int num in numbers)
            //{
            //    sumForeach += num;
            //}
            //Console.WriteLine($"Sum using foreach loop: {sumForeach}");
            #endregion

            // Part 2 : Enum
            #region Problem 11 
            //Console.Write("Enter a number from 1 to 7: ");
            //string input = Console.ReadLine();

            //try
            //{
               
            //    Day day = (Day)Enum.Parse(typeof(Day), input);

            //    if (Enum.IsDefined(typeof(Day), day))
            //    {
            //        Console.WriteLine($"The corresponding day is: {day}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input: please enter a number between 1 and 7.");
            //    }
            //}
            //catch (Exception)
            //{
            //    // Thrown if the input is not a valid number at all (e.g., text input)
            //    Console.WriteLine("Invalid input: please enter a valid number between 1 and 7.");
            //}
            #endregion


        }
    }
}

