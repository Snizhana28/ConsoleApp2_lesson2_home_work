namespace ConsoleApp2_lesson2_home_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text :");
            string text = Console.ReadLine();
            string[] sentences = text.Split('.');
            for (int i = 0; i < sentences.Length; i++)
            {
                string sentence = sentences[i].Trim();
                if (sentence.Length > 0)
                {
                    string firstLetter = sentence.Substring(0, 1);
                    string rest = sentence.Substring(1);
                    string result = firstLetter.ToUpper() + rest;
                    sentences[i] = result;
                }
            }
            string resultText = string.Join(". ", sentences);
            Console.WriteLine(resultText);
        }
    }
}