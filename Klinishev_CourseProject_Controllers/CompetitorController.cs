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
    public class CompetitorController
    {
        private SQLiteConnection connection;
        private string sPath = "C:\\Users\\Gustaw R\\source\\repos\\Klinishev_CourseProject_View\\Klinishev_CourseProject_Models\\KlinishevCourseProjectDB.db";
        Competitor competitor = new Competitor();
        public CompetitorController()
        {
            string ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3;DateTimeFormat=UnixEpoch";
            connection = new SQLiteConnection(ConnectionString);
            connection.Open();
        }

        public List<Competitor> getCompetitorList()
        {
            List<Competitor> RequestList = new List<Competitor>();
            using (SQLiteCommand sqlcmd = connection.CreateCommand())
            {
                sqlcmd.CommandText = @"SELECT Id, Name, Type, Price FROM Competitors";
                sqlcmd.CommandType = CommandType.Text;
                SQLiteDataReader r = sqlcmd.ExecuteReader();
                while (r.Read())
                {
                    RequestList.Add(new Competitor { Id = Convert.ToInt32(r["Id"]), Name = Convert.ToString(r["Name"]), Type = Convert.ToString(r["Type"]), Price = Convert.ToInt32(r["Price"])});
                }
            }
            return RequestList;
        }

        public string GetCompetitorData(DataGridView dataGridView, string Data)
        {
            int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
            string valueId = dataGridView[0, CurrentRow].Value.ToString();
            string data = "";
            SQLiteCommand getData = connection.CreateCommand();
            switch (Data)
            {

                case "Name":
                    
                    getData.CommandText = "select Name from Competitors WHERE Id = '" + valueId + "'";
                    data = Convert.ToString(getData.ExecuteScalar());
                    break;
                case "Type":
                    getData.CommandText = "select Type from Competitors WHERE Id = '" + valueId + "'";
                    data = Convert.ToString(getData.ExecuteScalar());
                    break;
                case "Price":
                    getData.CommandText = "select Price from Competitors WHERE Id = '" + valueId + "'";
                    data = Convert.ToString(getData.ExecuteScalar());
                    break;

            }
            return data;
        }

        public void AddCompetitor(string Name, string Type, string Price)
        {
            competitor.Name = Name; competitor.Type = Type; competitor.Price = Convert.ToInt32(Price);
            SQLiteCommand getMaxID = connection.CreateCommand();
            getMaxID.CommandText = "select MAX(Id) from Competitors";
            try
            {
                competitor.Id = Convert.ToInt32(getMaxID.ExecuteScalar());
            }
            catch
            {
                competitor.Id = 0;
            }
            string txtSQLQuery = "INSERT INTO Competitors (Id, Name, Type, Price) values('" + (competitor.Id + 1) + "', '" + competitor.Name + "', '" + competitor.Type + "', '" + competitor.Price + "')";
            SQLiteCommand addEntries = connection.CreateCommand();
            addEntries.CommandText = txtSQLQuery;
            addEntries.ExecuteNonQuery();
        }

        public void RefreshCompetitor(DataGridView dataGridView, string Name, string Type, string Price)
        {
            int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
            string Id = dataGridView[0, CurrentRow].Value.ToString();
            string txtSQLQuery = "UPDATE Competitors SET Name = '" + Name + "', Type ='" + Type + "', Price = '" + Price + "' WHERE Id = '" + Id + "'";
            SQLiteCommand addEntries = connection.CreateCommand();
            addEntries.CommandText = txtSQLQuery;
            addEntries.ExecuteNonQuery();
        }

        public void DeleteCompetitor(DataGridView dataGridView)
        {
            int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
            string Id = dataGridView[0, CurrentRow].Value.ToString();
            string txtSQLQuery = "DELETE FROM Competitors WHERE Id = "+Id+"";
            SQLiteCommand addEntries = connection.CreateCommand();
            addEntries.CommandText = txtSQLQuery;
            addEntries.ExecuteNonQuery();
        }
    }
}
