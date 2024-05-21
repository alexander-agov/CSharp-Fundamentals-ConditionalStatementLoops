using System.Data;

namespace GamingStore
{
    internal class Program
    {
        static void Main()
        {
            var balance = double.Parse(Console.ReadLine());
            var command = Console.ReadLine();
            var totalPrice = 0.0;

            while (command != "Game Time")
            {
                double price = 0.0;
                switch (command)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        command = Console.ReadLine();
                        continue;
                }
                if (balance < price)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    Console.WriteLine($"Bought {command}");
                    totalPrice += price;
                    balance -= price;
                }
                if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                command = Console.ReadLine();
            }
            if (command == "Game Time")
            {
                Console.WriteLine($"Total spent: ${totalPrice:f2}. Remaining: ${balance:f2}");
            }
        }
    }
}




