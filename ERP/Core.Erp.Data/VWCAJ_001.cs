//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class VWCAJ_001
    {
        public int IdEmpresa { get; set; }
        public int IdTipoCbte { get; set; }
        public decimal IdCbteCble { get; set; }
        public int secuencia { get; set; }
        public string pc_Cuenta { get; set; }
        public double dc_Valor { get; set; }
        public double dc_Valor_Debe { get; set; }
        public Nullable<double> dc_Valor_Haber { get; set; }
        public string tc_descripcion { get; set; }
        public double cr_Valor { get; set; }
        public string cm_Signo { get; set; }
        public int IdTipoMovi { get; set; }
        public string tm_descripcion { get; set; }
        public string cm_observacion { get; set; }
        public int IdCaja { get; set; }
        public string ca_Descripcion { get; set; }
        public System.DateTime cm_fecha { get; set; }
        public string Estado { get; set; }
        public string tc_TipoCbte { get; set; }
        public string IdCtaCble { get; set; }
        public string pe_nombreCompleto { get; set; }
    }
}
