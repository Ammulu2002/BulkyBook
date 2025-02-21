using BulkyBook.DataAccess.Repository.Irepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<ApplicationUser> GetAll(string? includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser GetFirstOrDefault(Expression<Func<ApplicationUser, bool>> filter, string? includeProperties = null)
        {
            throw new NotImplementedException();
        }
    }
}
