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
    
    public partial class seg_Menu_x_Empresa_x_Usuario
    {
        public int IdEmpresa { get; set; }
        public string IdUsuario { get; set; }
        public int IdMenu { get; set; }
        public bool Lectura { get; set; }
        public bool Escritura { get; set; }
        public bool Eliminacion { get; set; }
    
        public virtual seg_usuario seg_usuario { get; set; }
    }
}
