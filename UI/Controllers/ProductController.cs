using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _localProductRepository;

        public ProductController(IProductRepository LocalProductRepository)
        {
            _localProductRepository = LocalProductRepository;
        }

        public IActionResult ShowAllProducts()
        {
            var ProductList = _localProductRepository.GetAll();
            return View(ProductList);
        }
    }
}