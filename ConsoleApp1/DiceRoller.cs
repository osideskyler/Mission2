namespace ConsoleApp1;

public class DiceRoller
{
    //method for rolling dice
    public int[] RollDice(int numRolls)
    {
        //make array 0 - 12 indexes, wont use 0 and 1
        int[] results = new int[13];
        Random random = new Random();

        for (int i = 0; i < numRolls; i++)
        {
            //randomly generate dice
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);
            int sum = die1 + die2;

            results[sum]++;
        }
        return results;
    }
}