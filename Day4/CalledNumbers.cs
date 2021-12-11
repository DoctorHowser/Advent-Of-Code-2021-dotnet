
namespace Advent;
class CalledNumbers
{
    //Read the file, split at ,
    //Works fine, I like . notation for LINQ better
    public static List<int> nums = (
        File.ReadAllText(@"./data/bingoNumbers.txt")
        .Split(',').Select(Int32.Parse).ToList());

    //Read the file, split at new line x2 which should be for empty line...
    //Transform each segment into <List<List<int>> for BingoCard
    //Feels awfully messy. Its probably a result of my 2d List data structure.
    //I bet if I did this as some sort of dictionary of lists it would be more...sane?
    // 3x ToList()
    public static List<BingoCard> cards = (
            File.ReadAllText(@"./data/bingoCards.txt")
            .Split(Environment.NewLine + Environment.NewLine)
            .Select(card => {
                //Console.WriteLine(card);
                return new BingoCard(card.Split(Environment.NewLine)
                    .Select(line =>
                        line.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Select(item =>{
                            //Console.WriteLine(item);
                            return Convert.ToInt32(item);
                        }
                        ).ToList()
                    ).ToList()
                );
            }).ToList()
    );
    // select Convert.ToInt32(line)).ToList();
}