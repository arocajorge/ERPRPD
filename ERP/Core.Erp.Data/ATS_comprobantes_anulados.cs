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
    
    public partial class ATS_comprobantes_anulados
    {
        public int IdEmpresa { get; set; }
        public int IdPeriodo { get; set; }
        public int Secuencia { get; set; }
        public string tipoComprobante { get; set; }
        public string Establecimiento { get; set; }
        public string puntoEmision { get; set; }
        public string secuencialInicio { get; set; }
        public string secuencialFin { get; set; }
        public string Autorización { get; set; }
    }
}