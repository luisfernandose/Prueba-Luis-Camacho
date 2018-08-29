using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Operations
    {
        TiendaTestEntities db = new TiendaTestEntities();
        public List<Product> GetProduct()
        {
            using (TiendaTestEntities ent = new TiendaTestEntities())
            {
                List<Product> p = (from pr in ent.Product
                                   select pr).ToList();

                return p;
            }
        }
        public List<Category> GetCategory()
        {
            List<Category> c = new List<Category>();
            c = (from ct in db.Category
                 select ct).ToList();
            return c;
        }

        public List<CategoryModelBase> GetCategoryList()
        {
            List<CategoryModelBase> c = new List<CategoryModelBase>();
            c = (from ct in db.Category
                 select new CategoryModelBase
                 {
                     Id = ct.Id,
                     Category = ct.Categoria
                 }).ToList();
            return c;
        }

        public bool NewProduct(Product p, int categoryid)
        {
            using (TiendaTestEntities ent = new TiendaTestEntities())
            {
                Product pp = (from pr in ent.Product
                              where pr.Producto == p.Producto
                              select pr).SingleOrDefault();

                if (pp == null)
                {
                    pp = new Product();
                    pp.Producto = p.Producto;
                    pp.Precio = p.Precio;

                    Category ct = (from c in ent.Category
                                   where c.Id == categoryid
                                   select c).SingleOrDefault();

                    pp.Category.Add(ct);

                    ent.AddToProduct(pp);
                    ent.SaveChanges();
                    return true;
                }
                else
                    return false;
            }

        }       
    }
}
