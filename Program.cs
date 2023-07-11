using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ConsoleApp2_lesson2_home_work
{
    internal class Program
    {
        static void PrintArray(int[] array)
        {
            foreach (var item in array)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
        static void PrintMatrix (double [,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write($"{array[i, j]} ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static int FindMaxElement(int[] array, double[,] array2)
        {
            int maxElement = 0;
            foreach (var item in array)
            {
                if (item > maxElement)
                    maxElement = item;
            }
            int rows = array2.GetLength(0);
            int cols = array2.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array2[i, j] > maxElement)
                    maxElement = (int)array2[i, j];
                }
            }
            return maxElement;
        }
        static int FindMinElement(int[] array, double[,] array2)
        { 
            int minElement = 0;
            foreach (var item in array) 
            { 
                if (item < minElement)
                minElement = item;
            }
            int rows = array2.GetLength(0);
            int cols = array2.GetLength(1);
            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array2[i, j] < minElement)
                    minElement = (int)array2[i, j];
                }
            }
            return minElement;
        }
        static int SumElement(int[] array, double[,] array2)
        {
            int sumElement = 0;
            foreach (var item in array) sumElement += item; 

            int rows = array2.GetLength(0);
            int cols = array2.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                        sumElement += (int)array2[i, j];
            }
            return sumElement;
        }
        static int ProductOfElements(int[] array, double[,] array2)
        {
            int product = 1;
            foreach (var item in array)
            {
                product *= item;
            }
            int rows = array2.GetLength(0);
            int columns = array2.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    product *= (int)array2[i, j];
            }
            return product;
        }
        static int SumEvenNumber(int[] array)
        {
            int sum = 0;
            foreach (var element in array)
            {
                if (element % 2 == 0)
                    sum += element;
            }
            return sum;
        }
        static double SumOddNumber(double[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            double sum = 0;
            for (int j = 0; j < columns; j++)
            {
                if (j % 2 != 0)
                {
                    for (int i = 0; i < rows; i++)
                        sum += array[i, j];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] A = new int[5];
            double[,] B = new double[3, 4];
            Console.WriteLine("Fill the array A with 5 elements : ");

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"A[{i}]: ");
                A[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Random fill array B : ");
            Random random = new Random();
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = random.NextDouble();
                }
            }

            Console.WriteLine("Array A : ");
            PrintArray(A);
            Console.WriteLine("Array B : ");
            PrintMatrix(B);

            int maxElement = FindMaxElement(A, B);
            int minElement = FindMinElement(A, B);
            int sumOfElements = SumElement(A, B);
            int productOfElements = ProductOfElements(A, B);
            int sumOfEvenElements = SumEvenNumber(A);
            double sumOfOddColumns = SumOddNumber(B);

            Console.WriteLine($"Find max element : {maxElement}");
            Console.WriteLine($"Find min element : {minElement}");
            Console.WriteLine($"Sum of elements : {sumOfElements}");
            Console.WriteLine($"The total product of all elements : {ProductOfElements}");
            Console.WriteLine($"The sum of even elements of array A : {SumEvenNumber}");
            Console.WriteLine($"Sum of odd columns of array B : {SumOddNumber}");
        }
    }
}