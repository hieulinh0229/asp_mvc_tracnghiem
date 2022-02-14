using Microsoft.EntityFrameworkCore;
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
            return _context.Students.Include(e => e.permission).AsQueryable();
        }

        public Student GetById(object id)
        {
            return _context.Students.Include(e => e.permission).Include(x=>x.Class).ThenInclude(x=>x.Subjects).Where(x => x.Id_student.ToString().Equals(id.ToString())).FirstOrDefault();
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
            if (obj != null)
            {
                _context.Update<Student>(obj);
                _context.SaveChanges();
            }
        }
    }
}
