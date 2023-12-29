using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap03
{
    class Phanso
    {
        private int tuSo;
        private int mauSo;

        public Phanso()
        {
            tuSo = 0;
            mauSo = 1;
        }
        public Phanso(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }
        public void setTuso()
        {
            this.tuSo = tuSo;
        }
        public int getTuso()
        {
            return tuSo;
        }
        public void setMauso()
        {
            this.mauSo = mauSo;
        }
        public int getMauso()
        {
            return mauSo;
        }
        public void toiGian()
        {
            int UCLN = timUCLN(tuSo, mauSo);
            tuSo = tuSo / UCLN;
            mauSo = mauSo / UCLN;
        }
        public int timUCLN(int a, int b)
        {
            int x = Math.Abs(a);
            int y = Math.Abs(b);
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }
            return x;
        }
        public Phanso tinhTong(Phanso ps)
        {
            Phanso kq = new Phanso();
            kq.tuSo = tuSo * ps.mauSo + ps.tuSo * mauSo;
            kq.mauSo = mauSo * ps.mauSo;
            return kq;
        }
        public Phanso tinhHieu(Phanso ps)
        {
            Phanso kq = new Phanso();
            kq.tuSo = tuSo * ps.mauSo - ps.tuSo * mauSo;
            kq.mauSo = mauSo * ps.mauSo;
            return kq;
        }
        public Phanso tinhTich(Phanso ps)
        {
            Phanso kq = new Phanso();
            kq.tuSo = tuSo * ps.tuSo;
            kq.mauSo = mauSo * ps.mauSo;
            return kq;
        }
        public Phanso tinhThuong(Phanso ps)
        {
            Phanso kq = new Phanso();
            kq.tuSo = tuSo * ps.mauSo;
            kq.mauSo = mauSo * ps.tuSo;
            return kq;
        }
    }
}
