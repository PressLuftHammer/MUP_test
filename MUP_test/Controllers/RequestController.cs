using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MUP_test.Models;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace MUP_test.Controllers
{
    public class RequestController : Controller
    {
        //создание новой
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //существующая заявка
        [HttpGet]
        public IActionResult Update(int id)
        {
            using (MUPContext db = new MUPContext())
            {
                return View(new ReqView {
                   requests=db.RequestLogs
                  .Where(r => r.RequestId == id)
                  .OrderByDescending(a => a.LogTime)
                  .ToArray()
                });
            }
        }

        [HttpPost]
        public IActionResult Create(string Comment)
        {
            using(MUPContext db=new MUPContext())
            {
                int new_id = db.GetReqID();//получить новый id
                db.RequestLogs.Add(new RequestLog
                {
                    RequestId = new_id,
                    Status = 0,//статус 
                    LogTime = DateTime.Now,
                    Comment = Comment
                });

                db.SaveChanges();

                return Redirect(Url.Action("Update", new { id = new_id }));
            }           
        }

        [HttpPost]
        public IActionResult Update(int id,long dt_log,int new_status,string Comment)
        {
            try
            {

                using (MUPContext db = new MUPContext())
                {

                    using (var transact = db.Database.BeginTransaction(IsolationLevel.RepeatableRead))
                    {
                        //получаем последнюю запись из лога
                        var rl = db.RequestLogs
                                 .Where(r => r.RequestId == id)
                                 .OrderByDescending(a => a.LogTime)
                                 .First();

                        ////проверяем последняя ли запись                    
                      //  if (rl.LogTime.Ticks != dt_log)
                            throw new Exception("Данные устарели, необходимо обновить!");

                        if(!StatusUtils.CheckNextStatus(rl.Status, new_status))
                            throw new Exception(string.Format("Недопустимое изменение статуса заявки '{0}'->'{1}'",
                                StatusUtils.GetStatusName(rl.Status), StatusUtils.GetStatusName(new_status)));

                        //добавление записи
                        db.RequestLogs.Add(new RequestLog
                        {
                            RequestId = id,
                            Status = new_status,
                            Comment = Comment,
                            LogTime = DateTime.Now
                        });

                        db.SaveChanges();
                        transact.Commit();
                    }
                }

                return Redirect((Url.Action("Update", new { id = id })));
            }
            catch(Exception e)
            {
                return View("ErrorUpdate",new ErrorUpdate{ message = e.Message, id = id });
            }
        }

        
    }
}