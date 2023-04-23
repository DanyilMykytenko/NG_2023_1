namespace ThreadExamples.Data;

public static class Stock
{
    public static List<Car> CarsStock = new List<Car>
    {
        new Car { Id = Guid.Parse("2fa1096d-1a5e-42c7-9b48-75a6b2aabf51"), Amount = 10, Price = 612600, Supplier = "Renault", Model = "Duster"},
        new Car { Id = Guid.Parse("d602fb92-8392-4c99-9cc2-d99e4cb7e514"), Amount = 1, Price = 1102600, Supplier = "Renault", Model = "Koleos"},
        new Car { Id = Guid.Parse("1b15745a-b8c8-49fd-b180-522ad7e28345"), Amount = 4, Price = 999900, Supplier = "Opel", Model = "Astra"},
        new Car { Id = Guid.Parse("f83f9941-44e9-455b-8789-9c17ea373d36"), Amount = 15, Price = 932600, Supplier = "Opel", Model = "Mokka"},
        new Car { Id = Guid.Parse("7d54cb9a-499b-4b85-94df-35ade283e0a9"), Amount = 2, Price = 880970, Supplier = "Toyota", Model = "Yaris"}
    };
}