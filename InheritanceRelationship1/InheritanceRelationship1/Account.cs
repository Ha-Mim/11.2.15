using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationship1
{
    class Account
    {
        public string AccountNo { set; get; }
        public string CustomerName { set; get; }
        public double Balance { set; get; }

        public Account(string accountNo, string customerName)
        {
            AccountNo = accountNo;
            CustomerName = customerName;
        }
        public virtual string Deposit(double amount)
        {
            Balance += amount;
            return "Deposited";
        }

        public virtual string Withdraw(double amount)
        {
            Balance -= amount;
            return "Withdrawn";
        }

        public override string ToString()
        {
            return "Account No. : "+AccountNo+ " Customer : " +CustomerName+ " Balance : "+Balance;
        }
    }
}
