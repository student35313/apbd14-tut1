class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        double average = CalculateAverage(numbers);
        Console.WriteLine($"Average: {average}");
    }

    static double CalculateAverage(int[] numbers)
    {
        if (numbers.Length == 0) return 0;
        
        double sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum / numbers.Length;
    }
}