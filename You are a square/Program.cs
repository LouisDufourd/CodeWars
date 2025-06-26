for (double i = double.MinValue; i <= double.MaxValue; i+= 100000000000)
{
    Console.WriteLine($"{i} / ε: {i / double.Epsilon}");
}