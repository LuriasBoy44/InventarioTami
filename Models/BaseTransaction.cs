using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
//using System.Data.SQLite;

namespace FormVentas
{
    /// <summary>
    /// Clase Master de transacciones en SQLite
    /// </summary>
    abstract class BaseTransaction
    {
        public static string stringConextion = ConfigurationManager.AppSettings["BDREPOSITORY"].ToString();//@"Data Source=C:\Users\cruiz\Desktop\DataSQLite\DBLocalHost.s3db";
        //public static SQLiteConnection connexion;
        //public static SQLiteCommand cmdSqlite;
        //public static SQLiteDataReader dataReader;
        public int id;
        protected string pay;
        protected string name;
        protected string phone;
        protected string address;
        protected string type;
        protected string query;
        protected string email;

        //public abstract void Insert(object _obj);
        //public abstract void Update(object _obj);
        //public abstract void Delete(object _obj);
        //public abstract List<object> Select(object _obj);
        //public abstract Int32 GetID(object _obj);
    }
}
