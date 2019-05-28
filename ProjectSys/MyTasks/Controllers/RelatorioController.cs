using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Web;
using PagedList;
using Rotativa;
using System.Web.Mvc;
using MyTasks.Models;
using Rotativa.MVC;


namespace MyTasks.Controllers
{
    public class RelatorioController : Controller
    {
        private MyTasksContext db = new MyTasksContext();
        public ActionResult ListagemAtividades(int? pagina, Boolean? gerarPDF)
        {
            var listagemTask = db.Tasks.OrderBy(n => n.ProjectId).ToList<Task>();

            if (gerarPDF != true)
            {
                //Definindo a paginação              
                int paginaQdteRegistros = 10;
                int paginaNumeroNavegacao = (pagina ?? 1);

                return View(listagemTask.ToPagedList(paginaNumeroNavegacao, paginaQdteRegistros));
            }
            else
            {
                int paginaNumero = 1;
                
                var pdf = new ViewAsPdf
                {
                    ViewName = "ListagemAtividades",
                  
                    FileName = "RelatorioAtividadesPDF",

                    Model = listagemTask.ToPagedList(paginaNumero, listagemTask.Count)
                };
                return pdf;
            }
        }
       
    }
}
