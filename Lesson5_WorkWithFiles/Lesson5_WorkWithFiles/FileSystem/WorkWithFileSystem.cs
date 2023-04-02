namespace Lesson5_WorkWithFiles.FileSystem;

public static class WorkWithFileSystem
{
    public static void GetDrives()
    {
        var drives = DriveInfo.GetDrives();

        foreach (var drive in drives)
        {
            Console.WriteLine($"Name: {drive.Name}");
            Console.WriteLine($"Size: {drive.TotalSize * Math.Pow(10, -9) }");
            Console.WriteLine($"Free: {drive.AvailableFreeSpace * Math.Pow(10, -9) }");

            Console.WriteLine("-------------------");
        }
    }

    public static void GetCurrentDirectoryFiles()
    {
        var dir = Directory.GetCurrentDirectory();
        var files = new List<string>();
        files.AddRange(Directory.GetDirectories(dir));
        files.AddRange(Directory.GetFiles(dir));

        foreach (var file in files)
        {
            Console.WriteLine(file.Split('\\').Last());
        }
    }

    // cd variant with SetCurrentDirectoryMethod
    public static void SetCurrentDirectory(string name, string current)
    {
        if (name == "./")
        {
            var info = new DirectoryInfo(current);

            var parent = info.Parent;
            
            if(parent is null) return;
            
            Directory.SetCurrentDirectory(parent.FullName);
        }
        
        var dir = Path.Combine(current, name);
        
        if (Directory.Exists(dir))
        {
            Directory.SetCurrentDirectory(dir);
        }
    }

    public static void GetDirectoryFiles(string path)
    {
        var current = new DirectoryInfo(path);
        var dirs = Directory.GetFiles(current.FullName);
        var files = Directory.GetDirectories(current.FullName);
        
        foreach (var dir in dirs)
        {
            Console.WriteLine(dir.Split('\\').Last() + "/");
        }
        foreach (var file in files)
        {
            Console.WriteLine(file.Split('\\').Last() + "/");
        }
    }

    public static string Cd(string? name, string current)
    {
        if (name == "./")
        {
            var info = new DirectoryInfo(current);

            var parent = info.Parent;

            return parent is not null ? parent.FullName : current;
        }
        
        var dir = Path.Combine(current, name);
        
        if (Directory.Exists(dir))
        {
            return dir;
        }

        return current;
    }
}