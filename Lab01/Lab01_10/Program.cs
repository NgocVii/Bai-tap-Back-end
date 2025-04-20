using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int n;
Console.WriteLine("Nhap so nguyen: ");
n = int.Parse(Console.ReadLine());
int dem = 0;
for (int i = 1; i <= n; i++)
{
    if (n % i == 0)
    {
        dem++;
    }
}
if (dem == 2)
{
    Console.WriteLine($"{n} la so nguyen to");
}
else
{
    Console.WriteLine($"{n} khong la so nguyen to");
}