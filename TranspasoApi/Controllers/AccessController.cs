using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TranspasoApi.Models.WS;
using TranspasoApi.Models;
using TranspasoApi.LogsError;

namespace TranspasoApi.Controllers
{
    public class AccessController : BaseController
    {

        [HttpPost]
        public Reply Login([FromBody] AccessViewModels _model) {
            Reply oRes = new Reply();
            oRes.result = 0;

            if (_model == null)
            {
                oRes.message = "No autorizado";
                return oRes;
            }

            try
            {
                using (var db = new dbAlumnado())
                {
                    var list = db.userApi.Where(d => d.usuario == _model.usuario && d.clave == _model.clave && d.estado == 1);

                    if (list.Count()>0)
                    {
                        oRes.result = 1;
                        oRes.data = Guid.NewGuid().ToString();

                        userApi oUser = list.First();
                        oUser.token = oRes.data.ToString();
                        db.Entry(oUser).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        GuardarAuditoria(true, "Loging CORRECTO User " + oUser.usuario);
                    }
                    else
                    {
                        oRes.message = "Datos incorrectos.";
                        GuardarAuditoria(false, "Loging INCORRECTO");
                    }
                }
            }
            catch (Exception ex) 
            {
                // guardar ex en un log interno o alguna base de datos.
                oRes.message = "Ocurrio un error, estamos trabajando en corregirlo.";
                ELog.save(this,ex);
            }

            return oRes;
        }

    }
}
