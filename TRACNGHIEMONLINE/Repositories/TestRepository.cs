using System.Collections.Generic;
using TRACNGHIEMONLINE.DAL;
using TRACNGHIEMONLINE.Models;

namespace TRACNGHIEMONLINE.Repositories
{
    public class TestRepository : ITestRepository
    {

        public readonly TracNghiemDbContext _context;

        public TestRepository(TracNghiemDbContext context)
        {
            this._context = context;
        }
        public void Delete(object id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Test> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Test GetById(object id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Test obj)
        {
            _context.Add<Test>(obj);
            _context.SaveChanges();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Test obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
