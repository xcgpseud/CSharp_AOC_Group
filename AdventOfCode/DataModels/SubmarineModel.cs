namespace AdventOfCode.DataModels;

public class SubmarineModel
{
    private int HorizontalPosition { get; set; }

    private int Depth { get; set; }

    public static SubmarineModel Make()
    {
        return new SubmarineModel();
    }

    public void MoveForward(int distance)
    {
        HorizontalPosition += distance;
    }

    public void MoveUp(int distance)
    {
        Depth -= distance;
    }

    public void MoveDown(int distance)
    {
        Depth += distance;
    }

    public (int, int) GetHorizontalPositionAndDepth()
    {
        return (HorizontalPosition, Depth);
    }
}