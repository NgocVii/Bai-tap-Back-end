using System.Text;

Console.OutputEncoding = Encoding.UTF8;

double dai, rong;
Console.Write("Chieu dai: ");
dai = double.Parse(Console.ReadLine());
Console.Write("Chieu rong: ");
rong = double.Parse(Console.ReadLine());
double dienTich = dai * rong;
Console.WriteLine($"Dien tich hinh chu nhat: {dienTich}");