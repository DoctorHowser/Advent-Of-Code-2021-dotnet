namespace Advent;
using System.Collections.Concurrent;
class Grid
{

    private ConcurrentDictionary<string, int> grid = new ConcurrentDictionary<string, int>();

    public int GetTwoPlusOverlap()
    {
        // int count = 0;
        // foreach (var point in grid)
        // {
        //     Console.WriteLine(point.Key);
        //     Console.WriteLine(point.Value);
        //     if(point.Value > 1) {
        //         count++;
        //     }
        // }
        // return count;
        return grid.Values
        .Where(v =>
        {
            // Console.WriteLine(v);
            return (v >= 2);
        }).Count();
    }


    public void ProcessLine(Line l)
    {
        foreach (var coord in l.PrintAllCoords())
        {
            ProcessCoord(coord);
        }

        

    }

    private void ProcessCoord(Coordinate c)
    {

        grid.AddOrUpdate(c.GetStringCoord(), 1, (k, v) => v + 1);

    }


}