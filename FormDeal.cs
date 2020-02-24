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
    public partial class FormDeal : Form
    {
        DealController dealController = new DealController();
        ClassWithData classWith = new ClassWithData();
        public FormDeal()
        {
            InitializeComponent();
        }

        private void FromDeal_Load(object sender, EventArgs e)
        {
            classWith.fillCustomer(comboBoxCustomer);
            dataGridView.DataSource = dealController.getDealList();
            groupBox1.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = new FormAddDeal();
            form.Show();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                dealController.DeleteDeal(dataGridView);
                MessageBox.Show("Договор успешно удалён", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении договора", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView.DataSource = dealController.getDealList();
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            textBoxName.Text = dealController.GetDealData(dataGridView, "Name");
            comboBoxCustomer.SelectedItem = dealController.GetDealData(dataGridView, "IdCustomer");
            textBoxConditions.Text = dealController.GetDealData(dataGridView, "Conditions");
            dateTimePicker1.Value = dealController.GetDealData(0, dataGridView, "DateStart");
            dateTimePicker2.Value = dealController.GetDealData(0, dataGridView, "DateFinish");
            groupBox2.Enabled = false;
            groupBox1.Enabled = true;
        }

        private void buttonAddRef_Click(object sender, EventArgs e)
        {
            try
            {
                dealController.RefreshDeal(dataGridView, textBoxName.Text, comboBoxCustomer.SelectedItem.ToString(), dateTimePicker1.Value.Date, dateTimePicker2.Value.Date, textBoxConditions.Text);
                MessageBox.Show("Договор успешно обновлён", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка при обновлении договора", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView.DataSource = dealController.getDealList();
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = dealController.getDealList();
        }

    }
}
