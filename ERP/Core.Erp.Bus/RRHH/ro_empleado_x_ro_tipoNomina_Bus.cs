﻿using Core.Erp.Data.RRHH;
using Core.Erp.Info.RRHH;
using System;
using System.Collections.Generic;
namespace Core.Erp.Bus.RRHH
{
    public class ro_empleado_x_ro_tipoNomina_Bus
    {
         ro_empleado_x_ro_tipoNomina_Data odata = new  ro_empleado_x_ro_tipoNomina_Data();
        public List< ro_empleado_x_ro_tipoNomina_Info> get_list(int IdEmpresa)
        {
            try
            {
                return odata.get_list(IdEmpresa);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public  ro_empleado_x_ro_tipoNomina_Info get_info(int IdEmpresa, int IdEmpleado, int IdNominatipo)
        {
            try
            {
                return odata.get_info(IdEmpresa, IdEmpleado, IdNominatipo);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool guardarDB( ro_empleado_x_ro_tipoNomina_Info info)
        {
            try
            {
                return odata.guardarDB(info);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool anularDB( ro_empleado_x_ro_tipoNomina_Info info)
        {
            try
            {
                return odata.anularDB(info);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
