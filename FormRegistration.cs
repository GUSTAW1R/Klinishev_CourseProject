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
    public partial class FormRegistration : Form
    {
        AuthRegistController authRegistController = new AuthRegistController();
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void buttonRegisrate_Click(object sender, EventArgs e)
        {
            authRegistController.AddNewUser(textBox1.Text, textBox2.Text, textBox3.Text);
            Close();
        }

    }
}
