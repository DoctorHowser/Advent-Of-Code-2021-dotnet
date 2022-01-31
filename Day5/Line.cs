namespace Advent;

class Line
{
    public Coordinate p1 { get; set; }
    public Coordinate p2 { get; set; }

    public Line(Coordinate a, Coordinate b)
    {
        //always have lower x at p1, for ease when making diags
        if (a.x <= b.x)
        {
            p1 = a;
            p2 = b;
        }
        else
        {
            p1 = b;
            p2 = a;
        }

    }

    public int getRun()
    {
        return p2.x - p1.x;
    }

    public int getRise()
    {
        return p2.y - p1.y;
    }

    public double getSlope()
    {
        if (getRun() == 0) return Double.PositiveInfinity;
        return getRise() / getRun();
    }

    public bool isStraight()
    {
        if (getRun() == 0 || getRise() == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public List<Coordinate> PrintAllCoords()
    {

        List<Coordinate> AllPoints = new List<Coordinate>();

        var minX = Math.Min(p1.x, p2.x);
        var minY = Math.Min(p1.y, p2.y);

        var deltaX = Math.Abs(getRun());
        var deltaY = Math.Abs(getRise());

        //Diagonal
        if (deltaX == deltaY)
        {
            if (getSlope() > 0)
            {
                //asc
                for (int i = 0; i <= deltaX; i++)
                {
                    //(11,1) -> (12,2)
                    Coordinate c = new Coordinate(p1.x + i, p1.y + i);
                    // ProcessCoord(c);
                    AllPoints.Add(c);
                }

            }
            else
            {
                //desc
                 for (int i = 0; i <= deltaX; i++)
                {
                    //(11,1) -> (12,0)
                    Coordinate c = new Coordinate(p1.x + i, p1.y - i);
                    // ProcessCoord(c);
                    AllPoints.Add(c);
                }
            }





        }
        //Horizontal
        else if (deltaX > 0)
        {
            for (int i = 0; i <= deltaX; i++)
            {
                Console.WriteLine($"{minX + i}, {p1.y}");
                Coordinate c = new Coordinate(minX + i, p1.y);
                // ProcessCoord(c);
                AllPoints.Add(c);
            }
        }
        //vertical
        else if (deltaY > 0)
        {
            for (int i = 0; i <= deltaY; i++)
            {
                Console.WriteLine($"{p1.x}, {minY + i}");

                Coordinate c = new Coordinate(p1.x, minY + i);
                AllPoints.Add(c);
            }
        }
        return AllPoints;
    }
}