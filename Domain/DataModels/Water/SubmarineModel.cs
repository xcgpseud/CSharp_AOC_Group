using Domain.DataModels.Interfaces.Water;

namespace Domain.DataModels.Water;

public abstract class SubmarineModel : ISubmarineModel
{
    public int HorizontalPosition { get; set; }

    public int Depth { get; set; }


    public abstract int TravelAndReportLocation(IEnumerable<SubmarineInstruction> instructions);

}