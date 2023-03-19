using ClassesStructureLecture.Classes.Devices;

namespace ClassesStructureLecture.Static;

// static classes are created when application starts
// don't need the creation of an object

public static class DriveExtension
{
    
    // example of extension method (this is used)
    // can be called using . operator (laptop.GetSsdDrives())
    public static List<Drive> GetSsdDrives(this Laptop laptop)
    {
        return laptop.Drivers.Where(x => x.Type == "SSD").ToList();
    }

    // example of overloaded method
    // the same name but different args
    public static List<Drive> GetSsdDrives(this Laptop laptop, int minSize)
    {
        var result = laptop.Drivers
            .Where(x => x.Type == "SSD")
            .Where(x => x.Type.Remove(x.Type.IndexOf('g'), 2) == minSize.ToString())
            .ToList();
            
        return result;
    }

    // usual static method
    // can be called using DriveExtension.HasHdd(laptop);
    public static bool HasHdd(Laptop laptop)
    {
        return laptop.Drivers.Any(x => x.Type == "HDD");
    }
}