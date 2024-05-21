namespace StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            int attempt = 1;
            char[] newOne = username.ToCharArray();
            Array.Reverse(newOne);
            string pass = new string(newOne);
            while (attempt < 4)
            {
                if (password == pass)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    attempt++;

                    password = Console.ReadLine();
                }
            }
            if (attempt == 4 && password == pass)
            {
                Console.WriteLine($"User {username} logged in.");
                return;
            }
            else
            {
                Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}


