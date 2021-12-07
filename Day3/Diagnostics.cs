namespace Advent;

class Diagnostics {
    //Just working on options. This is static, so no constructor needed.

    public static List<string> Codes = (from line in File.ReadLines(@"./data/diagnostics.txt")
                select line).ToList();

    public static List<List<int>> CodedList =
        (from line in File.ReadLines(@"./data/diagnostics.txt")
            select line.Select(c => c - '0').ToList()).ToList();

}