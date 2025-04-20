using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int n;
Console.Write("Nhap so nguyen: ");
n = int.Parse(Console.ReadLine());
if (n > 0)
{
    Console.WriteLine($"{n} la so duong");
}
else if (n < 0)
{
    Console.WriteLine($"{n} la so am");
}
else
{
    Console.WriteLine($"{n} khong la so am va so duong");
}