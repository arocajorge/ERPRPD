//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ct_periodo
    {
        public ct_periodo()
        {
            this.ct_cbtecble = new HashSet<ct_cbtecble>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdPeriodo { get; set; }
        public int IdanioFiscal { get; set; }
        public int pe_mes { get; set; }
        public System.DateTime pe_FechaIni { get; set; }
        public System.DateTime pe_FechaFin { get; set; }
        public string pe_cerrado { get; set; }
        public string pe_estado { get; set; }
    
        public virtual ct_anio_fiscal ct_anio_fiscal { get; set; }
        public virtual ICollection<ct_cbtecble> ct_cbtecble { get; set; }
    }
}
