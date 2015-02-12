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
    public partial class DepartmentalHeadUI : Form
    {
        private List<Head> headList; 
        public DepartmentalHeadUI(List<Head> headList)
        {
            InitializeComponent();
            this.headList = headList;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Head aHead = new Head();
            aHead.Name = nameTextBox.Text;
            aHead.Email = emailTextBox.Text;
            aHead.AdministrativeExperienceInYear = Convert.ToInt16(administrativeExperienceTextBox.Text);
            aHead.AcademicQualification = academicQualificationTextBox.Text;
            aHead.PoliticalInclination = politicalInclinationTextBox.Text;
            headList.Add(aHead);
        }
    }
}
