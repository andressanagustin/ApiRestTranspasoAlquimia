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
    public class AdherentesController : BaseController
    {
        //public int i = 0;

        [HttpPost]
        public Reply CambiosAdhe([FromBody] TablasViewModels _model)
        {
            return BuscaAdherentes(_model);
        }

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
                    Borrar("gc_adherentes");
                }
                else
                {
                    if (_model.listData != null)
                    {
                        var rAdd = this.Agregar(_model.listData);
                    }
                }

                oR.result = 1;

                GuardarAuditoria(true, "Tabla: ADHERENTES");
            }
            catch (Exception ex)
            {
                oR.message = "Ocurrio un error en el servidor, intenta de nuevo mas tarde.";
                ELog.save(this, ex);
            }

            return oR;
        }
        private void Borrar()
        {
            using (var db = new dbAlumnado())
            {
                
                db.Database.ExecuteSqlCommand("TRUNCATE TABLE [gc_adherentes]");

                //var x = (from a in db.gc_adherentes
                //         select a).ToList();
                //if (x.Count > 0)
                //{
                //    db.gc_adherentes.RemoveRange(x);
                //    db.SaveChanges();
                //}

                //return x.Count;
            }
        }
        private bool Agregar(List<object> _listData)
        {
            using (var db = new dbAlumnado())
            {
                
                foreach (var item in _listData)
                {
                    //i++;
                    //if (i == 154)
                    //{
                    //    var error = 1;
                    //}
                    var obj = JsonConvert.DeserializeObject<gc_adherentes>(item.ToString());
                    db.gc_adherentes.Add(obj);
                }
                db.SaveChanges();
            }
            return true;
        }
        private Reply BuscaAdherentes(TablasViewModels _model)
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
                using (var db = new dbAlumnado())
                {
                    var lstAdhe = db.gc_adherentes.Where(p => p.edicion == true).ToList();
                    if(lstAdhe.Count > 0) 
                    {
                        List<object> lstObj = new List<object>();
                        foreach (var item in lstAdhe)
                        {
                            lstObj.Add(item);
                        }

                        oR.listData = lstObj;
                        oR.data = null;
                    }
                    else
                    {
                        oR.listData = null;
                        oR.data = null;
                    }

                    
                    oR.result = 1;
                }
            }
            catch (Exception ex)
            {
                oR.message = "Ocurrio un error en el servidor, intenta de nuevo mas tarde.";
                ELog.save(this, ex);
            }

            return oR;
        }
    }
}
