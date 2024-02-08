using E_ComWeb.Data;
using E_ComWeb.Models;
using ECom.DataAccess.Repository.IRepository;
using ECom.Models;
using System;


namespace ECom.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product product)
        {
            _db.Products.Update(product);
        }
    }
}
