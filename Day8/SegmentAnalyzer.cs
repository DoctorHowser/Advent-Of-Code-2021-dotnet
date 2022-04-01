namespace Advent;

/*


  0:      1:      2:      3:      4:
 aaaa    ....    aaaa    aaaa    ....
b    c  .    c  .    c  .    c  b    c
b    c  .    c  .    c  .    c  b    c
 ....    ....    dddd    dddd    dddd
e    f  .    f  e    .  .    f  .    f
e    f  .    f  e    .  .    f  .    f
 gggg    ....    gggg    gggg    ....

  5:      6:      7:      8:      9:
 aaaa    aaaa    aaaa    aaaa    aaaa
b    .  b    .  .    c  b    c  b    c
b    .  b    .  .    c  b    c  b    c
 dddd    dddd    ....    dddd    dddd
.    f  e    f  .    f  e    f  .    f
.    f  e    f  .    f  e    f  .    f
 gggg    gggg    ....    gggg    gggg
*/
class SegmentAnalyzer
{

    public int analyze(List<Display> codes) {
        int total = 0;
        foreach (Display display in codes) {
            total += analyze(display.Segments);
        }
        return total;
    }
    public int analyze(List<string> codes) {
        

        int count = 0;
        foreach(var code in codes) {
            if(isOne(code)) count++;
            if(isFour(code)) count++;
            if(isSeven(code)) count++;
            if(isEight(code)) count++;

        }
        return count;
    }

    public bool isOne(string code)
    {
        if (code.Count() == 2) return true;
        return false;
    }
    
    public bool isFour(string code)
    {
        if (code.Count() == 4) return true;
        return false;
    }

    public bool isSeven(string code)
    {
        if (code.Count() == 3) return true;
        return false;
    }

    public bool isEight(string code)
    {
        if (code.Count() == 7) return true;
        return false;
    }
}