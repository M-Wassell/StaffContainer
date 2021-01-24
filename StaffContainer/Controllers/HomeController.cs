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
        public ViewResult Details()
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Products = _productsRepository.GetProducts(2),
                PageTitle = "Product Details"

            };
            return View(homeDetailsViewModel);
        }
    }
}
