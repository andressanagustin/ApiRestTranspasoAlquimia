using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TranspasoApi.Models;
using TranspasoApi.Models.WS;
using TranspasoApi.LogsError;

namespace TranspasoApi.Controllers
{
    public class CarreComisionController : BaseController
    {
        [HttpPost]
        public Reply Post([FromBody] TablasViewModels _model)
        {
            return TrabajaDatos(_model);
        }

        [HttpPost]
        public Reply Delete([FromBody] TablasViewModels _model)
        {
            return TrabajaDatos(_model, "DELETE");
        }

        private Reply TrabajaDatos(TablasViewModels _model, string _method = "POST")
        {
            Reply oR = new Reply();
            oR.result = 0;

            if (_model == null || !Verify(_model.token))
            {
                oR.message = "No autorizado";
                return oR;
            }
            try
            {
                if (_method == "DELETE")
                {
                    Borrar("al_carre_comision");
                }
                else
                {
                    if (_model.listData != null)
                    {
                        var rAdd = this.Agregar(_model.listData);
                    }
                }

                oR.result = 1;

                GuardarAuditoria(true, "Tabla: CARRERA COMISION");
            }
            catch (Exception ex)
            {
                oR.message = "Ocurrio un error en el servidor, intenta de nuevo mas tarde.";
                ELog.save(this, ex);
            }

            return oR;
        }
        
        private bool Agregar(List<object> _listData) {
            using (var db = new dbAlumnado())
            {
                foreach (var item in _listData)
                {
                    var obj = JsonConvert.DeserializeObject<al_carre_comision>(item.ToString());
                    db.al_carre_comision.Add(obj);
                }
                db.SaveChanges();
            }
            return true;
        }
        
    }
}
