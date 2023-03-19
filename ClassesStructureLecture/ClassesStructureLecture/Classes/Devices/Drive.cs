namespace ClassesStructureLecture.Classes.Devices;

public class Drive
{
    public string Type { get; }
    public string Size { get; }
    
    // size is a param by default
    // constructor can be called like:
    // new Drive(type: "SSD")
    // new Drive("SSD", "150")

    public Drive(string type, string size = "100gb")
    {
        Type = type;
        Size = size;
    }
}