using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W7_E3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //Creates an integer array called array which contains numbers through 1-10
            Console.Write("All elements in array: "); //Tells user what the array is
            foreach (int i in array) //Foreach loop that goes through every element in array and writes to same line
            {
                Console.Write($"{i} "); //Writes to same line as "All elements in array: "
            }
            Console.WriteLine(); //Go to next line for next prompt
            Console.WriteLine($"The array's sum is: {array.Sum()}"); //Tells user the sum of array by using .Sum()
            Console.WriteLine($"The array's max is: {array.Max()}"); //Tells user the maximum number of array
            Console.WriteLine($"The array's max is: {array.Min()}"); //Tells user the minimum number of array
            Console.Write("All elements in array reversed: "); //Tells user what the array is in reversed
            foreach (int i in array.Reverse()) //Foreach loop that goes through every element in array which is reversed (.Reverse()) and writes to same line
            {
                Console.Write($"{i} "); //Writes to same line as "All elements in array reversed: "
            }
            Console.WriteLine(); //Go to next line to avoid being on same line of array reversed prompt
            Console.ReadLine(); //Pauses program to allow user to view before quitting
        }
    }
}
