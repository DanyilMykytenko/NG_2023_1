using System.Diagnostics;

string url = "https://raw.githubusercontent.com/l3oxer/Doggo/main/README.md";

Stopwatch sw = new Stopwatch();
sw.Start();

var tasks = new List<Task> { SummonDoggyAsync(), SummonDoggyByUrlAsync(url) };
await Task.WhenAll(tasks);

sw.Stop();

Console.WriteLine($"This took: {sw.Elapsed.TotalSeconds}");

async Task SummonDoggyAsync()
{
    Console.WriteLine("1. Summoning doggy locally!");
    string doggo = await File.ReadAllTextAsync("doge.txt");
    Console.WriteLine("2. Doggy summoned locally!");
    Console.WriteLine(doggo);
}

//async Task<string> ReturnDoggyAsync()
//{
//    var doggo = await File.ReadAllTextAsync("doge.txt");
//    return doggo;
//}

async Task SummonDoggyByUrlAsync(string url)
{
    Console.WriteLine("1. Summoning doggy by url!");
    using (var httpClient = new HttpClient())
    {
        string doggo = await httpClient.GetStringAsync(url);
        Console.WriteLine("2. Doggy summoned from url!");
        Console.WriteLine(doggo);
    }
}