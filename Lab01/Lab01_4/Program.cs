using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int n;
Console.Write("Nhap vao mot so nguyen: ");
n = int.Parse(Console.ReadLine());
if (n % 2 == 0)
{
    Console.WriteLine($"{n}: so chan");
}
else
{
    Console.WriteLine($"{n}: so le");
}