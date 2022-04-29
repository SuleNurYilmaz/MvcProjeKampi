using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using MvcProjeKampi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult Index3()
        {
            return View();
        }
        public ActionResult CategoryChart()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);
        }

        public List<CategoryClass> BlogList()
        { 
            CategoryManager cm = new CategoryManager(new EfCategoryDal());
            var  ct = cm.GetList();

            HeadingManager hm = new HeadingManager(new EfHeadingDal());

            List<CategoryClass> deneme = new List<CategoryClass>();
            foreach (var item in ct)
            {
                deneme.Add(new CategoryClass(){
                    CategoryName= item.CategoryName,
                    CategoryCount=hm.GetListByCategory(item.CategoryID).Count

                });
            }
            return (deneme);
        }
    }
}


//ct.Add(new CategoryClass()
//{
//    CategoryName = "Yazılım",
//    CategoryCount = 8

//});
//ct.Add(new CategoryClass()
//{
//    CategoryName = "Seyahat",
//    CategoryCount = 4

//});
//ct.Add(new CategoryClass()
//{
//    CategoryName = "Teknoloji",
//    CategoryCount = 7

//}); ct.Add(new CategoryClass()
//{
//    CategoryName = "Spor",
//    CategoryCount = 1

//});

