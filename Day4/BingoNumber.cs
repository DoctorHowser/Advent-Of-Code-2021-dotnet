namespace Advent;
class BingoNumber {

    public int number;
    public bool called = false;

    public BingoNumber(int num) {
        number = num;
    }

    public void markNum() {
        called = true;
    }
}