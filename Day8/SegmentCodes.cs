namespace Advent;

class SegmentCodes
{
    //Why did i make it multidimensional??
    public List<Display> Inputs = new List<Display>();
    public List<Display> Outputs = new List<Display>();

    public SegmentCodes()
    {
        //  var temp = File.ReadAllText(@"./data/displayCode.txt")
        //  .Split('|');

        //  foreach(var segment in temp) {
        //      Codes
        //  }



        var file = File.OpenText(@"./data/displayCode.txt");
        while (!file.EndOfStream)
        {
            // Not using linq, felt it better to manually
            // deal with each line at the same time?
            // maybe a better way to deal.
            var parts = file.ReadLine().Split('|');
            List<string> rawIn = parts[0].Trim().Split(' ').ToList();
            List<string> rawOut = parts[1].Trim().Split(' ').ToList();
            Inputs.Add(new Display(rawIn));
            Outputs.Add(new Display(rawOut));
        }
        file.Dispose();

    }




}