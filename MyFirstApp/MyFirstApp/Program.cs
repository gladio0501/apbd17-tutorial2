// See https://aka.ms/new-console-template for more inform

Console.WriteLine("Hello, World!");
for (int i = 0; i < 5; i++) 
{
    Console.WriteLine(i);
}
// My mum is awesome 
static double GetAverage(int[] numbers)
{
    double sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }

    return sum / numbers.Length;
}