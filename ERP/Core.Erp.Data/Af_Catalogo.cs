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
    
    public partial class Af_Catalogo
    {
        public Af_Catalogo()
        {
            this.Af_Activo_fijo = new HashSet<Af_Activo_fijo>();
            this.Af_Activo_fijo1 = new HashSet<Af_Activo_fijo>();
            this.Af_Activo_fijo2 = new HashSet<Af_Activo_fijo>();
            this.Af_Activo_fijo3 = new HashSet<Af_Activo_fijo>();
            this.Af_Activo_fijo4 = new HashSet<Af_Activo_fijo>();
        }
    
        public string IdCatalogo { get; set; }
        public string IdTipoCatalogo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> FechaUltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }
    
        public virtual ICollection<Af_Activo_fijo> Af_Activo_fijo { get; set; }
        public virtual ICollection<Af_Activo_fijo> Af_Activo_fijo1 { get; set; }
        public virtual ICollection<Af_Activo_fijo> Af_Activo_fijo2 { get; set; }
        public virtual ICollection<Af_Activo_fijo> Af_Activo_fijo3 { get; set; }
        public virtual ICollection<Af_Activo_fijo> Af_Activo_fijo4 { get; set; }
        public virtual Af_CatalogoTipo Af_CatalogoTipo { get; set; }
    }
}
