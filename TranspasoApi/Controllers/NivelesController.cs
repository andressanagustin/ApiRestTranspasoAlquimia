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
    public class NivelesController : BaseController
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
                    Borrar("gc_niveles");
                }
                else
                {
                    if (_model.listData != null)
                    {
                        var rAdd = this.Agregar(_model.listData);
                    }
                }

                oR.result = 1;

                GuardarAuditoria(true, "Tabla: NIVELES");
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
                    var obj = JsonConvert.DeserializeObject<gc_niveles>(item.ToString());
                    db.gc_niveles.Add(obj);
                }
                db.SaveChanges();
            }
            return true;
        }

        //public Reply Post(NivelesViewModels _model)
        //{
        //    Reply oR = new Reply();
        //    oR.result = 0;

        //    if (!Verify(_model.token))
        //    {
        //        oR.message = "No autorizado";
        //        return oR;
        //    }

        //    try
        //    {
        //        using (var db = new dbAlumnado())
        //        {
        //            //agregar registro/s;
        //            gc_niveles ni = new gc_niveles();
        //            ni.cod_empre    = _model.cod_empre;
        //            ni.cod_nivel    = _model.cod_nivel;
        //            ni.nom_nivel    = _model.nom_nivel;
        //            ni.cod_escue    = _model.cod_escue;
        //            ni.curso        = _model.curso;
        //            ni.cod_siguie   = _model.cod_siguie;
        //            ni.m_cuota      = _model.m_cuota;
        //            ni.m_matri      = _model.m_matri;
        //            ni.cod_estado   = _model.cod_estado;
        //            ni.titulo       = _model.titulo;
        //            ni.can_materias = _model.can_materias;
        //            ni.cod_plan     = _model.cod_plan;
        //            ni.academico    = _model.academico;

        //            db.gc_niveles.Add(ni);
        //            db.SaveChanges();
        //            //oR.message =
        //            oR.result = 1;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        // hay que guardar este objeto en algun lado EX.
        //        oR.message = "Ocurrio un error en el servidor, intenta de nuevo mas tarde.";
        //    }

        //    return oR;
        //}

        //public Reply Get(SecurityViewModels _model)
        //{
        //    Reply oR = new Reply();
        //    oR.result = 0;

        //    if(!Verify(_model.token))
        //    {
        //        oR.message = "No autorizado";
        //        return oR;
        //    }

        //    try
        //    {
        //        using (var db = new dbAlumnado()) 
        //        {
        //            //oR.data = ;
        //            oR.result = 1;
        //        }

        //    }
        //    catch(Exception ex)
        //    {
        //        oR.message = "Ocurrio un error en el servidor, intenta de nuevo mas tarde.";
        //    }

        //    return oR;
        //}
    }
}
