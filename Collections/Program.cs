//var people = new Stack<string>();
//people.Push("Tom");
//people.Push("Sam"); 
//
//string lastelement = people.Peek();
//Console.WriteLine(lastelement);
//string person2 = people.Pop();
//Console.WriteLine(person2);
//foreach (var human in people) Console.WriteLine(human);
//var phonebook = new Dictionary<int, string>();
//phonebook.Add(1,"Vadim");
//var phoneExist = phonebook.ContainsKey(2);
//Console.WriteLine(phoneExist);

//List<Person> people = new List<Person>()
//{
//    new Person("Tom","Street1",DateTime.Now.AddYears(-10),"qwerty1234"),
//    new Person("Bob","Street2",DateTime.Now.AddYears(-6),"qwerty5432"),
//    new Person("Sam","Street3",DateTime.Now.AddYears(-4),"qwerty1234"),
//    new Person("Vadim","Street4",DateTime.Now.AddYears(-4),"qwerty1234"),
//    new Person("Alex","Street5",DateTime.Now.AddYears(-4),"qwerty1234")
//};
//List<Employee> employees = new List<Employee>()
//{
//    new Employee("Tom", 1000),
//    new Employee("Bob", 500),
//    new Employee("Sam", 200)
//};
//
//var findBob = from s in people where s.Name == "Bob" select s;
////var exampleFirst = people.First(x => x.Name.Equals("Alex")).Address;
//var exampleSecond = people.FirstOrDefault(x=>x.Name.Equals("Bob"));
//var selected = people.Where(x => employees.Any(y => y.FirstName == x.Name));
//
//foreach(var human in selected)
//{
//    Console.WriteLine($"{human.Name}:{human.Address}\n");
//}
//
////Console.WriteLine(exampleSecond);
//
////foreach (var p in findBob) {Console.WriteLine(p.Name);}
//
//
//
//class Person
//{
//    public string Name { get;}
//    public string Address { get;}
//    public DateTime Birthday { get;}
//    public string Password { get;}
//    public Person(string name, string address,
//        DateTime birthday, string password) =>
//        (Name, Address, Birthday, Password) = (name, address, birthday, password);
//}
//class Employee
//{
//    public string FirstName { get; }
//    public int Salary { get; }
//    public Employee(string firstName, int salary)
//    {
//        FirstName = firstName;
//        Salary = salary;
//    }
//}