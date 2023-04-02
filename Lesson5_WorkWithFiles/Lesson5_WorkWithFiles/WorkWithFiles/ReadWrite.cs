namespace Lesson5_WorkWithFiles.WorkWithFiles;

public static class ReadWrite
{
    public static void ReadByPath(string path)
    {
        var text = File.ReadLines(path);

        foreach (var str in text)
        {
            Console.WriteLine(str);   
        }
    }

    public static void WriteToFile(string text, string path)
    {
        File.WriteAllText(text, path);
    }
}