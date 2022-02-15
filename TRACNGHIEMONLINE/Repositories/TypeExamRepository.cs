using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TRACNGHIEMONLINE.DAL;
using TRACNGHIEMONLINE.Models;

namespace TRACNGHIEMONLINE.Repositories
{
    public class TypeExamRepository : ITypeExamRepository
    {
        public readonly TracNghiemDbContext _context;

        public TypeExamRepository(TracNghiemDbContext context)
        {
            this._context = context;
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TypeExam> GetAll()
        {
            return _context.TypeExams.Include(e=>e.Subjects).AsQueryable();
        }

        public TypeExam GetById(object id)
        {
            return _context.TypeExams.Where(x=>x.Id.ToString().Equals(id.ToString())).Include(x=>x.Tests).FirstOrDefault();
        }

        public void Insert(TypeExam obj)
        {
            _context.Add<TypeExam>(obj);
            _context.SaveChanges();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(TypeExam obj)
        {
            throw new NotImplementedException();
        }
    } 

    
}
