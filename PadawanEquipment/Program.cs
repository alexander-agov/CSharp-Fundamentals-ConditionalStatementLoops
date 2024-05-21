namespace PadawanEquipment
{
    internal class Program
    {
        static void Main()
        {
            double givenMoney = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            double calculatedPrice = 0.0;
            int freeBelts = 0;

            if (studentCount > 5) 
            {
                freeBelts = studentCount / 6;
            }

            calculatedPrice = lightsabersPrice * studentCount + 
                lightsabersPrice *( Math.Ceiling(studentCount * 0.1))
                + robePrice * studentCount + beltPrice * (studentCount - freeBelts);
            
            if (calculatedPrice > givenMoney) 
            {
                Console.WriteLine($"John will need {(calculatedPrice-givenMoney):f2}lv more.");
            } else
            {
                Console.WriteLine($"The money is enough - it would cost " +
                    $"{calculatedPrice:f2}lv.");
            }
        }
    }
}
