using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.SQLite;

namespace FormVentas
{
    class PaymentDTO: BaseTransaction
    {   
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }  
              
        //public override void Insert(object _obj)
        //{
        //    PaymentDTO Payment= (PaymentDTO)_obj;
        //    query = "INSERT INTO MEDIOPAGO (PAGO) VALUES ";
        //    query += "( '" + Payment.Nombre + ");";
        //    connexion = new SQLiteConnection(stringConextion);
        //    //Abriremos la conexión
        //    connexion.Open();
        //    //Creando el comando SQL
        //    cmdSqlite = connexion.CreateCommand();
        //    //Insertando datos en la tabla
        //    cmdSqlite.CommandText = query;
        //    cmdSqlite.ExecuteNonQuery();
        //    connexion.Close();
        //    query = string.Empty;
        //}
        //public override void Update(object _obj)
        //{
        //    PaymentDTO Payment= (PaymentDTO)_obj;
        //    query = "UPDATE MEDIOPAGO SET PAGO='" + Payment.Nombre + "'";
        //    query += " WHERE ID=" + Payment.Id + ";";          
        //    //Abriremos la conexión
        //    connexion.Open();
        //    //Creando el comando SQL
        //    cmdSqlite = connexion.CreateCommand();
        //    //Insertando datos en la tabla
        //    cmdSqlite.CommandText = query;
        //    cmdSqlite.ExecuteNonQuery();
        //    connexion.Close();
        //    query = string.Empty;
        //}
        //public override List<Object> Select(object _obj = null)
        //{
        //    List<Object> list = new List<Object>();
        //    PaymentDTO lineRecord;
        //    query = "SELECT * FROM MEDIOPAGO";
        //    connexion = new SQLiteConnection(stringConextion);
        //    connexion.Open();
        //    //Creando el comando SQL
        //    cmdSqlite = connexion.CreateCommand();
        //    cmdSqlite.CommandText = query;
        //    dataReader = cmdSqlite.ExecuteReader();

        //    while (dataReader.Read())
        //    {
        //        lineRecord = new PaymentDTO();

        //        lineRecord.Id = dataReader.GetInt32(0);
        //        lineRecord.Nombre = dataReader.GetString(1);

        //        list.Add(lineRecord);
        //    }

        //    if (list.Count==0)
        //    {
        //        list.Add(new PaymentDTO());
        //    }
        //    query = string.Empty;
        //    connexion.Close();

        //    return list;
        //}

        //public static int GetIDClient(object _obj)
        //{
        //   PaymentDTO Payment= new PaymentDTO();
        //   return Payment.GetID(_obj);
        //}
        //public override int GetID(object _obj)
        //{
        //    string Payment= (string)_obj;
        //    int ID = 0;
        //    query = $"SELECT ID FROM MEDIOPAGO WHERE PAGO='{Payment}'";
        //    connexion = new SQLiteConnection(stringConextion);
        //    connexion.Open();
        //    cmdSqlite = connexion.CreateCommand();
        //    cmdSqlite.CommandText = query;
        //    dataReader = cmdSqlite.ExecuteReader();

        //    while (dataReader.Read())
        //    {
        //        ID = dataReader.GetInt32(0);
        //    }
        //    query = string.Empty;
        //    connexion.Close();

        //    return ID;
        //}
        //public override void Delete(object _obj)
        //{
        //    PaymentDTO Payment= (PaymentDTO)_obj;
        //    query = "DELETE FROM MEDIOPAGO  WHERE ID=" + Payment.Id + ";";
        //    ////Abriremos la conexión
        //    connexion.Open();
        //    ////Creando el comando SQL
        //    cmdSqlite = connexion.CreateCommand();
        //    ////Insertando datos en la tabla
        //    cmdSqlite.CommandText = query;
        //    cmdSqlite.ExecuteNonQuery();
        //    connexion.Close();
        //    query = string.Empty;
        //}
    }
}
