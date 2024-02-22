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
            var objFormDb = _db.Products.FirstOrDefault(u => u.ProductId == product.ProductId);
            if (objFormDb != null)
            {
                objFormDb.Title = product.Title;
                objFormDb.Description = product.Description;
                objFormDb.ISBN = product.ISBN;
                objFormDb.Author = product.Author;
                objFormDb.Price = product.Price;
                objFormDb.ListPrice = product.ListPrice;
                objFormDb.Price50 = product.Price50;
                objFormDb.Price100 = product.Price100;
                objFormDb.CategoryId = product.CategoryId;

                //if(product.ImageUrl != null)
                //{
                //    objFormDb.ImageUrl = product.ImageUrl;
                //}
            }
        }
    }
}
