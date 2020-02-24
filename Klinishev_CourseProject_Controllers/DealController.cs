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
    public class DealController
    {
        private SQLiteConnection connection;
        private string sPath = "C:\\Users\\Gustaw R\\source\\repos\\Klinishev_CourseProject_View\\Klinishev_CourseProject_Models\\KlinishevCourseProjectDB.db";
        Deal deal = new Deal();
        public DealController()
        {
            string ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3;DateTimeFormat=UnixEpoch";
            connection = new SQLiteConnection(ConnectionString);
            connection.Open();
        }

        public List<Deal> getDealList()
        {
            List<Deal> DealList = new List<Deal>();
            using (SQLiteCommand sqlcmd = connection.CreateCommand())
            {
                sqlcmd.CommandText = @"SELECT Id, Name, IdCustomer, DateStart, DateFinish, Conditions FROM Deal";
                sqlcmd.CommandType = CommandType.Text;
                SQLiteDataReader r = sqlcmd.ExecuteReader();
                while (r.Read())
                {
                    DealList.Add(new Deal { Id = Convert.ToInt32(r["Id"]), Name = Convert.ToString(r["Name"]), IdCustomer = Convert.ToInt32(r["IdCustomer"]), DateStart = Convert.ToDateTime(r["DateStart"]), DateFinish = Convert.ToDateTime(r["DateFinish"]), Conditions = Convert.ToString(r["Conditions"]) });
                }
            }

            return DealList;
        }

        public void AddDeal(string Name, string IdCustomer, DateTime DateStart, DateTime DateFinish, string Conditions)
        {
            SQLiteCommand getCustomerId = connection.CreateCommand();
            getCustomerId.CommandText = "select Id from Customers WHERE FIO = '" + IdCustomer + "'";
            int Id = Convert.ToInt32(getCustomerId.ExecuteScalar());
            deal.IdCustomer = Id;
            deal.Name = Name; deal.DateStart = DateStart; deal.DateFinish = DateFinish; deal.Conditions = Conditions;
            SQLiteCommand getMaxID = connection.CreateCommand();
            getMaxID.CommandText = "select MAX(Id) from Deal";
            try
            {
                deal.Id = Convert.ToInt32(getMaxID.ExecuteScalar());
            }
            catch
            {
                deal.Id = 0;
            }
            string txtSQLQuery = "INSERT INTO Deal (Id, Name, IdCustomer, DateStart, DateFinish, Conditions) values('" + (deal.Id + 1) + "', '" + deal.Name + "','" + deal.IdCustomer + "', '" + convertToUnix(deal.DateStart) + "', '" + convertToUnix(deal.DateFinish) + "', '" + deal.Conditions + "')";
            SQLiteCommand addEntries = connection.CreateCommand();
            addEntries.CommandText = txtSQLQuery;
            addEntries.ExecuteNonQuery();
        }

        public string GetDealData(DataGridView dataGridView, string Data)
        {
            int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
            string valueId = dataGridView[0, CurrentRow].Value.ToString();
            string data = "";
            SQLiteCommand getData = connection.CreateCommand();
            switch (Data)
            {

                case "Name":

                    getData.CommandText = "select Name from Deal WHERE Id = '" + valueId + "'";
                    data = Convert.ToString(getData.ExecuteScalar());
                    break;
                case "IdCustomer":
                    getData.CommandText = "select IdCustomer from Deal WHERE Id = '" + valueId + "'";
                    string id = Convert.ToString(getData.ExecuteScalar());
                    SQLiteCommand getData1 = connection.CreateCommand();
                    getData1.CommandText = "select FIO from Customers WHERE Id = '" + id + "'";
                    data = Convert.ToString(getData1.ExecuteScalar());
                    break;
                case "Conditions":
                    getData.CommandText = "select Conditions from Deal WHERE Id = '" + valueId + "'";
                    data = Convert.ToString(getData.ExecuteScalar());
                    break;
            }
            return data;
        }

        public DateTime GetDealData(int i, DataGridView dataGridView, string nameDate)
        {
            int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
            string valueId = dataGridView[0, CurrentRow].Value.ToString();
            DateTime date = new DateTime();
            SQLiteCommand getData = connection.CreateCommand();
            getData.CommandText = "select "+nameDate+" from Deal WHERE Id = '" + valueId + "'";
            date = Convert.ToDateTime(getData.ExecuteScalar());
            return date;
        }

        public void RefreshDeal(DataGridView dataGridView, string Name, string IdCustomer, DateTime DateStart, DateTime DateFinish, string Conditions)
        {
            int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
            string valueId = dataGridView[0, CurrentRow].Value.ToString();
            SQLiteCommand getCustomerId = connection.CreateCommand();
            getCustomerId.CommandText = "select Id from Customers WHERE FIO = '" + IdCustomer + "'";
            int Id = Convert.ToInt32(getCustomerId.ExecuteScalar());
            deal.IdCustomer = Id;
            deal.Name = Name; deal.DateStart = DateStart; deal.DateFinish = DateFinish; deal.Conditions = Conditions;
            string txtSQLQuery = "UPDATE Deal SET Name = '" + deal.Name + "', IdCustomer ='" + deal.IdCustomer + "', DateStart = '" + convertToUnix(deal.DateStart) + "', DateFinish = '" + convertToUnix(deal.DateFinish) + "', Conditions = '" + deal.Conditions + "' WHERE Id = '" + valueId + "'";
            SQLiteCommand addEntries = connection.CreateCommand();
            addEntries.CommandText = txtSQLQuery;
            addEntries.ExecuteNonQuery();
        }

        public void DeleteDeal(DataGridView dataGridView)
        {
            int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
            string Id = dataGridView[0, CurrentRow].Value.ToString();
            deal.Id = Convert.ToInt32(Id);
            string txtSQLQuery = "DELETE FROM Deal WHERE Id = " + deal.Id + "";
            SQLiteCommand addEntries = connection.CreateCommand();
            addEntries.CommandText = txtSQLQuery;
            addEntries.ExecuteNonQuery();
        }


        private string convertToUnix(DateTime date)
        {
            string unixTime = (date - new System.DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds.ToString();
            return unixTime;
        }
    }
}
