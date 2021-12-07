namespace Advent;

class OxyCO2
{

    public int ProcessCodes(List<List<int>> Codes)
    {
        //count = Codes.Count / 2;

        List<int> o2Binary = Filter(Codes, true);
        List<int> co2Binary = Filter(Codes, false);

    // This bothers me. But I need to turn a list of ints which represent a binary
    // into a decimal number...
        var o2Decimal = Convert.ToInt32(string.Join("", o2Binary), 2);
        var co2Decimal = Convert.ToInt32(string.Join("", co2Binary), 2);

        return o2Decimal * co2Decimal;
    }

    // This is something I'm rather unsure about. 
    private List<int> Filter(List<List<int>> source, bool mostCommon, int index = 0)
    {

        // Get the most common for that index
        // I dont really get LINQ, but it feels like SQL
        // This I had to look up, and dont really get it all.

        //At its core, I would think this could be simpler.
        // Gets the right answer
        var most = source.Select(x => x[index]) // make a list of all the 1s and 0s in the first position
            //sort the rows 1 to 0?
            .OrderByDescending(x => x)
            //Group into 1 and 0 keys?
            .GroupBy(i => i)
            // Count the number of items, order by the most, so the most will be at index 0
            .OrderByDescending(g => g.Count())
            // Just want the key, not the grouping
            .Select(x => x.Key)
            //Need just '1' or '0'
            .First();



            
        /*
        Something more akin to my thoughts, but something is missing or off.
        Probably due to my misunderstanding on how things work?
       
        // Sum all the items at that index.
        var sum = source.Select(x => x[index]) // make a list of all the 1s and 0s in the first position
            //add all the 1s and 0s    
            .Sum();
            
        //get halfway point
        var half = source.Select(x => x[index]).Count() / 2;
        //if sum is more than halfway, then 1 is the most.
        var most = sum > half ? 1 : 0;




        */

    

        //this is how we make this reusable
        // we pass in a true or false
        // if true, then we're looking for most common (02)
        // if false, then we're looking for least common (CO2)
        var filteredList = mostCommon ?
                            source.Where(x => x[index] == most).ToList() :
                            source.Where(x => x[index] != most).ToList();

        //If last item, we're done.
        if (filteredList.Count == 1)
        {
            return filteredList.First();

        }

        // Otherwise, do this again with that newly filtered list on the next index.
        // Kinda like a reducer, actually.
        return Filter(filteredList, mostCommon, index += 1);

    }

}
