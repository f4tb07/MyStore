﻿using System;
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

       
       

        public List<Product> GetAll(int PageSize=8, int PageNumber=1)
        {
            return _productContex.ProductTbl.Include(p => p.ImagesList).Skip((PageNumber-1)*PageSize).Take(PageSize).ToList();
        }

        public int GetTotalCount()
        {
            return _productContex.ProductTbl.Count();
        }
    }
}
