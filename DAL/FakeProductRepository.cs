using System;
using System.Collections.Generic;
using System.Text;
using Contracts;
using Domain;

namespace DAL
{
    public class FakeProductRepository :IProductRepository
    {
     
     private List<Product> FakeProductDb = new List<Product>();

        public void Add(Product _inputProduct)
        {
            FakeProductDb.Add(_inputProduct);
        }

        public List<Product> GetAll()
        {
           return FakeProductDb;
        }
    }
   
}
