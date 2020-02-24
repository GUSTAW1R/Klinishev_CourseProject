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
    public partial class FormCustomer : Form
    {
        CustomerController customerController = new CustomerController();
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = customerController.getCustomerList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                customerController.AddCustomer(textBoxFIO.Text, textBoxMail.Text, maskedTextBoxINN.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении поставщика, проверьте правильность введённых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView.DataSource = customerController.getCustomerList();
            textBoxFIO.Clear();
            textBoxMail.Clear();
            maskedTextBoxINN.Clear();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                customerController.DeleteCustomer(dataGridView);
                MessageBox.Show("Поставщик успешно удалён", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении поставщика, проверьте правильность введённых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView.DataSource = customerController.getCustomerList();
            textBoxFIO.Clear();
            textBoxMail.Clear();
            maskedTextBoxINN.Clear();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = customerController.getCustomerByINN(maskedTextBoxINN.Text);
            maskedTextBoxSearchINN.Clear();
        }
    }
}
