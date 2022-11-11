using Domain.DataModels.Water.Interfaces;

namespace Domain.DataModels.Water;

public class ArmedSubmarineModel : ISubmarineModel
{
    public static ArmedSubmarineModel Make()
    {
        return new ArmedSubmarineModel();
    }

    private int HorizontalPosition { get; set; }

    private int Depth { get; set; }

    private int Aim { get; set; }

    public int TravelAndReportBack(IEnumerable<SubmarineInstruction> instructions)
    {
        instructions.ToList().ForEach(ExecuteInstruction);

        return HorizontalPosition * Depth;
    }

    private void AimUp(int amount)
    {
        Aim -= amount;
    }

    private void AimDown(int amount)
    {
        Aim += amount;
    }

    private void MoveForward(int amount)
    {
        HorizontalPosition += amount;
        Depth += Aim * amount;
    }

    private void ExecuteInstruction(SubmarineInstruction instruction)
    {
        switch (instruction.Direction)
        {
            case "up":
                AimUp(instruction.Distance);
                break;
            case "down":
                AimDown(instruction.Distance);
                break;
            case "forward":
                MoveForward(instruction.Distance);
                break;
        }
    }
}