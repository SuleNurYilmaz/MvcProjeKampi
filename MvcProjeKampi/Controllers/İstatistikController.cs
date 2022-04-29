using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class İstatistikController: Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Statistics()
        {

            var categoryvalues = cm.GetList();
            
            return View(categoryvalues);
        }
    }
}