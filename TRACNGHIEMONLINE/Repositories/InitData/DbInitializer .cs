using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TRACNGHIEMONLINE.DAL;
using TRACNGHIEMONLINE.Models;

namespace TRACNGHIEMONLINE.Repositories.InitData
{
    public class DbInitializer : IDbInitializer
    {
        private readonly IServiceScopeFactory _scopeFactory;

        public DbInitializer(IServiceScopeFactory scopeFactory)
        {
            this._scopeFactory = scopeFactory;
        }

        public void Initialize()
        {
            using (var serviceScope = _scopeFactory.CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<TracNghiemDbContext>())
                {
                    context.Database.Migrate();
                }
            }
        }

        public void SeedData()
        {
            using (var serviceScope = _scopeFactory.CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<TracNghiemDbContext>())
                {

                    //add admin user
                    if (!context.Permissions.Any() )
                    {
                        var admin = new[] {
                            new Admin()
                            {
                               
                                Username = "William",
                                Password =  Common.Encryptor.MD5Hash("1"),
                                Email = "abc@gmail.com",
                                Avatar = null,
                                Name = "Hoang Minh Chinh",
                                Gender = "Nam",
                                Birthday = DateTime.Today,
                                Phone = "0352670035",
                                Last_login = DateTime.Today,
                                Timestamps = DateTime.Today,
                                Address = "Thừa Thiên Huế"
                            }
                        };
                        var listPer = new List<Permission>();
                        var defaultePerAdmin = new Permission
                        {
                            Permission_name = EnumPermission.ADMIN,
                            Admins = admin,
                            Students = null

                        };    
                        var defaultePerStu = new Permission
                        {
                            Permission_name = EnumPermission.STUDENT,
                            Admins = null,
                            Students = null

                        };
                        listPer.Add(defaultePerAdmin);
                        listPer.Add(defaultePerStu);
                        context.Permissions.AddRange(listPer);
                    }

                    context.SaveChanges();
                }
            }
        }
    }
}
