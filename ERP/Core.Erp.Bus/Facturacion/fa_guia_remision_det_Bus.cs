﻿using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Bus.Facturacion
{
  public  class fa_guia_remision_det_Bus
    {
        fa_guia_remision_det_Data odata = new fa_guia_remision_det_Data();
        fa_factura_det_Data data_det_fac = new fa_factura_det_Data();
        public List<fa_guia_remision_det_Info> get_list(int IdEmpresa, decimal IdOrdencompraext)
        {
            try
            {
                return odata.get_list(IdEmpresa, IdOrdencompraext);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<fa_guia_remision_det_Info> get_list_x_factura(int IdEmpresa,int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                List<fa_guia_remision_det_Info> lst_detalle = new List<fa_guia_remision_det_Info>();
                var lst_detalle_fc = data_det_fac.get_list(IdEmpresa, IdSucursal, IdBodega, IdCbteVta);

                foreach (var item in lst_detalle_fc)
                {
                   
                    lst_detalle.Add( new fa_guia_remision_det_Info 
                    {
                        IdEmpresa = item.IdEmpresa,
                        IdSucursal = item.IdSucursal,
                        IdBodega = item.IdBodega,
                        IdCbteVta=item.IdCbteVta,
                        IdProducto = item.IdProducto,
                        gi_cantidad = item.vt_cantidad,
                        Secuencia = item.Secuencia,
                        Secuencia_fact=item.Secuencia,
                        pr_descripcion = item.pr_descripcion
                    });
                }
                return lst_detalle;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
