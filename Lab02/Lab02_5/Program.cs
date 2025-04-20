using System.Text;

Console.OutputEncoding = Encoding.UTF8;

void HoanDoi(ref int a, ref int b)
{
    int c = a;
    a = b;
    b = c;
}

int a, b;
Console.Write("Nhap so a: ");
a = int.Parse(Console.ReadLine());
Console.Write("Nhap so b: ");
b = int.Parse(Console.ReadLine());
HoanDoi(ref a, ref b);
Console.WriteLine($"a va b sau khi hoan doi: a - {a}, b - {b}");