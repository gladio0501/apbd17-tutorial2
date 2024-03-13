

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

static int FindMax(int[] array)
{
    if (array == null || array.Length == 0)
    {
        throw new ArgumentException("Array cannot be null or empty");
    }

    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int[] numbers = { 5, 3, 9, 2, 7 };
int max = FindMax(numbers);
Console.WriteLine("The maximum value is: " + max);