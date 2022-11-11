using Domain.DataModels.Interfaces.Water;

namespace Domain.DataModels.Water;

public class WaterModel
{
    public ISubmarineModel Submarine { get; } = RegularSubmarineModel.Make();

    public ISubmarineModel ArmedSubmarine { get; } = ArmedSubmarineModel.Make();

    public static WaterModel Make()
    {
        return new WaterModel();
    }
}