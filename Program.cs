namespace ConsoleApp2_lesson2_home_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the expression");
            string expression = Console.ReadLine();
            int result = 0;
            int number = 0;
            char sign = '+';
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '+' || expression[i] == '-')
                {
                    sign = expression[i];
                }
                else
                {
                    number = int.Parse(expression[i].ToString());
                    if (sign == '+')
                        result += number;
                    else
                        result -= number;
                }
            }
            Console.WriteLine($"Result: {result}");
        }
    }
}