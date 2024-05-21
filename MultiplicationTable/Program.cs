namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            for ( int i = 1; i <= 10; i++ )
            {
                int times = i;
                int product = num * times;
                Console.WriteLine($"{num} X {times} = {product}");
            }
        }
    }
}
