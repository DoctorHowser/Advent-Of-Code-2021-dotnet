namespace Advent;

class CrabAlign
{

    public static List<int> CrabPositions = File.ReadAllText(@"./data/crabLocation.txt")
            .Split(',')
            .Select(startAge =>
            {
                // Console.WriteLine(startAge);
                return Int32.Parse(startAge);
            }).ToList();


    private decimal findMedian()
    {
        CrabPositions.Sort(); // sort allows us to do median
        int count = CrabPositions.Count();
        if (count % 2 == 0)
        {
            int a = CrabPositions[count / 2 - 1];
            int b = CrabPositions[count / 2];
            return (a + b) / 2m;
        }
        else
        {
            return CrabPositions[count / 2];
        }
    }



    public decimal getFuelCostV1()
    {
        //Median to the rescue! If we find the number in the middle of the run,
        // there are equal 
        decimal median = findMedian();

        decimal fuel = 0;
        foreach (int crab in CrabPositions)
        {
            fuel += Math.Abs(median - crab);
        }

        return fuel;

    }

    public decimal getFuelCostV2()
    {
        //WOOF.
        // Math.Round would get really close, but 
        // Theres some oddities with things like 10, 10, 10, 9, 
        // where rounding wouldn't be the best. 
        var ceil = (decimal)Math.Ceiling(CrabPositions.Average());
        var floor = (decimal)Math.Floor(CrabPositions.Average());


        decimal fuelC = 0;
        decimal fuelF = 0;


        foreach (int crab in CrabPositions)
        {
            decimal n = Math.Abs(ceil - crab);
            fuelC += (n * (n + 1)) / 2; //sum of natural numbers 1 up to n
        }

        foreach (int crab in CrabPositions)
        {
            decimal n = Math.Abs(floor - crab);
            fuelF += (n * (n + 1)) / 2; //sum of natural numbers 1 up to n
        }

        if(fuelC < fuelF) {
            return fuelC;
        }
        return fuelF;

    }
}