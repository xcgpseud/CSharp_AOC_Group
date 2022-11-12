using Domain.DataModels.Interfaces.Water;

namespace Domain.DataModels.Water;

public class RegularSubmarineModel : SubmarineModel, ISubmarineModel
{
    public static ISubmarineModel Make()
    {
        return new RegularSubmarineModel();
    }

    public override int TravelAndReportLocation(IEnumerable<SubmarineInstruction> instructions)
    {
        instructions.ToList().ForEach(ExecuteInstruction);

        return HorizontalPosition * Depth;
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
}