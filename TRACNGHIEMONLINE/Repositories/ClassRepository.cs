using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TRACNGHIEMONLINE.DAL;
using TRACNGHIEMONLINE.Models;

namespace TRACNGHIEMONLINE.Repositories
{
    public class ClassRepository : IClassRepository
    {
        public readonly TracNghiemDbContext _context;

        public ClassRepository(TracNghiemDbContext context)
        {
            this._context = context;
        }
        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Class> GetAll()
        {
            return _context.Classes.AsQueryable();
        }

        public Class GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Class obj)
        {
            _context.Add<Class>(obj);
            _context.SaveChanges();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Class obj)
        {
            throw new NotImplementedException();
        }
    }
}
