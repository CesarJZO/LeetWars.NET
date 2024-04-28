using CodeWars;

namespace Tests;

public sealed class NarcissisticNumberTests
{
    [Theory]
    [InlineData(153)]
    [InlineData(371)]
    public void Narcissistics(int value)
    {
        Assert.True(NarcissisticNumber.IsNarcissistic(value), $"{value} is not Narcissistic");
    }

    [Theory]
    [InlineData(1652)]
    public void NotNarcissistics(int value)
    {
        Assert.False(NarcissisticNumber.IsNarcissistic(value), $"{value} is Narcissistic");
    }
}