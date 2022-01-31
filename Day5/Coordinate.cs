namespace Advent;

class Coordinate {
    public int x {get; set;}
    public int y {get; set;}

    public Coordinate(int a, int b) {
        x = a;
        y = b;
    }

    public string GetStringCoord() {
        return $"{x},{y}";
    }

    // public Tuple<int, int> getCoordinate() {
    //     return Tuple.Create(x, y);
    // }
}