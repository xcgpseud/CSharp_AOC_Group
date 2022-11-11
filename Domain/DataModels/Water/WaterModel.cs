namespace Domain.DataModels.Water;

public class WaterModel
{
    public SubmarineModel Submarine { get; } = SubmarineModel.Make();

    public ArmedSubmarineModel ArmedSubmarine { get; } = ArmedSubmarineModel.Make();

    public static WaterModel Make()
    {
        return new WaterModel();
    }
}