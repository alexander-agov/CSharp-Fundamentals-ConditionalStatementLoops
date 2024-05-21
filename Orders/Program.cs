namespace Orders
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var totalPrice = 0.0;
            var price = 0.0;

            for (int i = 1; i <= n; i++)
            {
                var pricePerCapsule = double.Parse(Console.ReadLine());
                var daysInMonth = int.Parse(Console.ReadLine());
                var capsulesCount = int.Parse(Console.ReadLine());
                price = ((daysInMonth * capsulesCount) * pricePerCapsule);
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                totalPrice += price;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
