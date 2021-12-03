namespace Advent;

class SubmarineControls
{

    private int aim { get; set; }
    private int horizontal { get; set; }
    private int depth { get; set; }

    public SubmarineControls()
    {
        horizontal = 0;
        depth = 0;
        aim = 0;
    }

    public void Move(Tuple<string, int> guidance)
    {
        switch (guidance.Item1)
        {
            case "forward":
                MoveForward(guidance.Item2);
                break;
            case "down":
                ChangeAim(guidance.Item2);
                break;
            case "up":
                ChangeAim(0 - guidance.Item2);
                break;
        }
    }

    private void ChangeAim(int distance)
    {
        aim += distance;
    }

    public int GetDistance()
    {
        return horizontal * depth;
    }
    private void MoveForward(int distance)
    {
        horizontal += distance;
        ChangeDepth(distance * aim);
    }

    private void ChangeDepth(int distance)
    {
        depth += distance;
    }
}