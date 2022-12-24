using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class EntradasModel
    {
        public DateTime fecha { get; set; }
        public int folio { get; set; }
        public int recibe { get; set; }
        public string alm_recibe { get; set; }
        public string factura { get; set; }
        public int sku { get; set; }
        public string cod_componente { get; set; }
        public string des_componente { get; set; }
        public float pzas { get; set; }
    }
}
