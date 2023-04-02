using System.Text;

namespace Lesson5_WorkWithFiles.WorkWithFiles;

public static class StreamUsing
{
    public static void ReadFromFile(string path)
    {
        using (FileStream fstream = File.OpenRead(path))
        {
            var bytes = new byte[fstream.Length];
            
            fstream.Read(bytes, 0, bytes.Length);

            string result = Encoding.Default.GetString(bytes);
            Console.WriteLine(result);
        }
    }
    
    public static void WriteToFile(string path, string text)
    {
        // you can write using in one line
        
        using FileStream fstream = new FileStream(path, FileMode.OpenOrCreate);
        var bytes = Encoding.Default.GetBytes(text);
            
        fstream.Write(bytes, 0, bytes.Length);
        Console.WriteLine("Written");
    }
}