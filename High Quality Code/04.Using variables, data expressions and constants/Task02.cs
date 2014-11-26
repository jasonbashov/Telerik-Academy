
public void PrintStatistics(double[] arrayToGetStats, int searchLimitIndex = arrayToGetStats.Length)
{
    double max = double.MinValue;
    double currentSum;
    double min = double.MaxValue;
    for (int i = 0; i < searchLimitIndex; i++)
    {
        if (arrayToGetStats[i] > max)
        {
            max = arrayToGetStats[i];
        }
    }

    PrintResult(max);

    for (int i = 0; i < searchLimitIndex; i++)
    {
        if (arrayToGetStats[i] < min)
        {
            min = arrayToGetStats[i];
        }
    }

    PrintResult(min);

    currentSum = 0;
    for (int i = 0; i < searchLimitIndex; i++)
    {
        currentSum += arrayToGetStats[i];
    }

    PrintResult(currentSum / searchLimitIndex);
}
    