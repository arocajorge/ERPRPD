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
    
    public partial class vwin_Producto_Composicion
    {
        public int IdEmpresa { get; set; }
        public decimal IdProductoPadre { get; set; }
        public decimal IdProductoHijo { get; set; }
        public string IdUnidadMedida { get; set; }
        public double Cantidad { get; set; }
        public string pr_descripcion { get; set; }
        public string nom_presentacion { get; set; }
        public string ca_Categoria { get; set; }
        public Nullable<System.DateTime> lote_fecha_fab { get; set; }
        public Nullable<System.DateTime> lote_fecha_vcto { get; set; }
        public string lote_num_lote { get; set; }
    }
}