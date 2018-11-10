﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Core.Erp.Info.RRHH
{
    public class ro_rubro_tipo_Info
    {
        public int IdEmpresa { get; set; }
        public string IdRubro { get; set; }
        [Required(ErrorMessage = "El campo Código es obligatorio")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "El campo Código debe tener mínimo 4 caracteres y máximo 50")]
        public string rub_codigo { get; set; }
        [StringLength(30, MinimumLength = 1, ErrorMessage = "El campo Código reporte debe tener mínimo 1 caracteres y máximo 30")]
        [Required(ErrorMessage = "El campo Código reporte es obligatorio")]
        public string ru_codRolGen { get; set; }
        [StringLength(50, MinimumLength = 1, ErrorMessage = "El campo descripción debe tener mínimo 1 caracteres y máximo 50")]
        [Required(ErrorMessage = "El campo descripción es obligatorio")]
        public string ru_descripcion { get; set; }
        [Required(ErrorMessage = "El campo descripción corta es obligatorio")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "El campo descripción corta debe tener mínimo 4 caracteres y máximo 50")]
        public string NombreCorto { get; set; }
        [Required(ErrorMessage = "El campo tipo de rubro es obligatorio")]
        public string ru_tipo { get; set; }
        public string ru_estado { get; set; }
        public bool EstadoBool { get; set; }
        public int ru_orden { get; set; }
        public bool rub_concep { get; set; }
        [Required(ErrorMessage = "El tipo de campo es obligatorio")]
        public int rub_tipcal { get; set; }
        public string rub_ctacon { get; set; }
        public Nullable<int> rub_grupo { get; set; }
        public bool rub_provision { get; set; }
        public bool rub_noafecta { get; set; }
        public bool rub_nocontab { get; set; }
        public bool rub_guarda_rol { get; set; }
        public bool rub_aplica_IESS { get; set; }
        public bool rub_Contabiliza_x_empleado { get; set; }
        public string rub_Acuerdo_Descuento { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public bool rub_acumula_descuento { get; set; }

    }
}