namespace MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            do
            {
                int product = num * times;
                Console.WriteLine($"{num} X {times} = {product}");
                times++;
            } while (times <= 10);
        }
    }
}
