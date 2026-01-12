namespace ConsoleApp1;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice would you like to simulate?");
        int numRolls = int.Parse(Console.ReadLine());

        DiceRoller roller = new DiceRoller();
        int[] results = roller.RollDice(numRolls);
        
        Console.WriteLine("\nDice Roll Results\n");

        for (int i = 2; i <= 12; i++)
        {
            double percentage = (double)results[i] / numRolls * 100;
            int stars = (int)Math.Round(percentage);

            Console.WriteLine($"{i}: " + new string('*', stars));
        }
        


    }
}
