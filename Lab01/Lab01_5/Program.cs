using System.Text;

Console.OutputEncoding = Encoding.UTF8;

double a, b;
Console.Write("Nhap so dau tien: ");
a = double.Parse(Console.ReadLine());
Console.Write("Nhap so thu hai: ");
b = double.Parse(Console.ReadLine());
double tong = a + b;
double tich = a * b;
Console.WriteLine($"Tong 2 so: {tong}\nTich 2 so: {tich}");