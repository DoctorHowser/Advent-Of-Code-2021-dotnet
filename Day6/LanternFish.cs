namespace Advent;

class Lanternfish
{
    private const int NEWBORN_SPAWN_COUNT_START = 8;
    private const int SPAWN_COUNT_START = 6;

    private int daysToSpawn;
    // private bool isNewborn;

    public Lanternfish(int days)
    {
        daysToSpawn = days;
        // isNewborn = false;
    }

    public Lanternfish()
    {
        daysToSpawn = NEWBORN_SPAWN_COUNT_START;
        // isNewborn = true;
    }

    public bool TimePasses()
    {
        if (daysToSpawn == 0)
        {
            //BIRTH!
            daysToSpawn = SPAWN_COUNT_START;
            // isNewborn = false;
            return true;
        }
        else
        {
            daysToSpawn--;
            return false;

        }

    }
}