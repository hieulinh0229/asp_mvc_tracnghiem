using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TRACNGHIEMONLINE.DAL;
using TRACNGHIEMONLINE.Models;

namespace TRACNGHIEMONLINE.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        public readonly TracNghiemDbContext _context;

        public QuestionRepository(TracNghiemDbContext context)
        {
            this._context = context;
        }
        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Question> GetAll()
        {
            return _context.Questions.Include(e => e.Subject).ThenInclude(x=>x.Tests).AsQueryable();
        }

        public Question GetById(object id)
        {
            return _context.Questions.Include(e => e.Subject).ThenInclude(x => x.Tests).Where(x => x.Id_question.ToString().Equals(id.ToString())).FirstOrDefault();
        }

        public void Insert(Question obj)
        {
            _context.Add<Question>(obj);
            _context.SaveChanges();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Question obj)
        {
            throw new NotImplementedException();
        }
    }
}
