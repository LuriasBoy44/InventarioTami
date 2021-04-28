using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormVentas.DTO
{
    class SelectSalesDTO
    {
        int id;
        string status;
        string producto;
        string proveedor;
        string cliente;
        string pago;
        int precio;
        int cantidad;
        int descuento;
        int total;
        string comentario;

        public int ID
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

        public string Producto
        {
            get
            {
                return producto;
            }

            set
            {
                producto = value;
            }
        }

        public int Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
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

        public int Descuento
        {
            get
            {
                return descuento;
            }

            set
            {
                descuento = value;
            }
        }
        public int Total
        {
            get
            {
                return total;
            }
            set
            {
                total = (precio * cantidad) - descuento;
            }
        }
        public string Comentario
        {
            get
            {
                return comentario;
            }
            set
            {
                comentario = value;
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

        public string Proveedor
        {
            get
            {
                return proveedor;
            }

            set
            {
                proveedor = value;
            }
        }

        public string Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

        public string Pago
        {
            get
            {
                return pago;
            }

            set
            {
                pago = value;
            }
        }

    }
}
