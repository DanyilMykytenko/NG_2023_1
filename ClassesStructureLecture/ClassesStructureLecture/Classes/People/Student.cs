using ClassesStructureLecture.Abstractions;

namespace ClassesStructureLecture.Classes.People;

// Student is inherited from abstract Human
public class Student : Human
{
    public string University { get; set; }
    public string Group { get; set; }

    // constructor for class Student, where base is a
    // parent class
    public Student
        (
            string name,
            string gender, 
            DateTime birthDate
        ) 
        : base(name, gender, birthDate)
    {
        // yeap, it is empty
        // but you can add some logic here
    }

    // current method replaces base GetInfo
    public override string GetInfo()
    {
        // but base.GetInfo can still be used inside of current class
        var baseInfo = base.GetInfo();
        
        return baseInfo + $", University: {University}, Group: {Group}";
    }
}