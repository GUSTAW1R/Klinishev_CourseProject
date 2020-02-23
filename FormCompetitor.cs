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
    public partial class FormCompetitor : Form
    {
        CompetitorController competitorController = new CompetitorController();
        ClassWithData classWith = new ClassWithData();
        public FormCompetitor()
        {
            InitializeComponent();
        }

        private void FormCompetitor_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource =  competitorController.getCompetitorList();
            buttonAddRef.Enabled = false;
            classWith.fillType(comboBoxType);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = new FormAddCompetitor();
            form.Show();
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            textBoxName.Text = competitorController.GetCompetitorData(dataGridView, "Name");
            comboBoxType.SelectedItem = competitorController.GetCompetitorData(dataGridView, "Type");
            maskedTextBoxPrice.Text = competitorController.GetCompetitorData(dataGridView, "Price");
            buttonAdd.Enabled = false;
            buttonDel.Enabled = false;
            buttonAddRef.Enabled = true;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                competitorController.DeleteCompetitor(dataGridView);
                MessageBox.Show("Конкурент успешно удалён", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении конкурента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddRef_Click(object sender, EventArgs e)
        {
            try
            {
                competitorController.RefreshCompetitor(dataGridView, textBoxName.Text, comboBoxType.SelectedItem.ToString(), maskedTextBoxPrice.Text);
                MessageBox.Show("Конкурент успешно обновлён", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка при обновлении конкурента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            buttonAdd.Enabled = true;
            buttonDel.Enabled = true;
            buttonAddRef.Enabled = false;
            textBoxName.Clear();
            maskedTextBoxPrice.Clear();
            comboBoxType.SelectedItem = null;
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = competitorController.getCompetitorList();
        }
    }
}
