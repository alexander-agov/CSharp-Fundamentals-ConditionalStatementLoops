namespace SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;

            for ( int i = 1; i <= n; i++ ) 
            {
                int current = 2 * i - 1;
                Console.WriteLine(current);
                sum += current;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
