using AdventOfCode.Enums;
using AdventOfCode.Interfaces.Challenges;
using Option;

namespace AdventOfCode;

public static class Program
{
    public static void Main(string[] args)
    {
        var name = args.FirstOrDefault(string.Empty).ToLower() switch
        {
            "chris" => Name.Chris,
            "eddie" => Name.Eddie,
            "matt" => Name.Matt,
            _ => Name.Chris,
        };

        var classNamespace = $"AdventOfCode.Challenges.{name.ToString()}";

        for (var i = 1; i <= 25; i++)
        {
            // Run the challenge if it exists
            var classType = Option<Type>.From(Type.GetType($"{classNamespace}.Challenge{i}"));
            classType.IfValid(t =>
            {
                var challenge = (IChallenge?)Activator.CreateInstance(t, i);
                challenge?.Run();
            });
        }
    }
}