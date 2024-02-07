using E_ComWeb.Models;
using ECom.DataAccess.Repositotry.IRepository;


namespace ECom.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
