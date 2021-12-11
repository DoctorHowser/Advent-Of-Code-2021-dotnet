namespace Advent;
class BingoGame
{


    //Find the first winning card,
    // Sum up remaining nums on that card,
    // Multiply by called num
    public int RunGame()
    {
        // loop over numbers called

        foreach (var calledNum in CalledNumbers.nums)
        {
            Console.WriteLine(calledNum);

            //mark each number
            foreach (var card in CalledNumbers.cards)
            {
                card.markNumber(calledNum);
                //Check Win status
                if (card.isWinner)
                {
                    //have a winner!
                    // if winner, process that card for uncalled number sum and last number?
                    return card.GetUncalledNumberSum() * calledNum;

                }
            }




        }
        return -1;
    }

    //Find LAST winning card
    // Sum up all remaining numbers
    // Multiply by last number called
    public int RunLosingGame()
    {
        var temp = CalledNumbers.cards;
        bool lastCard = false;
        // loop over numbers called

        foreach (var calledNum in CalledNumbers.nums)
        {
            // Check if were on the last card
            if (!lastCard && temp.Count == 1)
            {
               lastCard = true;
            }

            Console.WriteLine(calledNum);

            //mark each number
            foreach (var card in temp.ToList())
            {
                card.markNumber(calledNum); 
                if(card.isWinner && lastCard) {
                    return card.GetUncalledNumberSum() * calledNum;
                }


                else if (card.isWinner)
                {
                    temp.Remove(card);
                }

            }
        }
        return -1;
    }



}