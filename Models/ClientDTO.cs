using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.SQLite;

namespace FormVentas
{
    class ClientDTO: BaseTransaction
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

        public string Fono
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Direccion
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
      
        public string Pago {
                get
                {
                    return pay;
                }

                set
                {
                    pay = value;
                }
        }
              
        //public override void Insert(object _obj)
        //{
        //    ClientDTO client = (ClientDTO)_obj;
        //    query = "INSERT INTO CLIENTE ( NOMBRE, FONO ,DIRECCION,PAGO) VALUES ";
        //    query += "( '" + client.Nombre + "', '" + client.Fono + "','" + client.Direccion + "','"+client.pay+"');";
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
        //    ClientDTO client = (ClientDTO)_obj;
        //    query = "UPDATE CLIENTE SET NOMBRE='" + client.Nombre + "', FONO ='" + client.Fono + "'";
        //    query += ",DIRECCION ='" + client.Direccion + "',PAGO='"+client.Pago+"' WHERE ID=" + client.Id + ";";          
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
        //    ClientDTO lineRecord;
        //    query = "SELECT * FROM CLIENTE ";          

        //    connexion = new SQLiteConnection(stringConextion);
        //    connexion.Open();
        //    //Creando el comando SQL
        //    cmdSqlite = connexion.CreateCommand();
        //    cmdSqlite.CommandText = query;
        //    dataReader = cmdSqlite.ExecuteReader();

        //    while (dataReader.Read())
        //    {
        //        lineRecord = new ClientDTO();

        //        lineRecord.Id = dataReader.GetInt32(0);
        //        lineRecord.Nombre = dataReader.GetString(1);
        //        lineRecord.Fono = dataReader.GetString(2);
        //        lineRecord.Direccion = dataReader.GetString(3);
        //        lineRecord.Pago = dataReader.GetString(4);
        //        list.Add(lineRecord);
        //    }

        //    if (list.Count==0)
        //    {
        //        list.Add(new ClientDTO());
        //    }
        //    query = string.Empty;
        //    connexion.Close();

        //    return list;
        //}

        //public static int GetIDClient(object _obj)
        //{
        //   ClientDTO client = new ClientDTO();
        //   return client.GetID(_obj);
        //}
        //public override int GetID(object _obj)
        //{
        //    string client = (string)_obj;
        //    int ID = 0;
        //    query = $"SELECT ID FROM CLIENTE WHERE NOMBRE='{client}'";
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
        //    ClientDTO client = (ClientDTO)_obj;
        //    query = "DELETE FROM CLIENTE  WHERE ID=" + client.Id + ";";
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
