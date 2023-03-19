namespace ClassesStructureLecture.Abstractions;

public abstract class Human
{
    // the fields of base abstract class, can be used in child class
    public string Name { get; }
    public DateTime BirthDate { get; }
    
    // this property can be overrided (in set/get u can add some special logic)
    public virtual string Gender { get; set;}
    
    // constructor of abstract class is used by its children
    // can't be used to create and object of current class
    public Human(string name, string gender, DateTime birthDate)
    {
        Name = name;
        BirthDate = birthDate;
        Gender = gender;
    }
    
    // this method can be overrided (virtual is used)  
    public virtual string GetInfo()
    {
        var age = DateTime.UtcNow.Year - BirthDate.Year;
        
        return $"Name: {Name}, Gender: {Gender}, Age: {age}";
    }
}