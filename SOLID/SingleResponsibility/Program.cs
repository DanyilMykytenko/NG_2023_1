void GetSumOfNumbers(int a, int b)
{
    Console.WriteLine(a + b);
}
int GetNumber()
{
    return int.Parse(Console.ReadLine());
}

GetSumOfNumbers(GetNumber(), GetNumber());