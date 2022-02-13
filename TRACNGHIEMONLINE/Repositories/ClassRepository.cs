using Microsoft.EntityFrameworkCore;
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
            return _context.Classes.Include(x => x.Subjects).Include(x => x.Students)
                .ThenInclude(x=>x.Tests).ThenInclude(x => x.Type).AsQueryable();
        }

        public Class GetById(object id)
        {
            return _context.Classes.Include(x => x.Subjects).Include(x => x.Students)
                .ThenInclude(x => x.Tests).ThenInclude(x => x.Type).Where(x => x.Id_class.ToString().Equals(id.ToString())).FirstOrDefault();
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
