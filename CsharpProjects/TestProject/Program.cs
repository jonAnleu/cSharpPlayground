string[] values = ["12.3", "45", "ABC", "11", "DEF"];

decimal total = 0m;
string message = "";

for (int i = 0; i < values.Length; i++)
{
    decimal number;
    if (decimal.TryParse(values[i], out number))
    {
        total += number;
    } else
    {
        message += values[i];
    }
 
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");

