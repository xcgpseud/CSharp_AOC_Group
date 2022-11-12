using Domain.DataModels.Interfaces.Water;

namespace Domain.DataModels.Water;

public class ArmedSubmarineModel : SubmarineModel
{
    public static ISubmarineModel Make()
    {
        return new ArmedSubmarineModel();
    }

    private int Aim { get; set; }

    public override int TravelAndReportLocation(IEnumerable<SubmarineInstruction> instructions)
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