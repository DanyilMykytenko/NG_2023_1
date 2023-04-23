namespace ThreadExamples.Data;

public static class AddToStock
{
    public static Car ToyotaYaris = new Car { Id = Guid.Parse("7d54cb9a-499b-4b85-94df-35ade283e0a9"), Amount = 3 };
    public static Car RenaultKoleos = new Car { Id = Guid.Parse("d602fb92-8392-4c99-9cc2-d99e4cb7e514"), Amount = 6 };

    public static Car ToyotaKorolla = new Car
    {
        Id = Guid.Parse("22aa1bc0-3698-48e3-8fc7-d5c670144fb8"),
        Amount = 10,
        Price = 795900, 
        Supplier = "Toyota",
        Model = "Corolla"
    };
}