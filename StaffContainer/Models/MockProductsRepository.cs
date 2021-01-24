using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffContainer.Models
{

    public class MockProductsRepository : IProductsRepository
    {
        private readonly List<Products> _productsList;
        public MockProductsRepository()
        {
            _productsList = new List<Products>()
            {
                new Products()
                { Id = 1,
                    Name = "Pen",
                    Description = "Black Pen",
                    Price = 5,
                    Remaining = 10
                },
                new Products()
                {
                    Id = 2,
                    Name = "Paper",
                    Description = "Lined Paper",
                    Price = 2,
                    Remaining = 10
                },
                new Products()
                {
                    Id = 3,
                    Name = "Plant",
                    Description = "Cactus",
                    Price = 10,
                    Remaining = 10
                },
            };
        }

        public IEnumerable<Products> GetAllProducts()
        {
            return _productsList;
        }

        public Products GetProducts(int Id)
        {
            return _productsList.FirstOrDefault(p => p.Id == Id);
        }
    }
        
    
}
