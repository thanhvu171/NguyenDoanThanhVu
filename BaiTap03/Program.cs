using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap03
{
    class Program
    {
        static void Main(string[] args)
        {
            Phanso PS1;
            Phanso PS2;

            Console.WriteLine("Nhap phan so thu nhat");
            Console.Write("Tu so: ");
            int tuSo = int.Parse(Console.ReadLine());
            Console.Write("Mau so: ");
            int mauSo = int.Parse(Console.ReadLine());
            PS1 = new Phanso(tuSo, mauSo);

            Console.WriteLine("Nhap phan so thu hai");
            Console.Write("Tu so: ");
            tuSo = int.Parse(Console.ReadLine());
            Console.Write("Mau so: ");
            mauSo = int.Parse(Console.ReadLine());
            PS2 = new Phanso(tuSo, mauSo);

            Phanso tong = PS1.tinhTong(PS2);
            Console.WriteLine("Tong cua 2 phan so la: {0}/{1} + {2}/{3} = {4}/{5}", PS1.getTuso(), PS1.getMauso(), PS2.getTuso(), PS2.getMauso(), tong.getTuso(), tong.getMauso());
            Phanso hieu = PS1.tinhHieu(PS2);
            Console.WriteLine("Hieu cua 2 phan so la: {0}/{1} - {2}/{3} = {4}/{5}", PS1.getTuso(), PS1.getMauso(), PS2.getTuso(), PS2.getMauso(), hieu.getTuso(), hieu.getMauso());
            Phanso tich = PS1.tinhTich(PS2);
            Console.WriteLine("Tich cua 2 phan so la: {0}/{1} * {2}/{3} = {4}/{5}", PS1.getTuso(), PS1.getMauso(), PS2.getTuso(), PS2.getMauso(), tich.getTuso(), tich.getMauso());
            Phanso thuong = PS1.tinhTong(PS2);
            Console.WriteLine("Thuong cua 2 phan so la: {0}/{1} / {2}/{3} = {4}/{5}", PS1.getTuso(), PS1.getMauso(), PS2.getTuso(), PS2.getMauso(), thuong.getTuso(), thuong.getMauso());

            int N;
            N = nhapSonguyencoDK("Nhap so nguyen duong n: ", "Nhap so nguyen duong n: ");

            Phanso s = new Phanso();
            for (int i = 1; i <= N; i++) 
                s = s.tinhTong(new Phanso(1, i));
            
            Console.WriteLine("Ket qua cua day so: 1 + 1/2 + 1/3 + ... + 1/n = {0}/{1}", s.getTuso(), s.getMauso());

            Console.ReadKey();

        }
        static int nhapSonguyencoDK(string ghichu1, string ghichu2)
        {
            bool flag = true;
            int n;
            do
            {
                if (flag)
                {
                    Console.Write(ghichu1);
                    n = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write(ghichu2);
                    n = int.Parse(Console.ReadLine());
                }
                flag = false;
            } while (n < 1);
            return n;
        }
    }
}
