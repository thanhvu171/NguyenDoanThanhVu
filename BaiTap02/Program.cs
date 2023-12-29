using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vui long tao tai khoan thu nhat");
            Console.Write("Id account: ");
            string id = Console.ReadLine();
            Console.Write("Name account: ");
            string name = Console.ReadLine();
            int balance = 500;
            Console.WriteLine("Balance: {0}", balance);

            Account my = new Account(id, name, balance);

            Console.WriteLine("Vui long tao tai khoan thu hai");
            Console.Write("Id account: ");
            string friendId = Console.ReadLine();
            Console.Write("Name account: ");
            string friendName = Console.ReadLine();
            int friendBalance = 0;
            Console.WriteLine("Balance: {0}", friendBalance);

            Account myFriend = new Account(friendId, friendName, friendBalance);

            Console.WriteLine("My account: \n ID: {0}\n Name: {1}\n Balance: {2}", my.getID(), my.getName(), my.getBalance());

            Console.WriteLine("Myfriend account: \n ID: {0}\n Name: {1}\n Balance: {2}", myFriend.getID(), myFriend.getName(), myFriend.getBalance());

            int x;
            Console.Write("Nhap:\n So 1 de nap tien\n So 2 de rut tien\n So 3 de chuyen tien: ");
            x = int.Parse(Console.ReadLine());

            if (x == 1)
            {
                int amount;
                Console.Write("Nhap so tien can nap: ");
                amount = int.Parse(Console.ReadLine());
                my.credit(amount);
            }
            else if (x == 2)
            {
                int amount;
                Console.Write("Nhap so tien can rut: ");
                amount = int.Parse(Console.ReadLine());
                my.debit(amount);
            }
            else if (x == 3)
            {
                int amount;
                Console.Write("Nhap so tien can chuyen: ");
                amount = int.Parse(Console.ReadLine());
                my.tranferTo(myFriend, amount);
            }
            else
                Console.WriteLine("Sai cu phap!");

            Console.WriteLine("My account: \n ID: {0}\n Name: {1}\n Balance: {2}", my.getID(), my.getName(), my.getBalance());
            Console.WriteLine("Myfriend account: \n ID: {0}\n Name: {1}\n Balance: {2}", myFriend.getID(), myFriend.getName(), myFriend.getBalance());

            Console.ReadKey();
        }
    }
}
