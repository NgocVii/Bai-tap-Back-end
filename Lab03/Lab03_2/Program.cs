using Lab03_2;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Quanlitailieu ql = new Quanlitailieu();
string chon;

do
{
    Console.WriteLine("\n=== MENU ===");
    Console.WriteLine("1. Nhap tai lieu");
    Console.WriteLine("2. Hien thi tai lieu");
    Console.WriteLine("3. Tim kiem");
    Console.WriteLine("4. Thoat");
    Console.Write("Chuc nang: ");
    chon = Console.ReadLine();

    switch (chon)
    {
        case "1":
            ql.ThemTaiLieu();
            break;
        case "2":
            ql.HienThiTatCa();
            break;
        case "3":
            ql.TimKiemTheoLoai();
            break;
        case "4":
            Console.WriteLine("Thoat chuong trinh.");
            break;
        default:
            Console.WriteLine("Khong hop le!");
            break;
    }

} while (chon != "4");
