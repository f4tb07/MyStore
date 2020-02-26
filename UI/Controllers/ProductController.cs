using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Mvc;
using UI.Models;
using UI.Models.Products;

namespace UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _localProductRepository;

        public ProductController(IProductRepository LocalProductRepository)
        {
            _localProductRepository = LocalProductRepository;
           // _localProductRepository.Add();
        }

        public IActionResult ShowAllProducts(  int PageSize=8,int PageNumber=1)
        {
            MProduct4View ProductModel= new MProduct4View();
            ProductModel.ProductPageInfo = new MPageInfo(PageSize, _localProductRepository.GetTotalCount(),PageNumber);
            ProductModel.ProductList2View = _localProductRepository.GetAll(PageSize,PageNumber);
            return View(ProductModel);
        }
    }
}