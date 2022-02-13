using Microsoft.EntityFrameworkCore;
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
            return _context.Subjects.Include(x=>x.TypeExams).AsQueryable();
        }

        public Subject GetById(object id)
        {
            return _context.Subjects.Include(x=>x.Questions).Include(x=>x.TypeExams).Where(x => x.Id_subject.ToString().Equals(id.ToString())).FirstOrDefault();
        }

        public void Insert(Subject obj)
        {
            _context.Add<Subject>(obj);
            _context.SaveChanges();
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
