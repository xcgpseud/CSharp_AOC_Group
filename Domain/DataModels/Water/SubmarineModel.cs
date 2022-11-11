namespace Domain.DataModels.Water;

public class SubmarineModel
{
    protected int HorizontalPosition { get; set; }

    protected int Depth { get; set; }

    public static SubmarineModel Make()
    {
        return new SubmarineModel();
    }

    private void MoveForward(int distance)
    {
        HorizontalPosition += distance;
    }

    private void MoveUp(int distance)
    {
        Depth -= distance;
    }

    private void MoveDown(int distance)
    {
        Depth += distance;
    }

    public int TravelAndReportBack(IEnumerable<SubmarineInstruction> instructions)
    {
        instructions.ToList().ForEach(ExecuteInstruction);

        return HorizontalPosition * Depth;
    }

    private void ExecuteInstruction(SubmarineInstruction instruction)
    {
        switch (instruction.Direction)
        {
            case "forward":
                MoveForward(instruction.Distance);
                break;
            case "up":
                MoveUp(instruction.Distance);
                break;
            case "down":
                MoveDown(instruction.Distance);
                break;
        }
    }

    public (int, int) GetHorizontalPositionAndDepth()
    {
        return (HorizontalPosition, Depth);
    }
}