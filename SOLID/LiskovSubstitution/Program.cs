using LiskovSubstitution;

var autos = new List<Auto>();

var audi = new Audi()
{
    AudiFeature = "WOW",
    Company = "audi",
    Model = "ogo"
};
var reno = new Reno()
{
    RenoFeature = 123,
    Company = "reno",
    Model = "awesome"
};

autos.Add(audi);
autos.Add(reno);

foreach(var auto in autos)
{
    auto.GetInfo();
    Console.WriteLine($"OUR TYPE IS: {auto.GetType()}");
}