using System.Text;

namespace MacheteBang.Playground.Console.Services;

public static class ConversionService
{
    public static string I2A(int value)
    {
        StringBuilder builder = new();
        int originalValue = value;

        value = Math.Abs(value);

        while (value >= 10)
        {
            int digit = value % 10;
            value = (value - digit) / 10;
            builder.Insert(0, digit);
        }

        builder.Insert(0, value);

        if (originalValue < 0) builder.Insert(0, '-');

        return builder.ToString();
    }
}