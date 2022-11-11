using System.Diagnostics;
using AdventOfCode.DataModels;

namespace AdventOfCode.Services;

public class SubmarineService
{
    private SubmarineModel _submarine = SubmarineModel.Make();

    public static SubmarineService Make()
    {
        return new SubmarineService();
    }

    public int GoOnJourney(string[] journeyDetails)
    {
        journeyDetails.ToList().ForEach(InstructSubmarine);

        var (horizontalPosition, depth) = _submarine.GetHorizontalPositionAndDepth();
        return horizontalPosition * depth;
    }

    private void InstructSubmarine(string instruction)
    {
        var split = instruction.Split(' ');
        var (direction, distance) = (split[0], int.Parse(split[1]));

        switch (direction)
        {
            case "forward":
                _submarine.MoveForward(distance);
                break;
            case "down":
                _submarine.MoveDown(distance);
                break;
            case "up":
                _submarine.MoveUp(distance);
                break;
        }
    }
}