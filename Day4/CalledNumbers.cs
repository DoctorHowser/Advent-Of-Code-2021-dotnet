
namespace Advent;
class CalledNumbers
{
    //Read the file, split at ,
    public static List<int> nums = (
        File.ReadAllText(@"./data/bingoNumbers.txt")
        .Split(',').Select(Int32.Parse).ToList());

    //Read the file, split at new line x2 which should be for empty line...
    //Transform each segment into <List<List<int>>
    //Make BingoCard for each segment?
    public static List<BingoCard> cards = (
            File.ReadAllText(@"./data/bingoCards.txt")
            .Split(Environment.NewLine + Environment.NewLine)
            .Select(card =>{
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