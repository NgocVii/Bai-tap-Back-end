
namespace Lab03_2
{
    internal class Tailieu
    {
        private int maTaiLieu;
        private string tenNhaXuatBan;
        private int soBanPhatHanh;

        public Tailieu(int maTaiLieu, string tenNhaXuatBan, int soBanPhatHanh)
        {
            this.maTaiLieu = maTaiLieu;
            this.tenNhaXuatBan = tenNhaXuatBan;
            this.soBanPhatHanh = soBanPhatHanh;
        }

        internal void Hienthi()
        {
            throw new NotImplementedException();
        }

        internal void Nhap()
        {
            throw new NotImplementedException();
        }

        public static implicit operator Tailieu(TapChi v)
        {
            throw new NotImplementedException();
        }
    }
}