using System.Text;

Console.OutputEncoding = Encoding.UTF8;

void DemSoLuong(int[] a)
{
    int demAm, demDuong;
    demAm = demDuong = 0;
    foreach (int i in a)
    {
        if (i < 0)
        {
            demAm++;
        }
        else if (i > 0)
        {
            demDuong++;
        }
    }
    Console.WriteLine($"So luong so am: {demAm}\nSo luong so duong: {demDuong}");
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
DemSoLuong(a);