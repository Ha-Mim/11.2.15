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
    public partial class DepartmentUI : Form
    {
        private List<Department> departmentList;
        private List<Head> departmentalHeadList; 

        public DepartmentUI()
        {
            InitializeComponent();
            headComboBox.DisplayMember = "Name";
        }

        public DepartmentUI(List<Department> departmentList, List<Head> departmentalHeadList) : this()
        {
            this.departmentList = departmentList;
            this.departmentalHeadList = departmentalHeadList;
            PopulateHeadComboBox();
        }

        private void PopulateHeadComboBox()
        {
            headComboBox.DataSource = departmentalHeadList;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Department aDepartment = new Department();
            aDepartment.Code = codeTextBox.Text;
            aDepartment.Name = nameTextBox.Text;
            aDepartment.Location = locationTextBox.Text;
            aDepartment.EstablishedYear = Convert.ToInt16(establishedYearTextBox.Text);
            aDepartment.DepartmentHead = (Head) headComboBox.SelectedItem;
            departmentList.Add(aDepartment);
        }
    }
}
