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
    public partial class FormAuthorization : Form
    {
        AuthRegistController auth = new AuthRegistController();
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                auth.check_validation(textBoxLogin.Text, textBoxPassword.Text);
                MessageBox.Show("Вы успешно авторизавались", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var form = new FormMain();
                form.Show();
            }
            catch
            {
                MessageBox.Show("Неверный логин ил пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new FormRegistration();
            form.Show();
        }
    }
}
