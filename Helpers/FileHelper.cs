namespace Helpers;

public static class FileHelper
{
    public static string[] GetFileLines(string fileName)
    {
        return File.ReadLines($"{fileName}").ToArray();
    }

    public static T[] GetFileLines<T>(string fileName, Func<string, T> convertFunc)
    {
        var lines = GetFileLines(fileName);
        return lines.Select(convertFunc).ToArray();
    }
}