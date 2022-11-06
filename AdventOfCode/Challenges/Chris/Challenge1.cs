using AdventOfCode.Enums;
using Helpers;

namespace AdventOfCode.Challenges.Chris;

public class Challenge1 : BaseChallenge
{
    public Challenge1(int challengeId) : base(challengeId)
    {
    }

    public override string GetPartOneAnswer()
    {
        var input = FileHelper.GetFileLines(
            Constants.Files.GetFile(Name.Chris, $"{ChallengeId}.txt"),
            int.Parse
        );

        return CountIncreases(input).ToString();
    }

    public override string GetPartTwoAnswer() => string.Empty;

    private int CountIncreases(int[] input)
    {
        var (last, increases) = (-1, 0);

        input.ToList().ForEach(i =>
        {
            if (i > last && last > -1)
            {
                increases++;
            }

            last = i;
        });

        return increases;
    }
}