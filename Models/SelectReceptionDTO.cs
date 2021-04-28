using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormVentas.DTO
{
    class SelectReceptionDTO
    {
        int id;
        string proveedor;
        string producto;
        string expira;
        string ciclo;
        int precio;
        int cantidad;
        int descuento;
        int total;
        string comentario;
        string ubicacion;

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

        public string Ubicacion
        {
            get
            {
                return ubicacion;
            }

            set
            {
                ubicacion = value;
            }
        }

        public string Expira
        {
            get
            {
                return expira;
            }

            set
            {
                expira = value;
            }
        }
        public string Ciclo
        {
            get
            {
                return ciclo;
            }

            set
            {
                ciclo = value;
            }
        }

    }
}
