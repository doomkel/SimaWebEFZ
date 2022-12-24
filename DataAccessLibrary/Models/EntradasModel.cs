using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class EntradasModel
    {
        public DateTime Fecha { get; set; }
        public int Folio { get; set; }
        public int Recibe { get; set; }
        public string NombreRecibe { get; set; }
        public string Factura { get; set; }
        public int Sku { get; set; }
        public string CodigoComponente { get; set; }
        public string DescripComponente { get; set; }
        public int Piezas { get; set; }
    }
}
