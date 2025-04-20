using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_1
{
    internal class QLCB
    {
        private CanBo[] danhSachCanBo = new CanBo[100];
        private int soLuong = 0;

        public void ThemCanBo()
        {
            if (soLuong >= danhSachCanBo.Length)
            {
                Console.WriteLine("==> Danh sach day.");
                return;
            }

            Console.WriteLine("\nChon loai can bo:");
            Console.WriteLine("1. Cong nhan");
            Console.WriteLine("2. Ky su");
            Console.WriteLine("3. Nhan vien");
            Console.Write("Lua chon: ");
            string chon = Console.ReadLine();

            CanBo cb = null;

            switch (chon)
            {
                case "1":
                    cb = new CongNhan();
                    break;
                case "2":
                    cb = new KySu();
                    break;
                case "3":
                    cb = new NhanVien();
                    break;
                default:
                    Console.WriteLine("Khong hop le.");
                    return;
            }

            cb.Nhap();
            danhSachCanBo[soLuong] = cb;
            soLuong++;

            Console.WriteLine("==> Them can bo!\n");
        }

        public void TimKiemTheoHoTen()
        {
            Console.Write("Nhap ho ten: ");
            string ten = Console.ReadLine();
            bool timThay = false;

            Console.WriteLine("\n==> Ket qua:");
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSachCanBo[i].HoTen.ToLower().Contains(ten.ToLower()))
                {
                    danhSachCanBo[i].HienThi();
                    Console.WriteLine();
                    timThay = true;
                }
            }

            if (!timThay)
            {
                Console.WriteLine("==> Khong tim thay.");
            }
        }

        public void HienThiDanhSach()
        {
            Console.WriteLine("\n==> Danh sach can bo:");
            for (int i = 0; i < soLuong; i++)
            {
                danhSachCanBo[i].HienThi();
                Console.WriteLine();
            }
        }
    }
}
