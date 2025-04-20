using System.Text;

Console.OutputEncoding = Encoding.UTF8;

bool LaSoNguyenTo(int n)
{
    if (n < 2) return false;
    if (n == 2) return true;

    for (int i = 2; i < Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}

int n;
Console.Write("Nhap so phan tu cua mang: ");
n = int.Parse(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Nhap phan tu thu {i + 1}: ");
    a[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < n; i++)
{
    if (LaSoNguyenTo((int)a[i]))
    {
        Console.WriteLine($"{a[i]} la nguyen to, o vi tri thu {i + 1}");
    }
}