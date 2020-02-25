using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Models.Products
{
    public class MProduct4View
    {
        public List<Product> ProductList2View;
        public int TotalPageNumber  { get; }
        public MProduct4View(int Pagesize,int TotalProduct)
        {
            TotalPageNumber = (int)Math.Ceiling((decimal)TotalProduct / Pagesize);
        }

    }
}
