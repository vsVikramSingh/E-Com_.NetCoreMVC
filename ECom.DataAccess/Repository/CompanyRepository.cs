using E_ComWeb.Data;
using ECom.DataAccess.Repository.IRepository;
using ECom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Company company)
        {
            var objFormDb = _db.Companies.FirstOrDefault(u => u.CompanyId == company.CompanyId);
            if (objFormDb != null)
            {
                objFormDb.Name = company.Name;
                objFormDb.StreetAddress = company.StreetAddress;
                objFormDb.City = company.City;
                objFormDb.State = company.State;
                objFormDb.PostalCode = company.PostalCode;
                objFormDb.PhoneNumber = company.PhoneNumber;
            }
        }
    }
}
