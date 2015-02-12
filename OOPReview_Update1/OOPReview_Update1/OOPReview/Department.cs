using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPReview
{
    public class Department
    {

        public Head DepartmentHead { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }

        public List<Course> CourseList { set; get; }


        public string Location { set; get; }

        public int EstablishedYear { set; get; }

        public Department(string code,string name, string location, int establishedYear) : this(code)
        {
            Name = name;
            Location = location;
            EstablishedYear = establishedYear;
        }

        public Department(string code) : this()
        {
            Code = code;
        }

        public Department(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public Department()
        {
            CourseList = new List<Course>();
        }




    }
}
