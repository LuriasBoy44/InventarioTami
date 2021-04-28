using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FormVentas.DTO;

namespace FormVentas
{
    class SalesDTO : BaseTransaction
    {
        int idLine;
        int idClient;
        int idProvider;
        int idProduct;
        string obs;
        string status;
        string payment;
        int discount;
        int qty;
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

        public int Proveedor
        {
            get
            {
                return idProvider;
            }

            set
            {
                idProvider = value;
            }
        }

        public int Producto
        {
            get
            {
                return idProduct;
            }

            set
            {
                idProduct = value;
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

        public int Cantidad
        {
            get
            {
                return qty;
            }

            set
            {
                qty = value;
            }
        }

        public string Comentario
        {
            get
            {
                return obs;
            }

            set
            {
                obs = value;
            }
        }

        public int IdLinea
        {
            get
            {
                return idLine;
            }

            set
            {
                idLine = value;
            }
        }

        public int Cliente
        {
            get
            {
                return idClient;
            }

            set
            {
                idClient = value;
            }
        }

        public string Estado
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
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
        public string Pago
        {
            get
            {
                return payment;
            }

            set
            {
                payment = value;
            }
        }
        //public override void Insert(object _obj)
        //{
        //    SalesDTO sales = (SalesDTO)_obj;
        //    query = $"INSERT INTO VENTADETALLE (IDPRODUCTO,IDCLIENTE,CANTIDAD,DESCUENTO,COMENTARIO,ESTADO,IDVENTA,IDPROVEEDOR,PAGO) VALUES ";
        //    query += $"({sales.Producto},{sales.Cliente},{sales.Cantidad},";
        //    query += $"{ sales.Descuento},'{sales.Comentario}','{sales.Estado}',{sales.Id},{sales.Proveedor},'{sales.Pago}' )";

        //    connexion = new SQLiteConnection(stringConextion);
        //    //Abriremos la conexión
        //    connexion.Open();
        //    //Creando el comando SQL
        //    cmdSqlite = connexion.CreateCommand();
        //    //Insertando datos en la tabla
        //    cmdSqlite.CommandText = query;
        //    cmdSqlite.ExecuteNonQuery();

        //    query = string.Empty;
        //    connexion.Close();
        //}

        //public override void Update(object _obj)
        //{
        //    SalesDTO sales = (SalesDTO )_obj;
        //    query = $"UPDATE VENTADETALLE SET IDPRODUCTO ={sales.Producto}, ";
        //    query += $"CANTIDAD={sales.Cantidad},DESCUENTO={sales.Descuento},IDPROVEEDOR={sales.Proveedor},";
        //    query += $" PAGO='{sales.Pago}',COMENTARIO ='{sales.Comentario}',ESTADO='{sales.Estado}',IDCLIENTE={sales.Cliente} ";
        //    query += $"WHERE ID = {sales.IdLinea}";
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

        //public override List<Object> Select(object _obj)
        //{
        //    SalesDTO sales = (SalesDTO)_obj;
        //    List<Object> list = new List<Object>();
        //    SelectSalesDTO lineRecord;

        //    query = $"SELECT r.ID,r.CANTIDAD, i.PRECIO,r.DESCUENTO, i.NOMBRE [PRODUCTO],";
        //    query += $"r.COMENTARIO,r.ESTADO,p.NOMBRE [PROVEEDOR],c.NOMBRE [CLIENTE], r.PAGO ";
        //    query += $"FROM VENTADETALLE r ";
        //    query += $"INNER JOIN ITEMMASTER i ";
        //    query += $"ON i.ID  = r.IDPRODUCTO ";
        //    query += $"INNER JOIN PROVEEDOR p ";
        //    query += $"ON  r.IDPROVEEDOR =  p.ID ";
        //    query += $"INNER JOIN CLIENTE c ";
        //    query += $"ON  c.ID=  r.IDCLIENTE ";
        //    query += $"WHERE   r.IDVENTA={sales.Id}";

        //    connexion = new SQLiteConnection(stringConextion);
        //    connexion.Open();
        //    //Creando el comando SQL
        //    cmdSqlite = connexion.CreateCommand();
        //    cmdSqlite.CommandText = query;
        //    dataReader = cmdSqlite.ExecuteReader();

        //    while (dataReader.Read())
        //    {
        //        lineRecord = new SelectSalesDTO();

        //        lineRecord.ID = dataReader.GetInt32(0);
        //        lineRecord.Cantidad = dataReader.GetInt32(1);
        //        lineRecord.Precio = dataReader.GetInt32(2);
        //        lineRecord.Descuento = dataReader.GetInt32(3);
        //        lineRecord.Total=0;
        //        lineRecord.Producto = dataReader.GetString(4);
        //        lineRecord.Comentario = dataReader.GetString(5);
        //        lineRecord.Estado= dataReader.GetString(6);
        //        lineRecord.Proveedor = dataReader.GetString(7);
        //        lineRecord.Cliente = dataReader.GetString(8);
        //        lineRecord.Pago= dataReader.GetString(9);

        //        list.Add(lineRecord);
        //    }

        //    if (list.Count==0)
        //    {
        //        lineRecord = new SelectSalesDTO();
        //        //lineRecord.ID = 0;
        //        //lineRecord.Cantidad = 0;
        //        //lineRecord.Precio = 0;
        //        //lineRecord.Descuento = 0;
        //        //lineRecord.Total = 0;
        //        //lineRecord.Producto = "";
        //        //lineRecord.Comentario = "";
        //        //lineRecord.Estado = "";
        //        //lineRecord.Proveedor = "";
        //        //lineRecord.Cliente = "";
        //        list.Add(lineRecord);
        //    }
        //    query = string.Empty;
        //    connexion.Close();

        //    return list;
        //}

        //public List<Object> FindHeader( object _obj)
        //{
        //    SalesDTO sales = (SalesDTO)_obj;
        //    List<Object> list = new List<Object>();
        //    SelectSalesHeaderDTO lineRecord;
        //    bool union = false;

        //    query = $"SELECT  v.ID,v.FECHA,v.IDCLIENTE,c.Nombre ";
        //    query += $"FROM VENTAS  v ";
        //    query += $"INNER JOIN CLIENTE c ";
        //    query += $"ON  c.ID=  v.IDCLIENTE ";  
        //    query += $"WHERE   v.ID in (";

        //    if (!string.IsNullOrEmpty(sales.Estado))
        //    {
        //        query += $" SELECT vd.IDVENTA FROM VENTADETALLE vd ";
        //        query += $" WHERE vd.ESTADO = '{sales.Estado}' ";
        //        union = true; 
        //    }
        //    if (sales.Cliente > 0)
        //    {
        //       query += (union)? " INTERSECT " : "";
        //       query += $" SELECT vd.IDVENTA FROM VENTADETALLE vd ";
        //       query += $" WHERE vd.IDCLIENTE ='{sales.Cliente}' ";
        //       union = true;
        //    }
        //    if (!string.IsNullOrEmpty(sales.Tipo))
        //    {
        //        query += (union) ? " INTERSECT " : "";
        //        query += $" SELECT vd.IDVENTA FROM VENTADETALLE vd ";
        //        query += $"  WHERE vd.IDPROVEEDOR IN (SELECT ID FROM PROVEEDOR WHERE IDTIPO = '{sales.Tipo}') ";
        //        union = true;
        //    }

        //    query += $") GROUP BY v.ID ORDER BY  v.FECHA DESC ";

        //    connexion = new SQLiteConnection(stringConextion);
        //    connexion.Open();
        //    //Creando el comando SQL
        //    cmdSqlite = connexion.CreateCommand();
        //    cmdSqlite.CommandText = query;
        //    dataReader = cmdSqlite.ExecuteReader();

        //    while (dataReader.Read())
        //    {
        //        lineRecord = new SelectSalesHeaderDTO();
        //        lineRecord.ID = dataReader.GetInt32(0);
        //        lineRecord.Fecha = dataReader.GetString(1);
        //        lineRecord.Cliente = dataReader.GetString(3);
        //        list.Add(lineRecord);
        //    }

        //    if (list.Count == 0)
        //    {
        //        lineRecord = new SelectSalesHeaderDTO();
        //        list.Add(lineRecord);
        //    }
        //    query = string.Empty;
        //    connexion.Close();

        //    return list;
        //}

        //public List<Object> SelectHeader(object _obj)
        //{
        //   // SalesDTO sales = (SalesDTO)_obj;
        //    List<Object> list = new List<Object>();
        //    SelectSalesHeaderDTO lineRecord;

        //    query = $"SELECT  v.ID,v.FECHA,v.IDCLIENTE,c.Nombre ";
        //    query += $"FROM VENTAS  v ";
        //    query += $"INNER JOIN CLIENTE c ";
        //    query += $"ON  c.ID=  v.IDCLIENTE ";
        //    query += $"order by  v.FECHA DESC";

        //    connexion = new SQLiteConnection(stringConextion);
        //    connexion.Open();
        //    //Creando el comando SQL
        //    cmdSqlite = connexion.CreateCommand();
        //    cmdSqlite.CommandText = query;
        //    dataReader = cmdSqlite.ExecuteReader();

        //    while (dataReader.Read())
        //    {
        //        lineRecord = new SelectSalesHeaderDTO();
        //        lineRecord.ID = dataReader.GetInt32(0);
        //        lineRecord.Fecha= dataReader.GetString(1);
        //        lineRecord.Cliente = dataReader.GetString(3);
        //        list.Add(lineRecord);
        //    }

        //    if (list.Count == 0)
        //    {
        //        lineRecord = new SelectSalesHeaderDTO();
        //        lineRecord.ID = 0;
        //        lineRecord.Fecha = "";
        //        lineRecord.Cliente = "";
        //        list.Add(lineRecord);
        //    }
        //    query = string.Empty;
        //    connexion.Close();

        //    return list;
        //}

        //public override int GetID(object _obj)
        //{
        //    throw new NotImplementedException();
        //}
      
        //public override void Delete(object _obj)
        //{
        //    SalesDTO  recepcion = (SalesDTO )_obj;
        //    query = "DELETE FROM VENTADETALLE WHERE ID=" + recepcion.IdLinea + ";";
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
        //public int CreateHeader(object _obj)
        //{
        //    SalesDTO cliente = (SalesDTO)_obj;  
        
        //    query = $"INSERT INTO VENTAS (IDCLIENTE) VALUES ({cliente.Cliente});";
        //    query += $"SELECT MAX(ID) FROM VENTAS;";
        //    connexion = new SQLiteConnection(stringConextion);
        //    //Abriremos la conexión
        //    connexion.Open();
        //    //Creando el comando SQL
        //    cmdSqlite = connexion.CreateCommand();
        //    //Insertando datos en la tabla
        //    cmdSqlite.CommandText = query;
        //    dataReader = cmdSqlite.ExecuteReader();

        //    while (dataReader.Read())
        //    {
        //      Id = dataReader.GetInt32(0);                
        //    }
        //    query = string.Empty;
        //    connexion.Close();

        //    return id;
        //}

        //public List<ProviderDTO> SelectProvider()
        //{
        //    List<ProviderDTO> list = new List<ProviderDTO>();
        //    ProviderDTO call = new ProviderDTO();
        //    list = call.Select().Cast<ProviderDTO>().ToList();
        //    return list;
        //}
        
        //public List<ProductDTO> SelectProduct()
        //{
        //    List<ProductDTO> list = new List<ProductDTO>();
        //    ProductDTO call = new ProductDTO();

        //    // call.SelectProveder();
        //    list = call.Select().Cast<ProductDTO>().ToList();
        //    // return newlist;

        //    return list;
             
        //}

        //public List<ClientDTO> SelectClient()
        //{
        //    List<ClientDTO> list = new List<ClientDTO>();
        //    ClientDTO call = new ClientDTO();
        //    // call.SelectProveder();
        //    list = call.Select().Cast<ClientDTO>().ToList();
        //    // return newlist;

        //    return list;
        //}
    }
}
