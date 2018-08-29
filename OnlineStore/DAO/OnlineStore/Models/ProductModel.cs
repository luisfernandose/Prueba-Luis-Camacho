using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAO;

namespace OnlineStore.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Producto { get; set; }
        public decimal Precio { get; set; }
        public int IdCategory { get; set; }
        public List<DAO.Product> pm = new List<DAO.Product>();
        public List<Category> Category = new List<Category>();
    }
}