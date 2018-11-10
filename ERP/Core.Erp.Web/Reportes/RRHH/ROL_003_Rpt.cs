﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Bus.Reportes.RRHH;
using Core.Erp.Info.Reportes.RRHH;
using System.Collections.Generic;

namespace Core.Erp.Web.Reportes.RRHH
{
    public partial class ROL_003_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public string usuario { get; set; }
        public string empresa { get; set; }
        public ROL_003_Rpt()
        {
            InitializeComponent();
        }

        private void ROL_003_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            lbl_empresa.Text = empresa;
            lbl_usuario.Text = usuario;
            int IdEmpresa = p_IdEmpresa.Value == null ? 0 : Convert.ToInt32(p_IdEmpresa.Value);
            decimal IdEmpleado = p_IdEmpleado.Value == null ? 0 : Convert.ToDecimal(p_IdEmpleado.Value);
            decimal IdNovedad = p_IdNovedad.Value == null ? 0 : Convert.ToDecimal(p_IdNovedad.Value);

            ROL_003_Bus bus_rpt = new ROL_003_Bus();
            List<ROL_003_Info> lst_rpt = bus_rpt.get_list(IdEmpresa, IdEmpleado, IdNovedad);
            this.DataSource = lst_rpt;
        }
    }
}
