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
    public partial class FormRequest : Form
    {
        RequestController requestController = new RequestController();
        public FormRequest()
        {
            InitializeComponent();
        }

        private void FormRequest_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = requestController.getRequestList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FormAddRequest();
                form.Show();
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = requestController.selectionByCustomer(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
        }

        private void buttonSortType_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = requestController.selectionByType(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                requestController.DelRequest(dataGridView);
                MessageBox.Show("Заявка успешно удалена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении заявки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView.DataSource = requestController.getRequestList();
        }

        private void buttonINN_Click(object sender, EventArgs e)
        {
            MessageBox.Show(requestController.getINNbyIdCustomer(dataGridView));
        }

        private void buttonName_Click(object sender, EventArgs e)
        {
            MessageBox.Show(requestController.getNameByIdCustomer(dataGridView));
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = requestController.getRequestByProduct(textBox1.Text);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView.DataSource = requestController.getRequestList();
        }
    }
}
