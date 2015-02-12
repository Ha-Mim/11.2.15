using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationship1
{
    class Savings:Account
    {
       
        public double InterestAmount { set; get; }
        public int NoOfTransaction { set; get; }

        public Savings(string accountNo, string customerName, double interestAmount) : base(accountNo, customerName)
        {
            InterestAmount = interestAmount;
        }

        public  override string Withdraw(double amount)
        {
            NoOfTransaction++;
            if (Balance - amount >= 0)
            {
                return base.Withdraw(amount);
            }
            else
            {
                return "Insufficient Balance";
            }
        }

        public override string Deposit(double amount)
        {
            NoOfTransaction++;
            return base.Deposit(amount);
        }

        public override string ToString()
        {
            return base.ToString()+ " NoOfTransaction : "+NoOfTransaction;
        }
    }
}
