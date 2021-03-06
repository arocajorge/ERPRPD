﻿using Core.Erp.Bus.General;
using Core.Erp.Info.General;
using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Erp.Bus.Contabilidad;
using Core.Erp.Web.Helps;

namespace Core.Erp.Web.Areas.General.Controllers
{
    [SessionTimeout]
    public class ImpuestoController : Controller
    {
        #region Variables
        tb_sis_Impuesto_Bus bus_impuesto = new tb_sis_Impuesto_Bus();
        tb_sis_Impuesto_Tipo_Bus bus_impuesto_tipo = new tb_sis_Impuesto_Tipo_Bus();
        tb_sis_Impuesto_x_ctacble_Bus bus_impuesto_ctacble = new tb_sis_Impuesto_x_ctacble_Bus();

        #endregion
        #region Index
        public ActionResult Index()
        {
            return View();
        }

        [ValidateInput(false)]
        public ActionResult GridViewPartial_impuesto(string IdCod_Impuesto = "")
        {
            List<tb_sis_Impuesto_Info> model = bus_impuesto.get_list(IdCod_Impuesto, true);
            int IdEmpresa = Convert.ToInt32(SessionFixed.IdEmpresa);
            return PartialView("_GridViewPartial_impuesto", model);
        }
        private void cargar_combos()
        {
            var lst_impuesto_tipo = bus_impuesto_tipo.get_list();
            ViewBag.lst_tipo = lst_impuesto_tipo;

            ct_plancta_Bus bus_plancta = new ct_plancta_Bus();
            var lst_ctacble = bus_plancta.get_list(Convert.ToInt32(Session["IdEmpresa"]), false, false);
            ViewBag.lst_cuentas = lst_ctacble;
        }

        #endregion
        #region Acciones
        public ActionResult Nuevo(string IdCod_Impuesto = "")
        {
            tb_sis_Impuesto_Info model = new tb_sis_Impuesto_Info
            {
                info_impuesto_ctacble = new tb_sis_Impuesto_x_ctacble_Info()
            };
            cargar_combos();
            return View(model);
        }
        [HttpPost]
        public ActionResult Nuevo(tb_sis_Impuesto_Info model)
        {

            if (bus_impuesto.validar_existe_IdCod_Impuesto(model.IdCod_Impuesto))
            {
                ViewBag.mensaje = "El código ya se encuentra registrado";
                cargar_combos();
                return View(model);
            }

            if (!bus_impuesto.guardarDB(model))
            {
                model.info_impuesto_ctacble.IdEmpresa_cta = Convert.ToInt32(Session["IdEmpresa"]);
                model.info_impuesto_ctacble.IdCod_Impuesto = model.IdCod_Impuesto;
                bus_impuesto_ctacble.guardarDB(model.info_impuesto_ctacble);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public ActionResult Modificar( string IdCod_Impuesto = "")
        {
            tb_sis_Impuesto_Info model = bus_impuesto.get_info(IdCod_Impuesto);
            if (model == null)
                return RedirectToAction("Index");
            model.info_impuesto_ctacble = bus_impuesto_ctacble.get_info(IdCod_Impuesto, Convert.ToInt32(SessionFixed.IdEmpresa));
            if (model.info_impuesto_ctacble == null)
                model.info_impuesto_ctacble = new tb_sis_Impuesto_x_ctacble_Info
                {
                    IdEmpresa_cta = Convert.ToInt32(Session["IdEmpresa"]),
                    IdCod_Impuesto = model.IdCod_Impuesto
                };
            cargar_combos();
            return View(model);
        }
        [HttpPost]
        public ActionResult Modificar(tb_sis_Impuesto_Info model)
        {
            if (!bus_impuesto.modificarDB(model))
            {
                cargar_combos();
                return View(model);
            }
            bus_impuesto_ctacble.eliminarDB(model.IdCod_Impuesto, model.info_impuesto_ctacble.IdEmpresa_cta);
            bus_impuesto_ctacble.guardarDB(model.info_impuesto_ctacble);
            return RedirectToAction("Index");
        }

        public ActionResult Anular(string IdCod_Impuesto = "")
        {
            tb_sis_Impuesto_Info model = bus_impuesto.get_info(IdCod_Impuesto);
            if (model == null)
                return RedirectToAction("Index");
            model.info_impuesto_ctacble = bus_impuesto_ctacble.get_info(IdCod_Impuesto, Convert.ToInt32(SessionFixed.IdEmpresa));
            if (model.info_impuesto_ctacble == null)
                model.info_impuesto_ctacble = new tb_sis_Impuesto_x_ctacble_Info();
            cargar_combos();
            return View(model);
        }
        [HttpPost]
        public ActionResult Anular(tb_sis_Impuesto_Info model)
        {
            if (!bus_impuesto.anularDB(model))
            {
                cargar_combos();
                return View(model);
            }
                
            return RedirectToAction("Index");
        }

        #endregion
    }
}