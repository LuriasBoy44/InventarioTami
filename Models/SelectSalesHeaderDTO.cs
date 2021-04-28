using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormVentas.DTO
{
    class SelectSalesHeaderDTO
    {
        int id;
        string fecha;
        string cliente;
      
        public string Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
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

    }
}
