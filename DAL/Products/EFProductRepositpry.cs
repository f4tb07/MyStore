using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Contracts;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DAL.Products
{
    public class EFProductRepositpry : IProductRepository
    {
        private readonly MyStorContex _productContex;

        public EFProductRepositpry(MyStorContex ProductContex)
        {
            _productContex = ProductContex;
        }

        public void Add(Product _inputProduct)
        {
            //throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _productContex.ProductTbl.Include(p=>p.ImagesList).ToList();
        }
    }
}
