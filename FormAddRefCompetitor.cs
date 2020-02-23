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
    public partial class FormAddCompetitor : Form
    {
        CompetitorController competitorController = new CompetitorController();
        ClassWithData classWith = new ClassWithData();
        public FormAddCompetitor()
        {
            InitializeComponent();
        }

        private void FormAddRefCompetitor_Load(object sender, EventArgs e)
        {
            classWith.fillType(comboBoxType);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                competitorController.AddCompetitor(textBoxName.Text, comboBoxType.SelectedItem.ToString(), maskedTextBoxPrice.Text);
                MessageBox.Show("Конкурент успешно добавлен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении конкурента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
