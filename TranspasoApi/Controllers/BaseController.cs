using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TranspasoApi.Models;


namespace TranspasoApi.Controllers
{
    public class BaseController : ApiController
    {
        private DateTime hoy = DateTime.Now;
        public bool Verify(string _token)
        {
            using (var db = new dbAlumnado()) 
            {
                if (db.userApi.Where(d => d.token == _token && d.estado == 1).Count() > 0) 
                {
                    return true;
                }
            }
            return false;
        }
        public void GuardarAuditoria(bool _Resultado, string _Detalle)
        {
            using (var db = new dbAlumnado())
            {
                var oAudi = new auditoria();

                oAudi.resultado = _Resultado;
                oAudi.resultadoDetalle = _Detalle;
                oAudi.fecha = hoy;

                db.auditoria.Add(oAudi);
                db.SaveChanges();
            }

        }

        public void Borrar(string _table)
        {
            using (var db = new dbAlumnado())
            {
                db.Database.ExecuteSqlCommand("TRUNCATE TABLE ["+ _table + "]");

            }
        }


    }

}
