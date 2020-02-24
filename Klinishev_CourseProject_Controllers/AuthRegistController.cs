using Klinishev_CourseProject_Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klinishev_CourseProject_Controllers
{
    public class AuthRegistController
    {
        private SQLiteConnection connection;
        private string sPath = "C:\\Users\\Gustaw R\\source\\repos\\Klinishev_CourseProject_View\\Klinishev_CourseProject_Models\\KlinishevCourseProjectDB.db";
        User users = new User();

        public AuthRegistController()
        {
            string ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3;DateTimeFormat=UnixEpoch";
            connection = new SQLiteConnection(ConnectionString);
            connection.Open();
        }

        public void check_validation(string Login, string Password)
        {
            users.Login = Login; users.Password = Password;
            string txtSQLQuery = "SELECT * FROM Users WHERE Login = '" + users.Login + "' AND Password = '" + users.Password + "'";
            SQLiteCommand addEntries = connection.CreateCommand();
            addEntries.CommandText = txtSQLQuery;
            addEntries.ExecuteNonQuery();
        }

        public void AddNewUser(string Name, string Login, string Password)
        {
            SQLiteCommand getData = connection.CreateCommand();
            getData.CommandText = "select Id from Users WHERE Login = '"+Login+"'";
            string id = Convert.ToString(getData.ExecuteScalar());
            if(id.Length == 0)
            {
                users.Name = Name; users.Login = Login; users.Password = Password;
                SQLiteCommand getMaxID = connection.CreateCommand();
                getMaxID.CommandText = "select MAX(Id) from Users";
                try
                {
                    users.Id = Convert.ToInt32(getMaxID.ExecuteScalar());
                }
                catch
                {
                    users.Id = 0;
                }
                string txtSQLQuery = "INSERT INTO Users (Id, Name, Login, Password) values('" + (users.Id + 1) + "', '" + users.Name + "', '" + users.Login + "', '" + users.Password + "')";
                SQLiteCommand addEntries = connection.CreateCommand();
                addEntries.CommandText = txtSQLQuery;
                addEntries.ExecuteNonQuery();
                MessageBox.Show("Пользователь успешно добавлен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Пользователь с данным логином уже существует", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
