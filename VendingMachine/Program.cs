namespace VendingMachine
{
    internal class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            double sumCoins = 0;

            while (command != "Start")
            {
                double coins = double.Parse(command);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    sumCoins += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                command = Console.ReadLine();
            }
            if (command == "Start")
            {
                command = Console.ReadLine();
                while (command != "End")
                {
                    switch (command)
                    {
                        case "Nuts":
                            if (sumCoins >= 2)
                            {
                                sumCoins -= 2.0;
                                Console.WriteLine("Purchased nuts");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Water":
                            if (sumCoins >= 0.7)
                            {
                                sumCoins -= 0.7;
                                Console.WriteLine("Purchased water");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Crisps":
                            if (sumCoins >= 1.5)
                            {
                                sumCoins -= 1.5;
                                Console.WriteLine("Purchased crisps");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Soda":
                            if (sumCoins >= 0.8)
                            {
                                sumCoins -= 0.8;
                                Console.WriteLine("Purchased soda");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Coke":
                            if (sumCoins >= 1)
                            {
                                sumCoins -= 1;
                                Console.WriteLine("Purchased coke");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid product"); break;
                    }

                    command = Console.ReadLine();
                }
                if (command == "End")
                {
                    Console.WriteLine($"Change: {sumCoins:f2}");
                }
            }
        }
    }
}


