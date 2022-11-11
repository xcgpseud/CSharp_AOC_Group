namespace Domain.DataModels.Water.Interfaces;

public interface ISubmarineModel
{
    public int TravelAndReportBack(IEnumerable<SubmarineInstruction> instructions);
}