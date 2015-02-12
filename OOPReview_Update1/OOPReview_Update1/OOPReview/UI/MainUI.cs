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
    public partial class MainUI : Form
    {
        List<Head> departmentalHeadList = new List<Head>();
        List<Department> departmentList = new List<Department>(); 
        List<Course> courseList = new List<Course>(); 
        public MainUI()
        {
            InitializeComponent();
        }

        private void createDepartmentButton_Click(object sender, EventArgs e)
        {
            DepartmentUI aDepartmentUI = new DepartmentUI(departmentList, departmentalHeadList);
            aDepartmentUI.Show();
        }

        private void createHeadButton_Click(object sender, EventArgs e)
        {
            DepartmentalHeadUI aDepartmentalHeadUI = new DepartmentalHeadUI(departmentalHeadList);
            aDepartmentalHeadUI.Show();
        }

        private void createCourseButton_Click(object sender, EventArgs e)
        {
            CourseUI aCourseUi = new CourseUI(departmentList,courseList);
            aCourseUi.Show();
        }

        private void showReportButton_Click(object sender, EventArgs e)
        {
            Report aReport = new Report(departmentList);
            aReport.Show();
        }
    }
}
