namespace Advent;

class FishTank
{
    public static List<Lanternfish> Fish = File.ReadAllText(@"./data/fishStart.txt")
            .Split(',')
            .Select(startAge =>
            {
                // Console.WriteLine(startAge);
                return new Lanternfish(Int32.Parse(startAge));
            }).ToList();

    public FishTank(int cycles)
    {
        while (cycles-- > 0)
        {
            Console.WriteLine(cycles);
            int newFish = 0;
            foreach (Lanternfish fish in Fish)
            {
                bool spawn = fish.TimePasses();
                if (spawn) newFish++;
            }
            AddFish(newFish);
        }


    }
    public int GetPop()
    {
        return Fish.Count();
    }

    private void AddFish(int amt)
    {
        while (amt-- > 0)
        {
            Fish.Add(new Lanternfish());
        }
    }


}