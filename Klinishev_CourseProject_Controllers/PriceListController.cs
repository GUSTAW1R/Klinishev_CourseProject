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
    public class PriceListController
    {
        private SQLiteConnection connection;
        private string sPath = "C:\\Users\\Gustaw R\\source\\repos\\Klinishev_CourseProject_View\\Klinishev_CourseProject_Models\\KlinishevCourseProjectDB.db";
        PriceList priceList = new PriceList();
        public PriceListController()
        {
            string ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3;DateTimeFormat=UnixEpoch";
            connection = new SQLiteConnection(ConnectionString);
            connection.Open();
        }

        public List<PriceList> getPriceList()
        {
            List<PriceList> PriceList = new List<PriceList>();
            using (SQLiteCommand sqlcmd = connection.CreateCommand())
            {
                sqlcmd.CommandText = @"SELECT Id, Type, Price FROM Customers";
                sqlcmd.CommandType = CommandType.Text;
                SQLiteDataReader r = sqlcmd.ExecuteReader();
                while (r.Read())
                {
                    PriceList.Add(new PriceList { Id = Convert.ToInt32(r["Id"]), Type = Convert.ToString(r["Type"]), Price = Convert.ToInt32(r["Price"]) });
                }
            }
            return PriceList;
        }

        public void AddCustomer(string Type, string Price)
        {

                priceList.Type = Type; priceList.Price = Convert.ToInt32(Price);
                SQLiteCommand getMaxID = connection.CreateCommand();
                getMaxID.CommandText = "select MAX(Id) from PriceList";
                try
                {
                    priceList.Id = Convert.ToInt32(getMaxID.ExecuteScalar());
                }
                catch
                {
                    priceList.Id = 0;
                }
                string txtSQLQuery = "INSERT INTO PriceList (Id, Type, Price) values('" + (priceList.Id + 1) + "', '" + priceList.Price + "')";
                SQLiteCommand addEntries = connection.CreateCommand();
                addEntries.CommandText = txtSQLQuery;
                addEntries.ExecuteNonQuery();
                MessageBox.Show("Товар в прайс-лист успешно добавлен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        public void DeletePriceList(DataGridView dataGridView)
        {
            int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
            string Id = dataGridView[0, CurrentRow].Value.ToString();
            string txtSQLQuery = "DELETE FROM PriceList WHERE Id = " + Id + "";
            SQLiteCommand addEntries = connection.CreateCommand();
            addEntries.CommandText = txtSQLQuery;
            addEntries.ExecuteNonQuery();
        }

        public string GetCompetitorData(DataGridView dataGridView, string Data)
        {
            int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
            string valueId = dataGridView[0, CurrentRow].Value.ToString();
            string data = "";
            SQLiteCommand getData = connection.CreateCommand();
            switch (Data)
            {

                case "Type":
                    getData.CommandText = "select Type from PriceList WHERE Id = '" + valueId + "'";
                    data = Convert.ToString(getData.ExecuteScalar());
                    break;
                case "Price":
                    getData.CommandText = "select Price from PriceList WHERE Id = '" + valueId + "'";
                    data = Convert.ToString(getData.ExecuteScalar());
                    break;

            }
            return data;
        }

        public void RefreshCompetitor(DataGridView dataGridView, string Type, string Price)
        {
            int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
            string Id = dataGridView[0, CurrentRow].Value.ToString();
            string txtSQLQuery = "UPDATE PriceList SET Type ='" + Type + "', Price = '" + Price + "' WHERE Id = '" + Id + "'";
            SQLiteCommand addEntries = connection.CreateCommand();
            addEntries.CommandText = txtSQLQuery;
            addEntries.ExecuteNonQuery();
        }

        public void PublicAdvertising()
        {

        }
    }
}
