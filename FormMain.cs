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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            var form = new FormRequest();
            form.Show();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            var form = new FormCustomer();
            form.Show();
        }

        private void buttonDeal_Click(object sender, EventArgs e)
        {
            var form = new FormDeal();
            form.Show();
        }

        private void buttonPriceList_Click(object sender, EventArgs e)
        {
            var form = new FormPriceList();
            form.Show();
        }

        private void buttonCompetitor_Click(object sender, EventArgs e)
        {
            var form = new FormCompetitor();
            form.Show();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            var form = new FormReport();
            form.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/gustaw1r");
        }
    }
}
