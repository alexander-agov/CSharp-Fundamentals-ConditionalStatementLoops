namespace ReverseString
{
    internal class Program
    {
        static void Main()
        {
           var str = Console.ReadLine();
            var newStr = "";

            for (int i = str.Length-1; i >= 0; i--)
            {
                newStr += str[i];
            }
            Console.WriteLine(newStr);
        }
    }
}
