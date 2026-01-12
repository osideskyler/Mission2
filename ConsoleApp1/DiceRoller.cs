namespace ConsoleApp1;

public class DiceRoller
{
    public int[] RollDice(int numRolls)
    {
        int[] results = new int[13];
        Random random = new Random();

        for (int i = 0; i < numRolls; i++)
        {
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);
            int sum = die1 + die2;

            results[sum]++;
        }
        return results;
    }
}