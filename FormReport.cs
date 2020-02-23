using Klinishev_CourseProject_Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klinishev_CourseProject_View
{
    public partial class FormReport : Form
    {
        ReportController reportController = new ReportController();
        ClassWithData classWith = new ClassWithData();
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            classWith.fillYears(comboBoxYear);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            reportController.createCrossReport(dataGridView, comboBoxYear.SelectedItem.ToString());
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {

        }
    }
}
