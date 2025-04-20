using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int TimSoLonThuHai(int[] a)
{
    if (a.Length < 2)
    {
        return -1;
    }
    int max = a[0];
    int scMax = a[0];
    foreach (int i in a)
    {
        if (i > max)
        {
            scMax = max;
            max = i;
        }
        else if (i > scMax && i < max)
        {
            scMax = i;
        }
    }
    return scMax;
}

int[] a = { 21, 44, 25, 3, 7, 10, 22 };
int n = TimSoLonThuHai(a);
if (n < 0)
{
    Console.WriteLine("Khong thoa man");
}
else
{
    Console.WriteLine($"So lon thu 2 cua mang: {n}");
}