string[] values = { "12.3", "45", "ABC", "11", "DEF" };

string message = "";
float total = 0;

foreach (string value in values)
{
    float num;
    if (float.TryParse(value, out num))
    {
        total += num;
    }
    else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");