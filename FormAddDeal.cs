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
    public partial class FormAddDeal : Form
    {
        DealController dealController = new DealController();
        ClassWithData classWith = new ClassWithData();
        public FormAddDeal()
        {
            InitializeComponent();
        }

        private void FormAddDeal_Load(object sender, EventArgs e)
        {
            classWith.fillCustomer(comboBoxCustomer);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                dealController.AddDeal(textBoxName.Text, comboBoxCustomer.SelectedItem.ToString(), dateTimePicker1.Value.Date, dateTimePicker2.Value.Date, textBoxConditions.Text);
                MessageBox.Show("Договор успешно добавлен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении договора, проверьте правильность заполнения полей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}
