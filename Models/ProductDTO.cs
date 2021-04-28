using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.SQLite;

namespace FormVentas
{
    class ProductDTO : BaseTransaction
    {
        string code;
        int priceSell;
        int priceBuy;
        int discount;
        int provider;
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

        public int Descuento
        {
            get
            {
                return discount;
            }

            set
            {
                discount = value;
            }
        }

        public int PrecioCompra
        {
            get
            {
                return priceBuy;
            }

            set
            {
                priceBuy = value;
            }
        }

        public int PrecioVenta
        {
            get
            {
                return priceSell;
            }

            set
            {
                priceSell = value;
            }
        }

        public string Codigo
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        public int IdProveedor
        {
            get
            {
                return provider;
            }

            set
            {
                provider = value;
            }
        }

        //public override void Insert(object _obj)
        //{
        //    connexion.Close();
        //    ProductDTO product = (ProductDTO)_obj;
        //    query = $"INSERT INTO ITEMMASTER ( NOMBRE, EXTERNALCODE,PRECIO,PRECIOCOMPRA,DESCUENTO,IDPROVEEDOR) VALUES ";
        //    query += $"( '{ product.Nombre}', '{ product.Codigo }',";
        //    query += $"{ product.PrecioVenta},{PrecioCompra},{Descuento},{  product.IdProveedor });";
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
        //    ProductDTO product = (ProductDTO)_obj;
        //    query =  $"UPDATE ITEMMASTER SET NOMBRE='{ product.Nombre}', EXTERNALCODE ='{ product.Codigo}',";
        //    query += $"PRECIO ={ product.PrecioVenta},PRECIOCOMPRA={product.PrecioCompra},DESCUENTO={product.Descuento},";
        //    query += $"IDPROVEEDOR={ product.IdProveedor} WHERE ID={ product.Id }";
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
        //public override List<Object> Select(object _obj=null)
        //{
        //    List<Object> list = new List<Object>();
        //    ProductDTO lineRecord;
        //    query = "SELECT ID,NOMBRE,EXTERNALCODE,IDPROVEEDOR,DESCUENTO,PRECIO, PRECIOCOMPRA FROM ITEMMASTER";
        //    connexion = new SQLiteConnection(stringConextion);
        //    connexion.Open();
        //    //Creando el comando SQL
        //    cmdSqlite = connexion.CreateCommand();
        //    cmdSqlite.CommandText = query;
        //    dataReader = cmdSqlite.ExecuteReader();

        //    while (dataReader.Read())
        //    {
        //        lineRecord = new ProductDTO();

        //        lineRecord.Id = dataReader.GetInt32(0);              
        //        lineRecord.Nombre = dataReader.GetString(1);
        //        lineRecord.Codigo = dataReader.GetString(2);
        //        lineRecord.IdProveedor = dataReader.GetInt32(3);
        //        lineRecord.Descuento = dataReader.GetInt32(4);
        //        lineRecord.PrecioVenta= dataReader.GetInt32(5);
        //        lineRecord.PrecioCompra = dataReader.GetInt32(6);

        //        list.Add(lineRecord);
        //    }
        //    if (list.Count == 0)
        //    {
        //        list.Add(new ProductDTO());
        //    }
        //    query = string.Empty;
        //    connexion.Close();

        //    return list;
        //}
        //public override void Delete(object _obj)
        //{
        //    ProductDTO product = (ProductDTO)_obj;
        //    query = "DELETE FROM ITEMMASTER WHERE ID=" + product.Id + ";";
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
        //    string product = (string)_obj;
        //    int ID = 0;
        //    query = $"SELECT ID FROM ITEMMASTER WHERE NOMBRE='{product}'";
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

        //public static int GetIDProduct(object _obj)
        //{
        //    ProductDTO provider = new ProductDTO();
        //    return provider.GetID(_obj);
        //}
    }
}
