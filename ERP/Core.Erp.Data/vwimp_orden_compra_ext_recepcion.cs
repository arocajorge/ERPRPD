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
    
    public partial class vwimp_orden_compra_ext_recepcion
    {
        public decimal IdRecepcion { get; set; }
        public System.DateTime or_fecha { get; set; }
        public string or_observacion { get; set; }
        public Nullable<int> IdEmpresa_oc { get; set; }
        public decimal IdOrdenCompraExt { get; set; }
        public bool estado { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public int IdEmpresa { get; set; }
        public int IdCatalogo_via { get; set; }
        public string IdCiudad_destino { get; set; }
        public int IdCatalogo_forma_pago { get; set; }
        public System.DateTime oe_fecha { get; set; }
        public Nullable<System.DateTime> oe_fecha_llegada_est { get; set; }
        public Nullable<System.DateTime> oe_fecha_embarque_est { get; set; }
        public bool Estado_cierre { get; set; }
    }
}