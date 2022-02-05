using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TRACNGHIEMONLINE.DAL;
using TRACNGHIEMONLINE.Models;

namespace TRACNGHIEMONLINE.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        public readonly TracNghiemDbContext _context;

        public SubjectRepository(TracNghiemDbContext context)
        {
            this._context = context;
        }
        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Subject> GetAll()
        {
            return _context.Subjects.AsQueryable();
        }

        public Subject GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Subject obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Subject obj)
        {
            throw new NotImplementedException();
        }
    }
}
