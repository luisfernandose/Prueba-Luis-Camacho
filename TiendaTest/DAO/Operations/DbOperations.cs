using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Operations
{
    public class DbOperations
    {
        public List<Product> GetProduct()
        {
            using (TiendaTestEntities ent = new TiendaTestEntities())
            {
                List<Product> p = (from pr in ent.Product select pr).ToList();
                
                return p;
            }
        }

        public bool NewProduct(Product p)
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

                    ent.AddToProduct(p);
                    ent.SaveChanges();
                    return true;
                }
                else
                    return false;
            }

        }
    }
}
