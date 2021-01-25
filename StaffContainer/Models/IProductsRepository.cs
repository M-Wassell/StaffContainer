using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffContainer.Models
{
    public interface IProductsRepository
    {
        Products GetProducts(int Id);
        IEnumerable<Products> GetAllProducts();
        Products Add(Products products);
    }
}
