using AdventOfCode.Enums;
using Domain.DataModels.Water;
using Helpers;

namespace AdventOfCode.Challenges.Chris;

public class Challenge2 : BaseChallenge
{
    private WaterModel _water = WaterModel.Make();

    public Challenge2(int challengeId) : base(challengeId)
    {
    }

    private SubmarineInstruction[] GetInput()
    {
        return FileHelper.GetFileLines(GetFileName(Name.Chris), line =>
        {
            var split = line.Split(' ');
            return new SubmarineInstruction
            {
                Direction = split[0],
                Distance = int.Parse(split[1]),
            };
        });
    }

    public override string GetPartOneAnswer()
    {
        var input = GetInput();

        return _water.Submarine.TravelAndReportLocation(input).ToString();
    }

    public override string GetPartTwoAnswer()
    {
        var input = GetInput();

        return _water.ArmedSubmarine.TravelAndReportLocation(input).ToString();
    }
}