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
        var input = FileHelper.GetFileLines(GetFileName(Name.Chris), int.Parse);

        return CountIncreases(input).ToString();
    }

    public override string GetPartTwoAnswer()
    {
        var input = FileHelper.GetFileLines(GetFileName(Name.Chris), int.Parse);

        return CountSumIncreases(input).ToString();
    }

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

    private int CountSumIncreases(int[] input)
    {
        var keyToEndOn = input.Length - 3;
        var (previous, increases) = (int.MaxValue, 0);

        for (var i = 0; i <= keyToEndOn; i++)
        {
            var sum = input[i] + input[i + 1] + input[i + 2];
            if (sum > previous)
            {
                increases++;
            }

            previous = sum;
        }

        return increases;
    }
}