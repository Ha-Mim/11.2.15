using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPReview.UI;

namespace OOPReview
{
    class Program
    {
        static void Main(string[] args)
        {
            MainUI mainUI = new MainUI();
            
            Application.Run(mainUI);

            //Department department1 = new Department("EEE", "Elec...", "A Building", 1990);
            //department1.Name = "Electronics...";

            //Head aHead = new Head();
            //aHead.Name = "Prof. Azad";
            //aHead.Email = "a@mail.com";
            //aHead.AdministrativeExperienceInYear = 25;
            //aHead.AcademicQualification = "Post D.";
            //aHead.PoliticalInclination = "Neutral";

            //department1.DepartmentHead = aHead;

            //Course course1 = new Course()
            //{
            //    Code = "CSE-101",
            //    Title = "Basic Programming",
            //    Description = "Desp1",
            //    Credit = 3.0
            //};

            //Course course2 = new Course()
            //{
            //    Code = "PHY-111",
            //    Title = "Basic Mechanics",
            //    Description = "Desp1",
            //    Credit = 3.5
            //};

            //Course course3 = new Course()
            //{
            //    Code = "BNG",
            //    Title = "Bangla Basics",
            //    Description = "Desp1",
            //    Credit = 4.0
            //};


            //department1.CourseList.Add(course1);
            //department1.CourseList.Add(course2);
            //department1.CourseList.Add(course3);


            //foreach (Course aCourse in department1.CourseList)
            //{
            //    Console.WriteLine(aCourse.Title + " " + aCourse.Credit);
            //}

            //Console.ReadKey();

            //Db db1 = new Db();
        }
    }
}
