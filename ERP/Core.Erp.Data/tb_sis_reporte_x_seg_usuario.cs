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
    
    public partial class tb_sis_reporte_x_seg_usuario
    {
        public string IdUsuario { get; set; }
        public int IdEmpresa { get; set; }
        public string CodReporte { get; set; }
    
        public virtual tb_empresa tb_empresa { get; set; }
        public virtual tb_sis_reporte tb_sis_reporte { get; set; }
    }
}