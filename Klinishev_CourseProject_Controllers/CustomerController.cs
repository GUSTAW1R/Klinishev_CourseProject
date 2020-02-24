using Klinishev_CourseProject_Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klinishev_CourseProject_Controllers
{
    public class CustomerController
    {
        private SQLiteConnection connection;
        private string sPath = "C:\\Users\\Gustaw R\\source\\repos\\Klinishev_CourseProject_View\\Klinishev_CourseProject_Models\\KlinishevCourseProjectDB.db";
        Customer customer = new Customer();
        public CustomerController()
        {
            string ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3;DateTimeFormat=UnixEpoch";
            connection = new SQLiteConnection(ConnectionString);
            connection.Open();
        }

        public List<Customer> getCustomerList()
        {
            List<Customer> RequestList = new List<Customer>();
            using (SQLiteCommand sqlcmd = connection.CreateCommand())
            {
                sqlcmd.CommandText = @"SELECT Id, FIO, Email, INN FROM Customers";
                sqlcmd.CommandType = CommandType.Text;
                SQLiteDataReader r = sqlcmd.ExecuteReader();
                while (r.Read())
                {
                    RequestList.Add(new Customer { Id = Convert.ToInt32(r["Id"]), FIO = Convert.ToString(r["FIO"]), Email = Convert.ToString(r["Email"]), INN = Convert.ToString(r["INN"])});
                }
            }
            return RequestList;
        }

        public void AddCustomer(string FIO, string Email, string INN)
        {
            if(INN.Length == 12)
            {
                customer.FIO = FIO; customer.Email = Email; customer.INN = Convert.ToString(INN);
                SQLiteCommand getMaxID = connection.CreateCommand();
                getMaxID.CommandText = "select MAX(Id) from Customers";
                try
                {
                    customer.Id = Convert.ToInt32(getMaxID.ExecuteScalar());
                }
                catch
                {
                    customer.Id = 0;
                }
                string txtSQLQuery = "INSERT INTO Customers (Id, FIO, Email, INN) values('" + (customer.Id + 1) + "', '" + customer.FIO + "', '" + customer.Email + "', '" + customer.INN + "')";
                SQLiteCommand addEntries = connection.CreateCommand();
                addEntries.CommandText = txtSQLQuery;
                addEntries.ExecuteNonQuery();
                MessageBox.Show("Поставщик успешно добавлен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ИНН состоит из 12 чисел");
            }          
        }

        public void DeleteCustomer(DataGridView dataGridView)
        {
            int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
            string Id = dataGridView[0, CurrentRow].Value.ToString();
            string txtSQLQuery = "DELETE FROM Customers WHERE Id = " + Id + "";
            SQLiteCommand addEntries = connection.CreateCommand();
            addEntries.CommandText = txtSQLQuery;
            addEntries.ExecuteNonQuery();
        }

        public List<Customer> getCustomerByINN(string INN)
        {
            List<Customer> RequestList = new List<Customer>();
            using (SQLiteCommand sqlcmd = connection.CreateCommand())
            {
                customer.INN = Convert.ToString(INN);
                sqlcmd.CommandText = @"SELECT Id, FIO, Email, INN FROM Customers WHERE INN = "+ customer.INN + "";
                sqlcmd.CommandType = CommandType.Text;
                SQLiteDataReader r = sqlcmd.ExecuteReader();
                while (r.Read())
                {
                    RequestList.Add(new Customer { Id = Convert.ToInt32(r["Id"]), FIO = Convert.ToString(r["FIO"]), Email = Convert.ToString(r["Email"]), INN = Convert.ToString(r["INN"]) });
                }
            }
            return RequestList;
        }
    }
}
