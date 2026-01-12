namespace ConsoleApp1;

class Program
{
    static void Main()
    {
        //ask user for num rolls
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice would you like to simulate?");
        int numRolls = int.Parse(Console.ReadLine());
        //create roller instance and run rolls to create array
        DiceRoller roller = new DiceRoller();
        int[] results = roller.RollDice(numRolls);
        
        Console.WriteLine("\nDice Roll Results\n");
        //loops through all dice results
        for (int i = 2; i <= 12; i++)
        {
            double percentage = (double)results[i] / numRolls * 100;
            int stars = (int)Math.Round(percentage);
            //print histogram
            Console.WriteLine($"{i}: " + new string('*', stars));
        }
    }
}
