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
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<CoverType> GetAll(string? includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public CoverType GetFirstOrDefault(Expression<Func<CoverType, bool>> filter, string? includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Update(CoverType obj)
        {
            _db.CoverTypes.Update(obj);
        }
    }
}
