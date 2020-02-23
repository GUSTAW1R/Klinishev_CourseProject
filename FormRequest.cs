﻿using Klinishev_CourseProject_Controllers;
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
            dataGridView.DataSource = requestController.getRequestList();
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

        }
    }
}