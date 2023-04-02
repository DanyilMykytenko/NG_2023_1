namespace Lesson5_WorkWithFiles.WorkWithFiles;

public static class FileInfoOperation
{
    public static string CreateFile(string dir, string name)
    {
        var path = Path.Combine(dir, name);

        var file = new FileInfo(path);
        if (!file.Exists) file.Create();

        return file.FullName;
    }

    public static void GetFileInfo(string path)
    {
        var info = new FileInfo(path);
        
        Console.WriteLine($"Name: {info.Name}");
        Console.WriteLine($"Name: {info.CreationTime}");
        Console.WriteLine($"Name: {info.Length}");
    }

    public static void MoveFile(string filePath, string newPath)
    {
        var fileInfo = new FileInfo(filePath);
        newPath = Path.Combine(newPath, fileInfo.Name);
        
        fileInfo.MoveTo(newPath);
    }
}