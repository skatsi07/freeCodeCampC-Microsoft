string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string alpha = "";
decimal sum = 0;

foreach (string value in values)
{
    if (decimal.TryParse(value, out decimal parsed))
    {
        sum += parsed;
    }
    else
    {
        alpha += value;
    }
}
Console.WriteLine($"Message: {alpha}");
Console.WriteLine($"Total: {sum}");