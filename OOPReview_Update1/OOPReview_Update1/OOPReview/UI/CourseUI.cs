using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPReview.UI
{
    public partial class CourseUI : Form
    {
        public CourseUI()
        {
            InitializeComponent();
            deptComboBox.DisplayMember = "Name";
        }

        private List<Department> departmentList;
        private List<Course> courseList; 
        public CourseUI(List<Department> departmentList, List<Course> courseList):this()
        {
            this.departmentList = departmentList;
            this.courseList = courseList;
            deptComboBox.DataSource = departmentList;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Course aCourse =new Course();
            aCourse.Code = codeTextBox.Text;
            aCourse.Title = titleTextBox.Text;
            aCourse.Description = despTextBox.Text;
            aCourse.Credit = Convert.ToInt32(creditTextBox.Text);
            courseList.Add(aCourse);
            Department aDepartment =(Department) deptComboBox.SelectedItem;
            foreach (Department department1 in departmentList)
            {
                if (department1 == aDepartment)
                {
                    department1.CourseList.Add(aCourse);
                }
            }
        }
    }
}
