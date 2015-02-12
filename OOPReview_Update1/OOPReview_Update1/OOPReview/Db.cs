using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPReview
{
    class Db
    {
        public void Save(Department aDepartment)
        {
            //TODO: write code to save this department in database
        }


        public void Change(int a)
        {
            a = 100;
        }

        public void Change(Department aDepartment)
        {
            aDepartment.Code = "Changed";
        }

    }
}
