using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO;
using DAO.Operations;

namespace OnlineStoreApp.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public ActionResult Index()
        {
            DbOperations so = new DbOperations();
            List<Product> pl = so.GetProduct();

            return View();
        }

        public ActionResult NewProduct(Product p)
        {
            DbOperations so = new DbOperations();
            so.NewProduct(p);

            return RedirectToAction("Index");
        }

    }
}
