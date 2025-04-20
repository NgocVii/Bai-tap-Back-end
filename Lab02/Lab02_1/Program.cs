using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int TinhTongSoChan(int[] a)
{
    int tong = 0;
    foreach (int i in a)
    {
        if (i % 2 == 0)
        {
            tong += i;
        }
    }
    return tong;
}

int[] a = { 21, 44, 25, 3, 7, 10, 22 };
int tong = TinhTongSoChan(a);
Console.WriteLine("Tong cac so chan cua mang: " + tong);
