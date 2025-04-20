using Lab05_1;
using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
List<PhanSo> danhSach = new List<PhanSo>();

Console.Write("Nhap so luong phan so: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"\nPhan so thu {i + 1}:");
    PhanSo ps = new PhanSo();
    ps.Nhap();
    ps.RutGon();
    danhSach.Add(ps);
}

PhanSo tong = new PhanSo(0, 1);
foreach (PhanSo ps in danhSach)
{
    tong = tong.Cong(ps);
}

Console.Write("\nTong cac phan so: ");
tong.HienThi();
