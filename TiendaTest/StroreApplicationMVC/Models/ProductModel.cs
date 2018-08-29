using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace StroreApplicationMVC.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public int MyProperty { get; set; }
    }
}