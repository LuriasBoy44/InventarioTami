using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.SQLite;
using FormVentas.DTO;

namespace FormVentas
{
    class InventoryDTO : BaseTransaction
    {   
        private int cantidad=0;
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

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }
                               
        //public override void Insert(object _obj)
        //{
        //}
        //public override void Update(object _obj)
        //{
        //}
      
        //public override List<Object> Select(object _obj = null)
        //{            
        //    List<Object> list = new List<Object>();
        //    InventoryDTO lineRecord;
        //    int cant = 0;

        //    query = "SELECT IT.NOMBRE AS NOMBRE,SUM(S.CANTIDAD)  AS STOCK ";
        //    query +="FROM STOCK S INNER JOIN ITEMMASTER IT ON IT.ID == S.ID ";
        //    query +="GROUP BY IT.NOMBRE ";
   
        //    connexion = new SQLiteConnection(stringConextion);
        //    connexion.Open();
        //    //Creando el comando SQL
        //    cmdSqlite = connexion.CreateCommand();
        //    cmdSqlite.CommandText = query;
        //    dataReader = cmdSqlite.ExecuteReader();

        //    while (dataReader.Read())
        //    {
        //        cant = dataReader.GetInt32(1);
        //        if (cant>0)
        //        {
                    
        //            lineRecord = new InventoryDTO();
        //            lineRecord.Nombre = dataReader.GetString(0);
        //            lineRecord.Cantidad = dataReader.GetInt32(1);

        //            list.Add(lineRecord);
        //        }                
        //    }

        //    if (list.Count==0)
        //    {
        //        list.Add(new InventoryDTO());
        //    }
        //    query = string.Empty;
        //    connexion.Close();

        //    return list;
        //}
     
        //public override void Delete(object _obj)
        //{

        //}
        //public override int GetID(object _obj)
        //{
        //    return 0;
        //}
    }
}
