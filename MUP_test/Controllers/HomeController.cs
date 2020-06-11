using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MUP_test.Models;

namespace MUP_test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (MUPContext db = new MUPContext())
            {
                return View(new ReqView{
                   requests= db.RequestLogs
                  .Where(r => r.LogTime == db.RequestLogs
                                         .Where(a => a.RequestId == r.RequestId)
                                         .Max(b => b.LogTime))
                  .ToArray()
            });
            }
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet]
        public JsonResult RequestList(string filter,string sort)
        {

            using(MUPContext db=new MUPContext())
            {

               // db.RequestLogs
               //   .Where(a => a.Status == 0 && a.LogTime > DateTime.Now.AddDays(-30.0)); заявка создана ранее месяца

                return Json(new ReqView
                {
                  requests = db.RequestLogs
                  .Where(r => r.LogTime == db.RequestLogs
                                         .Where(a => a.RequestId == r.RequestId)
                                         .Max(b => b.LogTime))
                  //.OrderBy(sort)                          
                  .ToArray()
                });

            }

        }
    }
}
