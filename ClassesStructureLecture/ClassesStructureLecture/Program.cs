using ClassesStructureLecture.Classes.Devices;
using ClassesStructureLecture.Classes.People;
using ClassesStructureLecture.Static;
using ClassesStructureLecture.Structures;

/* structs */

// struct is created, but has no values or values by default
var user1 = new User();
// struct is created using constructor
var user2 = new User("John", 21);
// struct is created, but private properties can't be set in this case
var user3 = new User { Name = "John" };

// usage of struct fields and methods
Console.WriteLine($"Name {user2.Name}, Age {user1.GetAge()}");

/* classes */

var drive = new Drive("HDD", "120gb");
// var drive = new Drive {  }; can't be used, because properties have no setters

/* inheritance */

var drives = new List<Drive>
{
    new Drive("HDD"),
    new Drive("SSD"),
    new Drive("SSD", "200gb")
};

var laptop = new Laptop
{ 
    Gui = "Nvidia 1650",
    Processor = "Ryzen 5 2400",
    Price = "500$",
    Drivers = drives
};
// laptop is created, but supplier is empty now

// public method from class Laptop is used to set protected fields from device class
laptop.SetSupplier("ASUS", "China");

// method from class device is called to get supplier info
Console.WriteLine(laptop.GetSupplierInfo());

/* static class usage */

// static method is used
Console.WriteLine(DriveExtension.HasHdd(laptop));

// extension method is used
var ssdDrives = laptop.GetSsdDrives();
foreach (var ssd in ssdDrives)
{
    Console.Write($"{ssd.Type} {ssd.Size}; ");
}

/* abstract and polymorphism */

// in () we set params for abstract constructor
var student = new Student("Jack", "male", DateTime.UtcNow.AddYears(-20))
{
    // here we set properties with setters, that are not in constructor
    Group = "KI-20",
    University = "CNTU"
};

var teacher = new Teacher("Ihor", "male", DateTime.UtcNow.AddYears(-40))
{
    School = "№34",
    Speciality = "History and Law"
};

// both classes are inherited from abstract Human, but have different properties and methods

// student uses its own GetInfo method
Console.WriteLine(student.GetInfo());
// teacher uses base GetInfo
Console.WriteLine(teacher.GetInfo());
