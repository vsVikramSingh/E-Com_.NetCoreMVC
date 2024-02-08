using E_ComWeb.Models;
using ECom.DataAccess.Repositotry.IRepository;
using ECom.Models;


namespace ECom.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}
