namespace RageExpenses
{
    internal class Program
    {
        static void Main()
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            var mousePrice = double.Parse(Console.ReadLine());
            var keyboardPrice = double.Parse(Console.ReadLine());  
            var displayPrice = double.Parse(Console.ReadLine());
            var expenses = 0.0;

            if (lostGames / 12 >= 1)
            {
                expenses = lostGames / 2 * headsetPrice + lostGames / 3 * mousePrice
              + lostGames / 6 * keyboardPrice + lostGames / 12 * displayPrice;
            } else
            {
                expenses = lostGames / 2 * headsetPrice + lostGames / 3 * mousePrice
                    + lostGames / 6 * keyboardPrice;
            }
          
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
