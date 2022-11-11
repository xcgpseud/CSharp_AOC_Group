using Domain.DataModels.Water;

namespace Domain.DataModels.Interfaces.Water;

public interface ISubmarineModel
{
    public int HorizontalPosition { get; set; }

    public int Depth { get; set; }

    public int TravelAndReportLocation(IEnumerable<SubmarineInstruction> instructions);
}