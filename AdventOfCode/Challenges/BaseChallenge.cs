﻿using AdventOfCode.Interfaces.Challenges;
using Helpers;

namespace AdventOfCode.Challenges;

public abstract class BaseChallenge : IChallenge
{
    protected int ChallengeId { get; }

    protected BaseChallenge(int challengeId)
    {
        ChallengeId = challengeId;
    }

    public void Run()
    {
        var currentClass = GetType().Name;

        var answerOne = GetPartOneAnswer();
        var answerTwo = GetPartTwoAnswer();

        ConsoleWriter.WriteAnswer($"Challenge {ChallengeId} part 1", answerOne);
        ConsoleWriter.WriteAnswer($"Challenge {ChallengeId} part 2", answerTwo);
    }

    public abstract string GetPartOneAnswer();

    public abstract string GetPartTwoAnswer();
}