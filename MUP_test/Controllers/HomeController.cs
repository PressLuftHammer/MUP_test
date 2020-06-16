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
                return View();
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpPost]
        public JsonResult RequestList(int[] statuses,DateTime start,DateTime finish)
        {
           
            using(MUPContext db=new MUPContext())
            {
                finish=finish.AddDays(1.0);

                return Json(new{

                    requests = db.RequestLogs
                               .Where(r => r.Status == 0)
                               .Select(a => new
                               {
                                   reqID = a.RequestId,
                                   reqText = a.Comment,
                                   reqCreateTime = a.LogTime,
                                   curStatus = db.RequestLogs
                                                 .Where(b => b.RequestId == a.RequestId && 
                                                             b.LogTime == db.RequestLogs
                                                                      .Where(c => c.RequestId == b.RequestId)
                                                                      .Max(d => d.LogTime))
                                                                      .Single().Status

                               })
                               .Where(l=>l.reqCreateTime>=start && l.reqCreateTime<finish &&   statuses.Any(a=>a==l.curStatus))                              
                               .ToArray()
                        });

            }

        }
    }
}
