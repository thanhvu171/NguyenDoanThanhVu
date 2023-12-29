using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    class Account
    {
        private string id;
        private string name;
        private int balance;

        public Account(string id, string name, int balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }
        public string getID()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public int getBalance()
        {
            return balance;
        }
        public void credit(int amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("*Ban da nap {0} vao tai khoan thanh cong!", amount);
            }
            else
                Console.WriteLine("So tien nap khong hop le. Giao dich khong thanh cong!");
        }
        public void debit(int amount)
        {
            if (balance > amount)
            {
                balance -= amount;
                Console.WriteLine("*Ban da rut {0} thanh cong!", amount);
            }
            else
                Console.WriteLine("So tien trong tai khoan khong du de thuc hien .Giao dich khong thanh cong!");
        }public void tranferTo(Account acc, int amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                acc.balance += amount;
                Console.WriteLine("Ban da chuyen {0} thanh cong!", amount);
            }
            else
                Console.WriteLine("So tien vuot qua so du. Giao dich khong thanh cong!");
        }
    }
}
