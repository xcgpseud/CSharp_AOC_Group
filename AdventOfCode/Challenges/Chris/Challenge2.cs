using AdventOfCode.Enums;
using AdventOfCode.Services;
using Helpers;

namespace AdventOfCode.Challenges.Chris;

public class Challenge2 : BaseChallenge
{
    public Challenge2(int challengeId) : base(challengeId)
    {
    }

    public override string GetPartOneAnswer()
    {
        var input = FileHelper.GetFileLines(GetFileName(Name.Chris));

        return SubmarineService.Make().GoOnJourney(input).ToString();
    }

    public override string GetPartTwoAnswer() => string.Empty;
}