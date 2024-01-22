namespace _4.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] stringArray = word.ToCharArray();
            Array.Reverse(stringArray);
            string newWord = new string(stringArray);
            Console.WriteLine(newWord);
        }
    }
}