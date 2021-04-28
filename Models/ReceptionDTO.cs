using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FormVentas.DTO;

namespace FormVentas
{
    class ReceptionDTO  : BaseTransaction
    {
        private int idLine;
        private int idProvider;
        private int idProduct;
        private string obs;
        private string cicle;
        private string location;
        private int discount;
        private int qty;
        long expire;
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

        public string Ubicacion
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
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

        public long Expira
        {
            get
            {
                return expire;
            }

            set
            {
                expire = value;
            }
        }

        public string Ciclo
        {
            get
            {
                return cicle;
            }

            set
            {
                cicle = value;
            }
        }

        //public override void Insert(object _obj)
        //{
        //    ReceptionDTO reception = (ReceptionDTO)_obj;
        //    query = $"INSERT INTO RECEPCIONDETALLE (IDPRODUCTO,IDPROVEEDOR,CANTIDAD,DESCUENTO,COMENTARIO,IDRECEPCION,UBICACION,EXPIRA,CICLO) VALUES ";
        //    query += $"({reception.Producto},{reception.Proveedor},{reception.Cantidad}, ";
        //    query += $"{ reception.Descuento},'{reception.Comentario}',{reception.Id},'{reception.Ubicacion}',datetime({reception.Expira}, 'unixepoch', 'localtime'),'{reception.Ciclo}')";

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
        //    ReceptionDTO reception = (ReceptionDTO )_obj;
        //    query = $"UPDATE RECEPCIONDETALLE SET IDPRODUCTO ={reception.Producto}, IDPROVEEDOR={reception.Proveedor},";
        //    query += $"CANTIDAD={reception.Cantidad},DESCUENTO={reception.Descuento},UBICACION='{reception.Ubicacion}', ";
        //    query += $"COMENTARIO ='{reception.Comentario}' ,EXPIRA =datetime({reception.Expira}, 'unixepoch', 'localtime'),CICLO='{reception.Ciclo}' WHERE ID = {reception.IdLinea}";
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
        //    ReceptionDTO reception = (ReceptionDTO)_obj;
        //    List<Object> list = new List<Object>();
        //    SelectReceptionDTO lineRecord;

        //    query = $"SELECT R.ID,R.CANTIDAD, i.PRECIO,R.DESCUENTO, i.NOMBRE [PRODUCTO],";
        //    query += $"p.NOMBRE [PROVEEDOR] ,R.COMENTARIO, R.UBICACION , R.EXPIRA, R.CICLO ";
        //    query += $"FROM RECEPCIONDETALLE R ";
        //    query += $"INNER JOIN ITEMMASTER i ";
        //    query += $"ON i.ID  = r.IDPRODUCTO ";
        //    query += $"INNER JOIN PROVEEDOR p ";
        //    query += $"ON  r.IDPROVEEDOR =  p.ID ";
        //    query += $"WHERE   r.IDRECEPCION=  {reception.Id}";

        //    connexion = new SQLiteConnection(stringConextion);
        //    connexion.Open();
        //    //Creando el comando SQL
        //    cmdSqlite = connexion.CreateCommand();
        //    cmdSqlite.CommandText = query;
        //    dataReader = cmdSqlite.ExecuteReader();

          
        //    while (dataReader.Read())
        //    {
        //        lineRecord = new SelectReceptionDTO();

        //        lineRecord.ID = dataReader.GetInt32(0);
        //        lineRecord.Cantidad = dataReader.GetInt32(1);
        //        lineRecord.Precio = dataReader.GetInt32(2);
        //        lineRecord.Descuento = dataReader.GetInt32(3);
        //        lineRecord.Total=0;
        //        lineRecord.Producto = dataReader.GetString(4);
        //        lineRecord.Proveedor = dataReader.GetString(5);
        //        lineRecord.Comentario = dataReader.GetString(6);
        //        lineRecord.Ubicacion =dataReader.GetString(7);
        //        lineRecord.Expira =  dataReader.GetString(8);
        //        lineRecord.Expira = lineRecord.Expira.Replace(" 00:00:00", "");
        //        lineRecord.Ciclo= dataReader.GetString(9);
        //        list.Add(lineRecord);
        //    }
        //    if (list.Count == 0)
        //    {
        //        lineRecord = new SelectReceptionDTO();
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
        //    ReceptionDTO  recepcion = (ReceptionDTO )_obj;
        //    query = "DELETE FROM RECEPCIONDETALLE WHERE ID=" + recepcion.IdLinea + ";";
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
        //    ReceptionDTO reception = (ReceptionDTO)_obj;  
        
        //    query = $"INSERT INTO RECEPCION (IDPROVEEDOR) VALUES ({reception.Proveedor});";
        //    query += $"SELECT MAX(ID) FROM RECEPCION;";
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
        //    // call.SelectProveder();
        //    list = call.Select().Cast<ProviderDTO>().ToList();
        //    // return newlist;

        //    return list;
        //}
        
        //public List<ProductDTO> SelectProduct()
        //{
        //    List<ProductDTO> list = new List<ProductDTO>();
        //    ProductDTO call = new ProductDTO();            
        //    list = call.Select().Cast<ProductDTO>().ToList();
        //    return list;             
        //}


        //public List<string> SelectLocation()
        //{
        //    List<string> list = new List<string>();
        //    query = "SELECT * FROM ALMACENAMIENTO";
        //    connexion = new SQLiteConnection(stringConextion);
        //    connexion.Open();
        //    //Creando el comando SQL
        //    cmdSqlite = connexion.CreateCommand();
        //    cmdSqlite.CommandText = query;
        //    dataReader = cmdSqlite.ExecuteReader();

        //    while (dataReader.Read())
        //    {
        //        list.Add(dataReader.GetString(0));
        //    }

        //    if (list.Count == 0)
        //    {
        //        list.Add("");
        //    }
        //    query = string.Empty;
        //    connexion.Close();

        //    return list;
        //}

        //public List<Object> FindHeader(object _obj)
        //{
        //    ReceptionDTO recepcion = (ReceptionDTO)_obj;
        //    List<Object> list = new List<Object>();
        //    SelectReceptionHeaderDTO lineRecord;
        //   //bool union = false;

        //    query = $"SELECT r.ID,r.FECHA, r.IDPROVEEDOR,p.Nombre ";
        //    query += $"FROM RECEPCION r ";
        //    query += $"INNER JOIN PROVEEDOR p ";
        //    query += $"ON p.ID = r.IDPROVEEDOR ";
        // //   query += $"order by  r.FECHA DESC";
        //    query += $"WHERE   r.ID in (";
         
        //    if (recepcion.Proveedor > 0)
        //    {
        //      //  query += (union) ? " INTERSECT " : "";
        //        query += $"SELECT D.IDRECEPCION FROM RECEPCIONDETALLE  D ";
        //        query += $"WHERE D.IDPROVEEDOR={recepcion.Proveedor} ";
              
        //    }

        //    query += $") GROUP BY r.ID ORDER BY  r.FECHA DESC ";

        //    connexion = new SQLiteConnection(stringConextion);
        //    connexion.Open();
        //    //Creando el comando SQL
        //    cmdSqlite = connexion.CreateCommand();
        //    cmdSqlite.CommandText = query;
        //    dataReader = cmdSqlite.ExecuteReader();

        //    while (dataReader.Read())
        //    {
        //        lineRecord = new SelectReceptionHeaderDTO();
        //        lineRecord.ID = dataReader.GetInt32(0);
        //        lineRecord.Fecha = dataReader.GetString(1);
        //        lineRecord.Proveedor = dataReader.GetString(3);
        //        list.Add(lineRecord);
        //    }

        //    if (list.Count == 0)
        //    {
        //        lineRecord = new SelectReceptionHeaderDTO();
        //        list.Add(lineRecord);
        //    }
        //    query = string.Empty;
        //    connexion.Close();

        //    return list;
        //}

        //public List<Object> SelectHeader(object _obj)
        //{
        //    // SalesDTO sales = (SalesDTO)_obj;
        //    List<Object> list = new List<Object>();
        //    SelectReceptionHeaderDTO lineRecord;

        //    query = $"SELECT r.ID,r.FECHA, r.IDPROVEEDOR,p.Nombre ";
        //    query += $"FROM RECEPCION r ";
        //    query += $"INNER JOIN PROVEEDOR p ";
        //    query += $"ON p.ID = r.IDPROVEEDOR ";
        //    query += $"order by  r.FECHA DESC";

        //    connexion = new SQLiteConnection(stringConextion);
        //    connexion.Open();
        //    //Creando el comando SQL
        //    cmdSqlite = connexion.CreateCommand();
        //    cmdSqlite.CommandText = query;
        //    dataReader = cmdSqlite.ExecuteReader();

        //    while (dataReader.Read())
        //    {
        //        lineRecord = new SelectReceptionHeaderDTO();
        //        lineRecord.ID = dataReader.GetInt32(0);
        //        lineRecord.Fecha = dataReader.GetString(1);
        //        lineRecord.Proveedor = dataReader.GetString(3);
        //        list.Add(lineRecord);
        //    }

        //    if (list.Count == 0)
        //    {
        //        lineRecord = new SelectReceptionHeaderDTO();
        //        lineRecord.ID = 0;
        //        lineRecord.Fecha = "";
        //        lineRecord.Proveedor = "";
        //        list.Add(lineRecord);
        //    }
        //    query = string.Empty;
        //    connexion.Close();

        //    return list;
        //}

    }
}
