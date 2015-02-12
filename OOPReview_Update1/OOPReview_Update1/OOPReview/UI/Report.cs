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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private List<Department> departmentList; 
        public Report(List<Department> departmentList):this()
        {
            this.departmentList = departmentList;
        }

        private void showListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
        {
            foreach (Department aItem in departmentList)
            {

                ListViewItem myView = new ListViewItem(aItem.Code);
                myView.SubItems.Add(aItem.Name);
                myView.SubItems.Add(aItem.Location);
                myView.SubItems.Add(aItem.DepartmentHead.Name);
                myView.SubItems.Add(aItem.DepartmentHead.Email);
                myView.SubItems.Add(aItem.CourseList.Count.ToString());

                showListView.Items.Add(myView);
            }
        }
    }
}
