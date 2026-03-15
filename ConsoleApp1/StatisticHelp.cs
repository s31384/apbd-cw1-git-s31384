namespace ConsoleApp1;

public class StatisticHelp
{
    private List<int> numbers;
    public StatisticHelp(List<int> numbers)
    {
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
}