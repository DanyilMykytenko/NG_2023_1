namespace ClassesStructureLecture.Classes.Devices;

// base class, that can be inherited
public class Device
{
    // protected fields can be used by this class and its children
    protected string Supplier { get; set; }
    protected string Country { get; set; }
    public string Price { get; set; }
    
    // public method that used to get supplier fields(protected) in any
    // point of application

    public string GetSupplierInfo()
    {
        return $"Produced in {Country} by {Supplier}";
    }
}