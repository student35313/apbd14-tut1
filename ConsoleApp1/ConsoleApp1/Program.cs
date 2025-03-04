class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        double average = CalculateAverage(numbers);
        int max = FindMaxValue(numbers);
        
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Maximum Value: {max}");
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

    static int FindMaxValue(int[] numbers)
    {
        if (numbers.Length == 0) throw new ArgumentException("Array cannot be empty");
        
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }
}