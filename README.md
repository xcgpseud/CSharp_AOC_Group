# How to use

> This assumes directories etc. have already been configured for you. ATM just see Chris if you want adding to this, or add yourself if you can figure out how.

1. Create a file in your input folder with your puzzle input. Name it with the number of the challenge. So for me (Chris) for challenge 1, I create `AdventOfCode/Inputs/Chris/1.txt`
2. Create a class in your challenge folder. Name it Challenge{i}.txt. So for example, in this example, I create `AdventOfCode/Challenges/Chris/Challenge1.cs`
3. Extend `BaseChallenge` and add the required methods to the class. This gives you everything you need to fill in with the solution. Ensure the response is in string format for the console.

> (It should look something like this when empty)

```csharp
public class Challenge1 : BaseChallenge
{
    public Challenge1(int challengeId) : base(challengeId)
    {
    }

    public override string GetPartOneAnswer() => throw new NotImplementedException();

    public override string GetPartTwoAnswer() => throw new NotImplementedException();
}
```

4. Leave the constructor there, it works as-is. Just fill out your answer methods and return your result.
5. Make sure before you run your application that you add arguments to the run configuration. Ask me if unsure how to do this (I use Rider, not VS, but this can be done in both of course)
	- This should be equivelant to the name used for your challenge / input. Case does not matter. For me, just put "chris" here.

Once you run the application it should use your name provided as an argument to load all of your challenges and run them, outputting the results to the console.
