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
    public partial class FormPriceList : Form
    {
        PriceListController priceListController = new PriceListController();
        public FormPriceList()
        {
            InitializeComponent();
        }

        private void FormPriceList_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = priceListController.getPriceList();
            textBoxTypeRef.Enabled = false;
            maskedTextBoxPriceRef.Enabled = false;
            buttonAddRef.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                priceListController.AddPriceList(textBoxType.Text, maskedTextBoxPrice.Text);
                MessageBox.Show("Товар успешно добавлен в прайс-лист","Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении товара в прайс-лист, проверьте правильность заполненных полей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView.DataSource = priceListController.getPriceList();
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            textBoxTypeRef.Text = priceListController.GetPriceListData(dataGridView, "Type");
            maskedTextBoxPriceRef.Text = priceListController.GetPriceListData(dataGridView, "Price");
            groupBox1.Enabled = false;
            buttonDel.Enabled = false;
            textBoxTypeRef.Enabled = true;
            maskedTextBoxPriceRef.Enabled = true;
            buttonAddRef.Enabled = true;
        }

        private void buttonAddRef_Click(object sender, EventArgs e)
        {
            try
            {
                priceListController.RefreshPriceList(dataGridView, textBoxTypeRef.Text, maskedTextBoxPriceRef.Text);
                MessageBox.Show("Товар в прайс-листе успешно обновлён", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка при обновлении товара в прайс-листе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView.DataSource = priceListController.getPriceList();
            groupBox1.Enabled = true;
            buttonDel.Enabled = true;
            buttonAddRef.Enabled = false;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                priceListController.DeletePriceList(dataGridView);
                MessageBox.Show("Товар успешно удалён из прайс-листа", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении товара из прайс-листа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView.DataSource = priceListController.getPriceList();
        }
    }
}
