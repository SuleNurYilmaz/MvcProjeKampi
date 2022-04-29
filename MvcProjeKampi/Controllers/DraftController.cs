using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class DraftController : Controller
    {
        // GET: Draft
        DraftManager dm = new DraftManager(new EfDraftDal());
        public ActionResult Index()
        {
            string p = (string)Session["WriterMail"];
            var info = dm.GetDraft(p).ToList();
            return View(info);
        }

        public ActionResult GetDraftDetails(int id)
        {
            
                var values = dm.GetByID(id);
                return View(values);

        }
        public ActionResult NewDraft()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewDraft(Draft p)
        {
            string sender = (string)Session["WriterMail"];
                p.SenderMail = sender;
                p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                dm.DraftAdd(p);
                return RedirectToAction("Index");


        }

    }
}