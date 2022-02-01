namespace Advent;


//Kinda took a bit of brute force.
// V1 is fine until you get too many objects, 
//so had to make them smaller, but we ran out of Int32, so had to make it Int64.
class FishTankV2
{
    private Int64 zero = 0;
    private Int64 one = 0;
    private Int64 two = 0;
    private Int64 three = 0;
    private Int64 four = 0;
    private Int64 five = 0;
    private Int64 six = 0;
    private Int64 seven = 0;
    private Int64 eight = 0;


    public static List<int> Fish = File.ReadAllText(@"./data/fishStart.txt")
          .Split(',')
          .Select(startAge =>
          {
              // Console.WriteLine(startAge);
              return Int32.Parse(startAge);
          }).ToList();



    public FishTankV2(int cycles)
    {
        //populate the running counts...
        foreach (int fishAge in Fish)
        {
            switch (fishAge)
            {
                case 0:
                    zero++;
                    break;
                case 1:
                    one++;
                    break;
                case 2:
                    two++;
                    break;
                case 3:
                    three++;
                    break;
                case 4:
                    four++;
                    break;
                case 5:
                    five++;
                    break;
                case 6:
                    six++;
                    break;
                case 7:
                    seven++;
                    break;
                case 8:
                    eight++;
                    break;
                default:
                    Console.WriteLine("OUT OF BOUNDS");
                    return;
            }
        }

        //run simulation
        while (cycles-- > 0)
        {
            Console.WriteLine(cycles);
            MoveTime();

        }
    }

    private void MoveTime() {

        
        Int64 newFish = zero;
        Console.WriteLine(newFish);
        zero = one;
        one =  two;
        two = three;
        three = four;
        four = five;
        five = six;
        six = seven;
        seven = eight;
        eight = newFish;
        six += newFish;
    }

    public Int64 GetPop()
    {
        return zero + one + two + three + four + five + six + seven + eight;
    }
}