namespace ConsoleApp2_lesson2_home_work
{
    internal class Program
    {
        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
        static void Main(string[] args)
        {
            /*
             Оголосити одновимірний (5 елементів) масив з назвою 
             A i двовимірний масив (3 рядки, 4 стовпці) дробових чисел 
             з назвою B. Заповнити одновимірний масив А числами, 
             введеними з клавіатури користувачем, а двовимірний 
             масив В — випадковими числами за допомогою циклів. 
             Вивести на екран значення масивів: масиву А — в один 
             рядок, масиву В — у вигляді матриці. Знайти у даних 
             масивах загальний максимальний елемент, мінімальний 
             елемент, загальну суму усіх елементів, загальний добуток 
             усіх елементів, суму парних елементів масиву А, суму 
             непарних стовпців масиву В
             */
            int[] A = new int[5];
            int[,] B = new int[3, 4];
            Console.WriteLine("Fill the array A with 5 elements : ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("Enter the {0} element : ", i + 1);
                A[i] = Convert.ToInt32(Console.ReadLine);
            }
            foreach (var item in A)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("Random fill array B : ");
            Random random = new Random();
            for (int i = 0;i < B.Length;i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    B[i, j] = random.Next(1, 20);
                }
            }
            foreach(var item in B)
            {
                Console.Write(item + " ");
            }
            //Знаходження загального макмимального елемнта двох масивів

            Console.Write("Max velue : ");

        }
    }
}