using System.Text;

Console.OutputEncoding = Encoding.UTF8;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Bang nhan voi so {i}");
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i}x{j}={i * j}");
    }
}