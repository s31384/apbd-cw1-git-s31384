namespace ConsoleApp1;

public class StatisticHelp
{
    private List<int> numbers;
    public StatisticHelp(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            throw new ArgumentException("You must provide at least one number");
        }
        this.numbers = numbers;
        
    }

    public int GetSum()
    {
        int sum = 0;
        foreach (int i in numbers )
        {
            sum += i;
        }
        return sum;
    }

    public double GetAverage()
    {
        double avarage = numbers.Average();
        return avarage;
    }

    public int GetMax()
    {
        int max = numbers.Max();
        return max;
    }

    public int GetMin()
    {
        return numbers.Min();
    }
}