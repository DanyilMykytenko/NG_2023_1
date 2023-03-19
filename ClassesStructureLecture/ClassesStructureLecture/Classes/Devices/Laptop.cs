namespace ClassesStructureLecture.Classes.Devices;

// class Laptop is inherited from Device
// so it has all fields and methods of Device class except of private ones
public class Laptop : Device
{
    public string Gui { get; set; }
    public string Processor { get; set; }

    // another custom class is used inside of Laptop one
    public List<Drive> Drivers { get; set; } = new List<Drive>();

    public Laptop(string gui, string processor)
    {
        Gui = gui;
        Processor = processor;
    }

    public Laptop()
    {
    }

    // current method is used to set values to 
    // protected fields in Device class
    
    public void SetSupplier(string supplier, string country)
    {
        Supplier = supplier;
        Country = country;
    }
}