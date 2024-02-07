using E_ComWeb.Data;
using ECom.DataAccess.Repository.IRepository;


namespace ECom.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public ICategoryRepository Category { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
        } 

        public void Save()
        {
            _db.SaveChanges();
            Category = new CategoryRepository(_db);
        }
    }
}
