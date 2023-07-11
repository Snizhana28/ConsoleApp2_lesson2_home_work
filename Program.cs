namespace ConsoleApp2_lesson2_home_work
{
    internal class Program
    {
        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                Console.Write("|");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j],3}");
                }
                Console.WriteLine("|");
            }
            Console.WriteLine();
        }
        static int[,] MultiplyMatrixOnNumber(int[,] matrix, int number)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int[,] result = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++) result[i, j] = matrix[i, j] * number;
            }
            return result;
        }
        static int[,] AddMatrix(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetUpperBound(0) + 1;
            int columns = matrix1.Length / rows;
            int[,] result = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++) result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
            return result;
        }
        static int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetUpperBound(0) + 1;
            int columns = matrix1.Length / rows;
            int[,] result = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++) result[i, j] = matrix1[i, j] * matrix2[i, j];
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[,] AB = new int[3, 3] { {1, 2, 3},{4, 5, 6},{7, 8, 9} };
            PrintMatrix(AB);
            //multiply matrix on number
            AB = MultiplyMatrixOnNumber(AB, 5);
            PrintMatrix(AB);
            //add matrix
            AB = AddMatrix(AB, AB);
            PrintMatrix(AB);
            //multiply matrix
            AB = MultiplyMatrix(AB, AB);
            PrintMatrix(AB);
        }
    }
}