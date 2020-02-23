using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klinishev_CourseProject_View
{
    public class ClassWithData
    {
        private SQLiteConnection connection;
        private string sPath = "C:\\Users\\Gustaw R\\source\\repos\\Klinishev_CourseProject_View\\Klinishev_CourseProject_Models\\KlinishevCourseProjectDB.db";
        public string[] Years = new string[] { "2019", "2020" };
        public ClassWithData()
        {
            string ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3;DateTimeFormat=UnixEpoch";
            connection = new SQLiteConnection(ConnectionString);
            connection.Open();
        }

        public ComboBox fillType(ComboBox comboBox)
        {
            int max_count;
            SQLiteCommand getMaxID = connection.CreateCommand();
            getMaxID.CommandText = "select COUNT(Id) from PriceList";
            try
            {
                max_count = Convert.ToInt32(getMaxID.ExecuteScalar());
            }
            catch
            {
                max_count = 0;
            }
            for(int i=1; i <= max_count; i++)
            {
                SQLiteCommand getDealName = connection.CreateCommand();
                getDealName.CommandText = "select Type from PriceList WHERE Id = '" + i + "'";
                string DealName = Convert.ToString(getDealName.ExecuteScalar());
                comboBox.Items.Add(DealName);
            }
            return comboBox;
            
        }
        public ComboBox fillCustomer(ComboBox comboBox)
        {
            int max_count;
            SQLiteCommand getMaxID = connection.CreateCommand();
            getMaxID.CommandText = "select COUNT(Id) from Customers";
            try
            {
                max_count = Convert.ToInt32(getMaxID.ExecuteScalar());
            }
            catch
            {
                max_count = 0;
            }
            for (int i = 1; i <= max_count; i++)
            {
                SQLiteCommand getDealName = connection.CreateCommand();
                getDealName.CommandText = "select FIO from Customers WHERE Id = '" + i + "'";
                string DealName = Convert.ToString(getDealName.ExecuteScalar());
                comboBox.Items.Add(DealName);
            }
            return comboBox;
        }

        public ComboBox fillYears(ComboBox comboBox)
        {
            for(int i=0; i < Years.Length; i++)
            {
                comboBox.Items.Add(Years[i]);
            }
            return comboBox;
        }
    }
}
