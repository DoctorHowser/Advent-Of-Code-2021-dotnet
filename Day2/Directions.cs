using System.Linq;


namespace Advent;
public class Directions
{

    //Better, I used their input in a txt file and parsed.
    // I want to use info from their website, but I would have to log in,
    // which is more than I want to do
    public List<Tuple<string, int>> List = new List<Tuple<string, int>>();


    // I might prefer this to be static and done immediately 
    // instead of in a constructor
    public Directions()
    {
        //LINQ! 
        // Get each line in the file
        // split at space
        // Create a tuple from the values array
        // string by default, int for the 2nd param
        // Then make a list!

        List = (from line in File.ReadLines(@"./data/directions.txt")
                let values = line.Split(' ')
                select Tuple.Create(values[0], Int32.Parse(values[1]))).ToList();

    }


}