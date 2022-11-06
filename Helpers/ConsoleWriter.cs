using Spectre.Console;

namespace Helpers;

public static class ConsoleWriter
{
    public static void WriteAnswer<T>(string prefix, T answer)
    {
        AnsiConsole.MarkupLine($"[bold red]{prefix}: [/][underline green]{answer}[/]");
    }
}