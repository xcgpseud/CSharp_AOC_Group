using AdventOfCode.Enums;

namespace AdventOfCode;

public static class Constants
{
    public static class Files
    {
        private const string Base = "./Inputs";

        public static string GetFile(Name name, string fileName) => $"{Base}/{GetNamePathFromEnum(name)}/{fileName}";

        public static string GetNamePathFromEnum(Name name) => name switch
        {
            Name.Chris => Names.Chris,
            Name.Eddie => Names.Eddie,
            Name.Matt => Names.Matt,
            _ => string.Empty,
        };
    }

    public static class Names
    {
        public const string Chris = "Chris";
        public const string Eddie = "Eddie";
        public const string Matt = "Matt";
    }
}