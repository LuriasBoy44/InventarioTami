using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormVentas.DTO
{
    class SelectReceptionHeaderDTO
    {
        int id;
        string fecha;
        string proveedor;
      
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
