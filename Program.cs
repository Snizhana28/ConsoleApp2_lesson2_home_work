namespace ConsoleApp2_lesson2_home_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Створіть додаток, який здійснює операції над матрицями:
■ Множення матриці на число;
■ Додавання матриць;
■ Добуток матриць*/
            int[,] array = new int[5, 5];
            Random random = new Random();
            //додавання матриць
            for (int i = 0; i < 5; i++)
            {
                int sum = 0;
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = random.Next(0, 10);
                    Console.Write($"{array[i, j]} ");
                    sum += array[i, j];
                }
                Console.WriteLine($"sum : {sum}");
            }
            // множення матриці на число
            int number = 5;
            Console.WriteLine($"number : {number}");
            for (int i = 0; i < 5; i++)
            {
                int sum = 0;
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] *= number;
                    Console.Write($"{array[i, j]} ");
                    sum += array[i, j];
                }
                Console.WriteLine($"sum : {sum}");
            }
            // добуток матриць

            }

        }
    }
}