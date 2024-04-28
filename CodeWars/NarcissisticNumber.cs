namespace CodeWars;

public static class NarcissisticNumber
{
    private const int BASE = 10;
    
    public static bool IsNarcissistic(int value)
    {
        int total = 0;
        int length = (int)MathF.Log10(value) + 1;
        var digits = Digits(value);
        foreach (int d in digits)
        {
            int powered = (int)Math.Pow(d, length);
            total += powered;
        }

        return total == value;
    }

    private static IEnumerable<int> Digits(int value)
    {
        int factor = 1;
        int division = int.MaxValue;
        while (division > 0)
        {
            division = value / factor;
            int digit = division % BASE;
            factor *= BASE;
            if (division == 0) yield break;
            yield return digit;
        }
    }
}
