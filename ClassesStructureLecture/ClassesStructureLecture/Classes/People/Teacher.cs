using ClassesStructureLecture.Abstractions;

namespace ClassesStructureLecture.Classes.People;

// Teacher inherits from abstract Human
public class Teacher : Human
{
    public string Speciality { get; set; }
    public string School { get; set; }

    public Teacher
        (
            string name,
            string gender,
            DateTime birthDate
        ) 
        : base(name, gender, birthDate)
    {
    }
    
    // override of GetInfo is not implemented
    // base method is used by default
}