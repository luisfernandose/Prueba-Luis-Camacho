using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO;
using OnlineStore.Models;

namespace OnlineStore.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public ActionResult Index()
        {
            Operations so = new Operations();
            ProductModel pm = new ProductModel();
            pm.pm = so.GetProduct();
            pm.Category = so.GetCategory();

            return View(pm);
        }

        public JsonResult GetListCategory()
        {
            Operations so = new Operations();

            return Json(so.GetCategoryList(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult NewProductAjax(string producto, string precio, int IdCategory)
        {
            Operations so = new Operations();
            Product p = new Product();
            p.Producto = producto;
            p.Precio = decimal.Parse(precio);

            so.NewProduct(p, IdCategory);

            return RedirectToAction("Index");
        }

        public ActionResult NewProduct(Product p, int IdCategory)
        {
            Operations so = new Operations();
            so.NewProduct(p, IdCategory);

            return RedirectToAction("Index");
        }

    }
}
