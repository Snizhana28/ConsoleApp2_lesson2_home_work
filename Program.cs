namespace ConsoleApp2_lesson2_home_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            Random random = new Random();
            int min = 0;
            int max = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = random.Next(-100, 100);
                    Console.Write(array[i, j] + "\t");
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Min value : {min}");
            Console.WriteLine($"max value : {max}");
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                bool isMin = false;
                bool isMax = false;
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] == min)
                    {
                        isMin = true;
                    }
                    if (array[i, j] == max)
                    {
                        isMax = true;
                    }
                    if (isMin && !isMax || isMax && !isMin)
                    {
                        sum += array[i, j];
                    }
                }
            }
            Console.WriteLine($"Result {sum}");
        }
    }
}