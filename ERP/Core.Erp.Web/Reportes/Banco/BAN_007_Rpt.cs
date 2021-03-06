﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.Reportes.Banco;
using System.Collections.Generic;
using Core.Erp.Bus.Reportes.Banco;

namespace Core.Erp.Web.Reportes.Banco
{
    public partial class BAN_007_Rpt : DevExpress.XtraReports.UI.XtraReport
    { 
        public string usuario { get; set; }
        public string empresa { get; set; }
        public BAN_007_Rpt()
        {
            InitializeComponent();
        }

        private void BAN_007_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            lbl_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            lbl_empresa.Text = empresa;
            lbl_usuario.Text = usuario;
            int IdEmpresa = p_IdEmpresa.Value == null ? 0 : Convert.ToInt32(p_IdEmpresa.Value);
            int IdBanco = p_IdBanco.Value == null ? 0 : Convert.ToInt32(p_IdBanco.Value);
            decimal IdPersona = string.IsNullOrEmpty(p_IdPersona.Value.ToString()) ? 0 : Convert.ToDecimal(p_IdPersona.Value);
            DateTime fecha_ini = string.IsNullOrEmpty(p_fecha_ini.Value.ToString()) ? DateTime.Now : Convert.ToDateTime(p_fecha_ini.Value);
            DateTime fecha_fin = string.IsNullOrEmpty(p_fecha_fin.Value.ToString()) ? DateTime.Now : Convert.ToDateTime(p_fecha_fin.Value);
            string Estado = p_Estado.Value == null ? "" : Convert.ToString(p_Estado.Value);

            BAN_007_Bus bus_rpt = new BAN_007_Bus();
            List<BAN_007_Info> lst_rpt = bus_rpt.get_list(IdEmpresa, IdBanco, IdPersona, fecha_ini, fecha_fin, Estado);
            this.DataSource = lst_rpt;
        }
    }
}
