/* Assignment 2.4.2
2. Write a C# Sharp program to find the largest value in an array of n numbers. Return the Index and the value. Do not use built in functions and methods.
    Test Data :
    Input the number of elements to store in the array :3
    Input the 1st number :25
    Input the 2nd number :63
    Input the 3rd number :10
    Expected Output :
    Element {1} is the largest value in the array of length 3.
*/
namespace Assignment_2._4._2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input the number of elements to store in an array.");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input the number for element {0} :", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int maxIndex = 0;
            int maxValue = numbers[0];
            for (int i = 1; i < n; i++)
            {
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                    maxIndex = i;
                }
            }
            Console.WriteLine("Element {0} of value {1}, is the largest value in the array of length {2}.", maxIndex + 1, numbers[maxIndex], n);
        }
    }
}