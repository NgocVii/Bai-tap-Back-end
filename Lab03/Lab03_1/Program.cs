using Lab03_1;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
QLCB qlcb = new QLCB();
string luaChon;

do
{
    Console.WriteLine("============== MENU ==============");
    Console.WriteLine("1. Can bo");
    Console.WriteLine("2. Tim kiem");
    Console.WriteLine("3. Danh sach can bo");
    Console.WriteLine("4. Thoat");
    Console.Write("Chuc nang: ");
    luaChon = Console.ReadLine();

    switch (luaChon)
    {
        case "1":
            qlcb.ThemCanBo();
            break;
        case "2":
            qlcb.TimKiemTheoHoTen();
            break;
        case "3":
            qlcb.HienThiDanhSach();
            break;
        case "4":
            Console.WriteLine("Da thoat chuong trinh.");
            break;
        default:
            Console.WriteLine("Khong hop le.\n");
            break;
    }

    Console.WriteLine();
} while (luaChon != "4");
