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
    
    public partial class ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito
    {
        public int mcj_IdEmpresa { get; set; }
        public decimal mcj_IdCbteCble { get; set; }
        public int mcj_IdTipocbte { get; set; }
        public int mba_IdEmpresa { get; set; }
        public decimal mba_IdCbteCble { get; set; }
        public int mba_IdTipocbte { get; set; }
        public int mcj_Secuencia { get; set; }
        public string Observacion { get; set; }
    
        public virtual ba_Cbte_Ban ba_Cbte_Ban { get; set; }
    }
}
