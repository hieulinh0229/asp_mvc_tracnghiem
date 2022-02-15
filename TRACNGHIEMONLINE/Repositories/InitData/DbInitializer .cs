using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TRACNGHIEMONLINE.DAL;
using TRACNGHIEMONLINE.Models;
using TRACNGHIEMONLINE.Models.Enums;

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
                               
                                Username = "admin",
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
                        var student = new[] {
                            new Student()
                            {

                                Username = "student",
                                Password =  Common.Encryptor.MD5Hash("1"),
                                Email = "abc@gmail.com",
                                Avatar = null,
                                Name = "Hoang Minh Chinh",
                                Gender = "Nam",
                                Birthday = DateTime.Today,
                                Phone = "0352670035",
                                Address = "Thừa Thiên Huế"
                            }
                        };

                        var listPer = new List<Permission>();
                        var defaultePerAdmin = new Permission
                        {
                            Permission_name = EnumPermission.ADMIN.ToString(),
                            Admins = admin,
                            Students = null

                        };    
                        var defaultePerStu = new Permission
                        {
                            Permission_name = EnumPermission.STUDENT.ToString(),
                            Admins = null,
                            Students = student

                        };


                        listPer.Add(defaultePerAdmin);
                        listPer.Add(defaultePerStu);
                        context.Permissions.AddRange(listPer);

                        var tyex = new TypeExam()
                        {
                            Name = EnumTypExam.THIHOCKY.ToString(),
                            Total_questions = 2,
                            Time_to_do = 2,
                        };
                        var cl = new Class()
                        {
                            Class_name = "Công nghệ sinh học",
                            Description = "Công nghệ sinh học",
                            Students = student,
                        };

                        var sub = new Subject()
                        {
                            Subject_name = "Anh văn 1",
                            Description = "Anh văn cơ bản",
                            TypeExams = new[] {tyex },
                            Classes = new[] { cl }
                        };

                        var listQues = new[] {
                            new Question(){
                                Content = " Ullamco laboris nisi ut aliquip ex ea commodo consequat",
                                Answer_a = "laboris",
                                Answer_b = "aliquip",
                                Answer_c = "commodo",
                                Answer_d = "consequat",
                                Correct_answer = "B",
                                Subject = sub
                            },
                                new Question(){
                                Content = " Ullamco laboris nisi ut aliquip ex ea commodo consequat",
                                Answer_a = "laboris",
                                Answer_b = "aliquip",
                                Answer_c = "commodo",
                                Answer_d = "consequat",
                                Correct_answer = "D",
                                Subject = sub
                            },
                                    new Question(){
                                Content = " Ullamco laboris nisi ut aliquip ex ea commodo consequat",
                                Answer_a = "laboris",
                                Answer_b = "aliquip",
                                Answer_c = "commodo",
                                Answer_d = "consequat",
                                Correct_answer = "A",
                                Subject = sub
                            }
                        };


                        context.Subjects.Add(sub);
                        context.Questions.AddRange(listQues);
                    context.SaveChanges();
                }
            }
        }
    }
    }
}
