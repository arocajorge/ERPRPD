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
    
    public partial class ATS_compras
    {
        public int IdEmpresa { get; set; }
        public int IdPeriodo { get; set; }
        public int Secuencia { get; set; }
        public string codSustento { get; set; }
        public string tpIdProv { get; set; }
        public string idProv { get; set; }
        public string tipoComprobante { get; set; }
        public string parteRel { get; set; }
        public string tipoProv { get; set; }
        public string denopr { get; set; }
        public System.DateTime fechaRegistro { get; set; }
        public string establecimiento { get; set; }
        public string puntoEmision { get; set; }
        public string secuencial { get; set; }
        public System.DateTime fechaEmision { get; set; }
        public string autorizacion { get; set; }
        public decimal baseNoGraIva { get; set; }
        public decimal baseImponible { get; set; }
        public decimal baseImpGrav { get; set; }
        public decimal baseImpExe { get; set; }
        public decimal montoIce { get; set; }
        public decimal montoIva { get; set; }
        public string pagoLocExt { get; set; }
        public string denopago { get; set; }
        public string paisEfecPago { get; set; }
        public string formaPago { get; set; }
        public string docModificado { get; set; }
        public string estabModificado { get; set; }
        public string ptoEmiModificado { get; set; }
        public string secModificado { get; set; }
        public string autModificado { get; set; }
    }
}