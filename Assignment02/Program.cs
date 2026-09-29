/*
 * Student ID :1690702079
 * Name       :สุภนัย หัทยาภิชาติ
 * Section    :129C
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */

 namespace assignment02;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==================================");
        Console.WriteLine("=== >> Welcome To Minecraft << ===");
        Console.WriteLine("==================================");

        Console.WriteLine("=> Iron Smelting 0.25 / Salvage 0.30");
        Console.WriteLine("Choose between Smelt or Salvage : ");
        Console.WriteLine("type S For Smelt");
        Console.WriteLine("type B For Salvage");
        string Ore = "Iron Ores";
        string Ingot = "Iron Ingots";
        double SmeltRate = 0.25;
        double SalvageRate = 0.3;
        double Maxbatch = 500;
        Console.Write("=> Choose Menu: ");
        string? choice = Console.ReadLine();
        char.TryParse(choice, out char choiceChar);

        if (choiceChar == 'S' || choiceChar == 's')
        {
            Console.WriteLine("You chose to Smelt.");
            Console.WriteLine($"Enter the number of {Ore} to smelt: ");
            string? itemCountInput = Console.ReadLine();
            if (double.TryParse(itemCountInput, out double itemCount))
            {
                if (itemCount > 0 && itemCount <= Maxbatch)
                {
                    Console.WriteLine($"You have chosen to smelt {itemCount:F2} {Ore}.");
                    double IngotCount = itemCount * SmeltRate;
                    Console.WriteLine($"You will get {IngotCount:F2} {Ingot}.");
                }
                else if (itemCount <= 0)
                {
                    Console.WriteLine("The number must be more than zero.");
                }
                else
                {
                    Console.WriteLine($"You cannot smelt more than {Maxbatch} {Ore} at once.");
                }
            }
            else
            {
                Console.WriteLine($"Invalid number of {Ore}.");
               
            }
        }
        else if (choiceChar == 'B' || choiceChar == 'b')
        {
            Console.WriteLine("You chose to Salvage.");
            Console.WriteLine($"Enter the number of {Ingot} to salvage: ");
            string? itemCountInput = Console.ReadLine();
            if (double.TryParse(itemCountInput, out double itemCount))
            {
                if (itemCount > 0 && itemCount <= Maxbatch)
                {
                    Console.WriteLine($"You have chosen to salvage {itemCount:F2} {Ingot}.");
                    double OreCount = itemCount / SalvageRate;
                    Console.WriteLine($"You will get {OreCount:F2} {Ore}.");
                }
                else if (itemCount <= 0)
                {
                    Console.WriteLine("The number must be more than zero.");
                }
                else
                {
                    Console.WriteLine($"You cannot salvage more than {Maxbatch} {Ingot} at once.");
                }
            }
            else
            {
                Console.WriteLine($"Invalid number of {Ingot}.");
            }   
        }
        else
        {
            Console.WriteLine("Choose Between Smelt (S) or Salvage (B).");
          
        }
        

    }
}