using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IProductRepository
    {
        //void Add();
        List<Product> GetAll(int PageSize,int PageNumber);
        int GetTotalCount();
    }
}
