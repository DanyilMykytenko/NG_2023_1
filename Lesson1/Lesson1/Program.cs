List<int> numbers = new List<int>();
for (int i = 0; i < 10; i++)
{
    numbers.Add(i);
}
foreach(int i in numbers)
{
    Console.WriteLine($"Number {i+1}: {i}");
}
//List<int> numbers = new List<int>();
//for (int i = 0; i <= 10; i++)
//{
//    numbers.Add(i);
//}
//for (int i = 0; i <= numbers.Count; i++)
//{
//    if (i % 2 == 0)
//        numbers.Remove(i);
//    else
//        continue;
//}
//foreach (int i in numbers)
//{
//    Console.WriteLine(i);
//}
//int GetNumberPlusTen(int number)
//{
//    return number + 10;
//}
//
//Console.WriteLine(GetNumberPlusTen(10));
//void GetNumberPlusTen(int number)
//{
//    Console.WriteLine(number + 10);
//}
//
//GetNumberPlusTen(10);