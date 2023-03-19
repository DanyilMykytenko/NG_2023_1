namespace ClassesStructureLecture.Structures;

// just a struct
public struct User
{
    public string Name { get; set; }
    private int Age { get; set; }

    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // get method for private field
    public int GetAge()
    {
        return Age;
    }
}