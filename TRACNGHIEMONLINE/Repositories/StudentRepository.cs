using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TRACNGHIEMONLINE.DAL;
using TRACNGHIEMONLINE.Models;

namespace TRACNGHIEMONLINE.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public readonly TracNghiemDbContext _context;

        public StudentRepository(TracNghiemDbContext context)
        {
            this._context = context;
        }
        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Student obj)
        {
            var per = _context.Permissions.Where(x => x.Permission_name.Equals(EnumPermission.STUDENT.ToString())).FirstOrDefault();
            if(per!=null)
            {
                obj.permission = per;
            }
            _context.Add<Student>(obj);
            _context.SaveChanges();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Student obj)
        {
            throw new NotImplementedException();
        }
    }
}
