using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationship1
{
    class Program
    {
        static void Main(string[] args)
        {
            Savings sv1  = new Savings("aa-243","Ha-Mim",200);
            sv1.Deposit(1200000);
            sv1.Withdraw(1200);
            Checking ch1 = new Checking("cc-3243","Pial",300);
            ch1.Deposit(399999);
            ch1.Withdraw(2000);

            Account ac2=new Savings("sv-345","Pfnv",4959);
            ac2.Deposit(45890);
            ac2.Withdraw(768);

            Savings sv4 = (Savings) ac2;
           
            List<Account>accountList = new List<Account>();
            accountList.Add(sv1);
            accountList.Add(ch1);
            accountList.Add(sv4);
            foreach (var account in accountList)
            {
                Console.WriteLine(account);
            }

            //Console.WriteLine(sv1.Balance);
            //Console.WriteLine(ch1.Balance);
            //Console.WriteLine(sv1.NoOfTransaction);
            Console.ReadKey();

        }
    }
}
