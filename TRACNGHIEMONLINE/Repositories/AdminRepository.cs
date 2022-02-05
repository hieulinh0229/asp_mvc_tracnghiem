using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TRACNGHIEMONLINE.DAL;
using TRACNGHIEMONLINE.Models;

namespace TRACNGHIEMONLINE.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        public readonly TracNghiemDbContext _context;

        public AdminRepository(TracNghiemDbContext context)
        {
            this._context = context;
        }
        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Admin> GetAll()
        {
            var ss = _context.Permissions.Include(e => e.Admins).AsQueryable().ToList();
            return _context.Admins.Include(e => e.Permission).AsQueryable();
        }

        public Admin GetById(object id)
        {
            var ss = _context.Permissions.Include(e => e.Admins).AsQueryable().ToList();
            return _context.Admins.Include(e => e.Permission).Where(x=>x.Id_admin.ToString().Equals(id.ToString())).FirstOrDefault();
          
        }

        public void Insert(Admin obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Admin obj)
        {
            if(obj != null)
            {
                _context.Update<Admin>(obj);
                _context.SaveChanges();
            }
        }
    }
}
