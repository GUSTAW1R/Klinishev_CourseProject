using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinishev_CourseProject_Controllers
{
    public class AuthController
    {
        private SQLiteConnection connection;
        //Путь измени, файл находится в папке Models
        private string sPath = Environment.CurrentDirectory + "\\DB.db";
        //Создадим объект от класса пользователей, он будет посредником в передачи данных
        //private Users users = new Users();

        public AuthController()
        {
            string ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3;DateTimeFormat=UnixEpoch";
            connection = new SQLiteConnection(ConnectionString);
            connection.Open();
            //this.Login = users.Login;
            //this.Password = users.Password;
        }

        public void check_validation(string Login, string Password)
        {
            //Добавь пока вот такой код, для регистрации соотвественно INSERT INTO
            string txtSQLQuery = "SELECT * FROM Users WHERE Login = '" + Login + "' AND Password = '" + Password + "'";
            SQLiteCommand addEntries = connection.CreateCommand();
            addEntries.CommandText = txtSQLQuery;
            addEntries.ExecuteNonQuery();
        }

    }
}
