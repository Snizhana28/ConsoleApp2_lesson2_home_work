namespace ConsoleApp2_lesson2_home_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text :");
            string text = Console.ReadLine();
            Console.WriteLine("Enter a unacceptable word : ");
            string old_word = Console.ReadLine();
            string new_word = "*****";
            string result = text.Replace(old_word, new_word);
            Console.WriteLine($"New text : {result}");
        }
    }
}