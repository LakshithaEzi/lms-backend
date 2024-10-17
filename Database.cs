using System;
using System.Data.SQLite;

namespace Sameera
{
    public class Database
    {
        public SQLiteConnection myConnection;

        public Database()
        {
            myConnection = new SQLiteConnection("Data Source=database.sqlite3");


            if (!File.Exists("./database.sqlite3"))
            {
                SQLiteConnection.CreateFile("database.sqlite3");


                System.Console.WriteLine("Sqlite Database file created");
            }
        }

    }
}