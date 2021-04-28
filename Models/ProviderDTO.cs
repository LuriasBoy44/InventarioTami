using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.SQLite;

namespace FormVentas
{
    class ProviderDTO : BaseTransaction
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

        public string Tipo
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        //public override void Insert(object _obj)
        //{
        //    ProviderDTO provider = (ProviderDTO)_obj;
        //    query = "INSERT INTO PROVEEDOR ( NOMBRE, FONO ,DIRECCION,IDTIPO) VALUES ";
        //    query += "( '" + provider.Nombre + "', '" + provider.Fono + "','" + provider.Direccion + "','"+ provider.Tipo + "');";
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
        //    ProviderDTO provider = (ProviderDTO)_obj;
        //    query = "UPDATE PROVEEDOR SET NOMBRE='" + provider.Nombre + "', FONO ='" + provider.Fono + "'";
        //    query += ",DIRECCION ='" + provider.Direccion + "',IDTIPO='"+ provider.Tipo+ "' WHERE ID=" + provider.Id + ";";
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
        //    ProviderDTO lineRecord;
        //    query = "SELECT * FROM PROVEEDOR";
        //    connexion = new SQLiteConnection(stringConextion);
        //    connexion.Open();
        //    //Creando el comando SQL
        //    cmdSqlite = connexion.CreateCommand();
        //    cmdSqlite.CommandText = query;
        //    dataReader = cmdSqlite.ExecuteReader();

        //    while (dataReader.Read())
        //    {
        //        lineRecord = new ProviderDTO();

        //        lineRecord.Id = dataReader.GetInt32(0);
        //        lineRecord.Tipo = dataReader.GetString(1);
        //        lineRecord.Nombre = dataReader.GetString(2);
        //        lineRecord.Fono = dataReader.GetString(3);
        //        lineRecord.Direccion = dataReader.GetString(4);
             
        //        list.Add(lineRecord);
        //    }

        //    if (list.Count==0)
        //    {
        //        list.Add(new ProviderDTO());
        //    }
        //    query = string.Empty;
        //    connexion.Close();

        //    return list;
        //}
        //public override void Delete(object _obj)
        //{
        //    ProviderDTO provider = (ProviderDTO)_obj;
        //    query = "DELETE FROM PROVEEDOR WHERE ID=" + provider.Id + ";";
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
        //public override int GetID(object _obj)
        //{
        //    string provider = (string)_obj;
        //    int ID = 0;
        //    query = $"SELECT ID FROM PROVEEDOR WHERE NOMBRE='{provider}'";
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

        //    return ID ;
        //}

        //public static int GetIDProvider(object _obj)
        //{
        //    ProviderDTO provider = new ProviderDTO();
        //    return provider.GetID(_obj);
        //}

        //public List<String> SelectType()
        //{
        //    List<String> list = new List<String>();
        //    ProviderDTO lineRecord;
        //    query = "SELECT * FROM TIPOS";
        //    connexion = new SQLiteConnection(stringConextion);
        //    connexion.Open();
        //    //Creando el comando SQL
        //    cmdSqlite = connexion.CreateCommand();
        //    cmdSqlite.CommandText = query;
        //    dataReader = cmdSqlite.ExecuteReader();

        //    while (dataReader.Read())
        //    {
        //        lineRecord = new ProviderDTO();

        //        list.Add(dataReader.GetString(0));
        //    }
        //    query = string.Empty;
        //    connexion.Close();

        //    return list;
        //}

   
    }
}
