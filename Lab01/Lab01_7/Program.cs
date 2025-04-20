using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int nam;
Console.WriteLine("Nhap nam: ");
nam = int.Parse(Console.ReadLine());
if (nam % 100 == 0)
{
    if (nam % 4 == 0)
    {
        Console.WriteLine($"{nam} la nam nhuan");
    }
    else
    {
        Console.WriteLine($"{nam} khong la nam nhuan");
    }
}
else
{
    if (nam % 4 == 0)
    {
        Console.WriteLine($"{nam} la nam nhuan");
    }
    else
    {
        Console.WriteLine($"{nam} khong la nam nhuan");
    }
}