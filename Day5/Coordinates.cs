namespace Advent;
class Coordinates {
    

    //Pretty proud of this.
    public static List<Line> lines = (
    File.ReadAllText(@"./data/ventCoordinates.txt")
            //split at new line
            .Split(Environment.NewLine)
            //split new line at arrow
            .Select(txtLine => {
                //on each line, split at arrow
                var coordPair = txtLine.Split(" -> ");

                //then split each side of arrow at comma
                // and turn it into a Coordinate
                var point1 = coordPair[0].Split(",").Select(h => Int32.Parse(h)).ToArray();
                var c1 = new Coordinate(point1[0], point1[1]);

                var point2 = coordPair[1].Split(",").Select(h => Int32.Parse(h)).ToArray();
                var c2 = new Coordinate(point2[0], point2[1]);

                //then Make a Line with that coordinate
                return new Line(c1,c2);
            }).ToList()
    );
            
}