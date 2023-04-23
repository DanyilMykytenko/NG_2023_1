using ThreadExamples.Data;

namespace ThreadExamples;

public class CarShowroom
{
    private void AddCarToStock(Car car)
    {
        if (Stock.CarsStock.Any(x => x.Id == car.Id))
        {
            Stock.CarsStock.First(x => x.Id == car.Id).Amount += car.Amount;
            Console.WriteLine("Added new cars to stock");
        }
        else
        {
            Stock.CarsStock.Add(car);
        }
    }

    private void RemoveCarFromStock(object? carId)
    {
        // object is used to create param for thread
        // threads can't accept other types
        
        // here i "convert" object to List 
        if (carId is List<Guid> ids)
        {
            foreach (var id in ids)
            {
                Stock.CarsStock.First(x => x.Id == id).Amount--;
                Console.WriteLine("Car has been bought");
                Thread.Sleep(7000);
            }
        }
    }

    private void DisplayStock()
    {
        // yep, it never ends
        // sometimes happens
        
        while (true)
        {
            foreach (var car in Stock.CarsStock)
            {
                Console.WriteLine($"{car.Supplier} {car.Model} : {car.Amount} : {car.Price} hrn");
            }
            Thread.Sleep(10000);
            Console.Clear();
        }
    }

    public void ThreadWorker()
    {
        Thread display = new Thread(DisplayStock);
        Thread remove = new Thread(RemoveCarFromStock);
        
        display.Start();
        remove.Start(BoughtCars.BoughtId);
        
        AddCarToStock(AddToStock.ToyotaYaris);
        Thread.Sleep(5000);
        AddCarToStock(AddToStock.ToyotaKorolla);
        Thread.Sleep(5000);
        AddCarToStock(AddToStock.RenaultKoleos);

        Console.ReadLine();
        display.Interrupt();
        remove.Interrupt();
    }
}