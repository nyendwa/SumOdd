//Write a function that takes an array of integers as an argument
//and returns a value based on the sums of the even and odd numbers in the array.
//Let X = the sum of the odd numbers in the array and let Y = the sum of the even numbers.
//The function should return X – Y
using System;

namespace SumOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumEven = 0;
            int sumOdd = 0;
            int[] a = new int[] { 1, 2, 4, 5, 9};
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    sumEven += a[i];
                }
                else
                {
                    sumOdd += a[i];
                }
                
            }
            Console.WriteLine(sumOdd - sumEven);
        }
    }
}
