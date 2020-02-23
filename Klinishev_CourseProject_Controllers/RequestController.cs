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

    public class RequestController
    {
        private SQLiteConnection connection;
        private string sPath = "C:\\Users\\Gustaw R\\source\\repos\\Klinishev_CourseProject_View\\Klinishev_CourseProject_Models\\KlinishevCourseProjectDB.db";
        Request request = new Request();

        public RequestController()
        {
            string ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3;DateTimeFormat=UnixEpoch";
            connection = new SQLiteConnection(ConnectionString);
            connection.Open();
        }

        public void AddRequest(string Type, string Count, DateTime Date, string IdCustomer)
        {

            SQLiteCommand getCustomerId = connection.CreateCommand();
            getCustomerId.CommandText = "select Id from Customers WHERE FIO = '" + IdCustomer + "'";
            int Id = Convert.ToInt32(getCustomerId.ExecuteScalar());
            request.IdCustomer = Id;
            request.Type = Type; request.Count = Convert.ToInt32(Count); request.Date = Date;
            SQLiteCommand getMaxID = connection.CreateCommand();
            getMaxID.CommandText = "select MAX(Id) from Request";
            try
            {
                request.Id = Convert.ToInt32(getMaxID.ExecuteScalar());
            }
            catch
            {
                request.Id = 0;
            }
            string txtSQLQuery = "INSERT INTO Request (Id, IdCustomer, Type, Count, Date) values('" + (request.Id + 1) + "', '" + request.IdCustomer + "', '" + request.Type + "', '" + request.Count + "', '" + convertToUnix(request.Date) + "')";
            SQLiteCommand addEntries = connection.CreateCommand();
            addEntries.CommandText = txtSQLQuery;
            addEntries.ExecuteNonQuery();
        }
        public void RefRequest(string Type, string Count, DateTime Date, string IdCustomer)
        {

        }

        public List<Request> getRequestList()
        {
            List<Request> RequestList = new List<Request>();
            using (SQLiteCommand sqlcmd = connection.CreateCommand())
            {
                sqlcmd.CommandText = @"SELECT Id, IdCustomer, Type, Count, Date FROM Request";
                sqlcmd.CommandType = CommandType.Text;
                SQLiteDataReader r = sqlcmd.ExecuteReader();
                while (r.Read())
                {
                    RequestList.Add(new Request { Id = Convert.ToInt32(r["Id"]), IdCustomer = Convert.ToInt32(r["IdCustomer"]), Type = Convert.ToString(r["Type"]), Count = Convert.ToInt32(r["Count"]), Date = Convert.ToDateTime(r["Date"]) });
                }
            }

            return RequestList;
        }

        public List<Request> selectionByCustomer(DateTime dateTime1, DateTime dateTime2)
        {
            List<Request> RequestList = new List<Request>();
            using (SQLiteCommand sqlcmd = connection.CreateCommand())
            {
                sqlcmd.CommandText = @"SELECT Id, IdCustomer, Type, Count, Date FROM Request WHERE Date >= " + convertToUnix(dateTime1) + " AND Date <= " + convertToUnix(dateTime2) + " ORDER BY IdCustomer ASC";
                sqlcmd.CommandType = CommandType.Text;
                SQLiteDataReader r = sqlcmd.ExecuteReader();
                while (r.Read())
                {
                    RequestList.Add(new Request { Id = Convert.ToInt32(r["Id"]), IdCustomer = Convert.ToInt32(r["IdCustomer"]), Type = Convert.ToString(r["Type"]), Count = Convert.ToInt32(r["Count"]), Date = Convert.ToDateTime(r["Date"]) });
                }
            }

            return RequestList;
        }
        public List<Request> selectionByType(DateTime dateTime1, DateTime dateTime2)
        {
            List<Request> RequestList = new List<Request>();
            using (SQLiteCommand sqlcmd = connection.CreateCommand())
            {
                sqlcmd.CommandText = @"SELECT Id, IdCustomer, Type, Count, Date FROM Request WHERE Date >= "+convertToUnix(dateTime1)+" AND Date <= "+ convertToUnix(dateTime2) + " ORDER BY Type ASC";
                sqlcmd.CommandType = CommandType.Text;
                SQLiteDataReader r = sqlcmd.ExecuteReader();
                while (r.Read())
                {
                    RequestList.Add(new Request { Id = Convert.ToInt32(r["Id"]), IdCustomer = Convert.ToInt32(r["IdCustomer"]), Type = Convert.ToString(r["Type"]), Count = Convert.ToInt32(r["Count"]), Date = Convert.ToDateTime(r["Date"]) });
                }
            }

            return RequestList;
        }
        private string convertToUnix(DateTime date)
        {
            string unixTime = (date - new System.DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds.ToString();
            return unixTime;
        }
    }
}
