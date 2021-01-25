using Microsoft.AspNetCore.Mvc;
using StaffContainer.Models;
using StaffContainer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffContainer.Controllers
{
    public class HomeController : Controller
    {
        //Constructor Injection
        private readonly IProductsRepository _productsRepository;

        public HomeController(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }
        public ViewResult Index()
        {
            var model = _productsRepository.GetAllProducts();
            return View(model);
        }
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Products = _productsRepository.GetProducts(id ?? 1),
                PageTitle = "Product Details"

            };
            return View(homeDetailsViewModel);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Products products)
        {
            if (ModelState.IsValid)
            {
                Products newProduct = _productsRepository.Add(products);
                return RedirectToAction("details", new { id = newProduct.Id });
            }

            return View();
        }
    }
}
