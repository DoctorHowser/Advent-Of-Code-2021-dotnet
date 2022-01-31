// See https://aka.ms/new-console-template for more information
namespace Advent;
public class Program {


    public static void Main(string[] args) {
        //** DAY 1 **//

        // int count = 0;
        // for (int i = 1; i < Depths.DepthsList.Count() - 2; i++)
        // {
        //     int a = Depths.DepthsList[i] + Depths.DepthsList[i-1] + Depths.DepthsList[i+1];
        //     int b = Depths.DepthsList[i+1] + Depths.DepthsList[i+2] + Depths.DepthsList[i];
        //     if(a < b) count++;
        // }   
        // Console.WriteLine(count);

        //** DAY 2 **//

        // var directions = new Directions();

        // SubmarineControls sub = new SubmarineControls();

        // foreach (Tuple<string, int> item in directions.List)
        // {
        //     Console.WriteLine(item.Item1);
        //     sub.Move(item);
        // }
        

        // Console.WriteLine(sub.GetDistance());

        //** Day 3 **//

        // var codes = Diagnostics.Codes;
        // CodeProcessor cp = new CodeProcessor(12);
        // cp.ProcessCodes(codes);

        // Console.WriteLine(cp.GetPowerConsumption());

        // var nestedCodes = Diagnostics.CodedList;
        // // Console.WriteLine(nestedCodes[0][10]);
        // OxyCO2 oxy = new OxyCO2();
        // Console.WriteLine(oxy.ProcessCodes(nestedCodes));


        //** Day 4 **//

        // BingoGame bg = new BingoGame();

        // Console.WriteLine(bg.RunGame());
        // Console.WriteLine(bg.RunLosingGame());

        //** Day 5 **//
        Grid grid = new Grid();
        Coordinates.lines.ForEach(line => {
            grid.ProcessLine(line);
        });

        // grid.ProcessLine(Coordinates.lines[2]);
        Console.WriteLine(grid.GetTwoPlusOverlap());


     
        





    }
}
