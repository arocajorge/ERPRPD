﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Reportes.CuentasPorPagar
{
    public class CXP_006_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdRetencion { get; set; }
        public string NumRetencion { get; set; }
        public string NAutorizacion { get; set; }
        public System.DateTime fecha { get; set; }
        public string observacion { get; set; }
        public Nullable<int> IdEmpresa_Ogiro { get; set; }
        public Nullable<decimal> IdCbteCble_Ogiro { get; set; }
        public Nullable<int> IdTipoCbte_Ogiro { get; set; }
        public int Idsecuencia { get; set; }
        public string re_tipoRet { get; set; }
        public double re_baseRetencion { get; set; }
        public int IdCodigo_SRI { get; set; }
        public string re_Codigo_impuesto { get; set; }
        public double re_Porcen_retencion { get; set; }
        public double re_valor_retencion { get; set; }
        public string NumFactura { get; set; }
        public double co_baseImponible { get; set; }
        public double co_valoriva { get; set; }
        public string pe_nombreCompleto { get; set; }

    }
}
