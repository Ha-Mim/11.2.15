using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationship1
{
    class Checking : Account
    {
        public Checking(string accountNo, string customerName, double serviceCharge) : base(accountNo, customerName)
        {
            ServiceCharge = serviceCharge;
        }
        public double ServiceCharge { set; get; }
        public override string ToString()
        {
            return base.ToString()+" Service Charge : "+ServiceCharge;
        }
    }
}
