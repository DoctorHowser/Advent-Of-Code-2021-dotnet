
namespace Advent;
class BingoCard
{

    private List<List<BingoNumber>> card;
    public bool isWinner = false;
    public BingoCard(List<List<int>> numbers)
    {
        card = numbers.Select(
                row => row.Select(
                    num => new BingoNumber(num)).ToList()
        ).ToList();
    }

    public void markNumber(int called)
    {
        foreach (var row in card)
        {
            foreach (var num in row)
            {
                if (called == num.number)
                {
                    num.markNum();
                    checkBingo();

                    return;
                }
            }
        }
    }

    private void checkBingo()
    {
        //already won, dont care
        if (isWinner) return;
        //check rows
        foreach (var row in card)
        {
            if (row.TrueForAll(item => item.called))
            {
                Console.WriteLine("ROW WIN");
                isWinner = true;
                return;
            }
        }

        //check cols
        for (int i = 0; i < card.Count; i++)
        {

            if (card.TrueForAll(row => row[i].called))
            {
                Console.WriteLine("COL WIN");

                isWinner = true;
                return;
            }
        }

    }

    public int GetUncalledNumberSum()
    {
        int count = 0;
        foreach (var row in card)
        {
            foreach (var num in row)
            {
                //Console.WriteLine(num.number);
                if (!num.called)
                {
                    count += num.number;
                }
            }
        }
        return count;
    }
}