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
    public partial class FormAddRequest : Form
    {
        ClassWithData classWith = new ClassWithData();
        RequestController requestController = new RequestController();
        public FormAddRequest()
        {
            InitializeComponent();
        }

        private void FormAddRequest_Load(object sender, EventArgs e)
        {
            classWith.fillCustomer(comboBoxCustomer);
            classWith.fillType(comboBoxType);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                requestController.AddRequest(comboBoxType.SelectedItem.ToString(), maskedTextBoxCount.Text, dateTimePicker1.Value.Date, comboBoxCustomer.SelectedItem.ToString());
                MessageBox.Show("Договор успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {

            }

        }
    }
}
