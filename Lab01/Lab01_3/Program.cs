using System.Text;

Console.OutputEncoding = Encoding.UTF8;

double doC;
Console.Write("Nhap do C: ");
doC = double.Parse(Console.ReadLine());
double doF = (doC * 9 / 5) + 32;
Console.WriteLine($"Do C la {doC}, do F tuong ung la {doF}");