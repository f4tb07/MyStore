using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IProductRepository
    {
        void Add(Product _inputProduct);
        List<Product> GetAll();
    }
}
