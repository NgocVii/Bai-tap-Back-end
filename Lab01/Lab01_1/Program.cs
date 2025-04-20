using System.Text;

Console.OutputEncoding = Encoding.UTF8;

string ten;
int tuoi;
Console.Write("Nhap twn: ");
ten = Console.ReadLine();
Console.Write("Nhap tuoi: ");
tuoi = int.Parse(Console.ReadLine());
Console.WriteLine($"Xin chao {ten}, ban {tuoi} tuoi!");
