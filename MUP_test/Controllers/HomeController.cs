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


        [HttpPost]
        public JsonResult RequestList(int[] statuses)
        {
           
            using(MUPContext db=new MUPContext())
            {

                // db.RequestLogs
                //   .Where(a => a.Status == 0 && a.LogTime > DateTime.Now.AddDays(-30.0)); заявка создана ранее месяца


                //var request1=db.RequestLogs
                //               .Where(a=>a.Status==0)
                //               .Join(db.RequestLogs,
                //                     b1=>b1.RequestId,
                //                     b2=>b2.RequestId,
                //                     (c, c1) => new
                //                     {
                //                         ReqID=c.RequestId,
                //                         ReqText=c.Comment,
                //                         ReqCreateTime=c.LogTime,
                //                         CurStatus=db.RequestLogs

                //                     }

                //System.Threading.Thread.Sleep(10000);

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
                               .Where(l=>statuses.Any(a=>a==l.curStatus))                              
                               .ToArray()
                        });

            }

        }
    }
}
