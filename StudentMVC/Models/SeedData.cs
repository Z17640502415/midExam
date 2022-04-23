using Microsoft.EntityFrameworkCore;
using StudentMVC.Data;

namespace StudentMVC.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new StudentMVCContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<StudentMVCContext>>()))
            {
                // Look for any movies.
                if (context.Students.Any())
                {
                    return;   // DB has been seeded
                }

                context.Students.AddRange(
                    new Students
                    {
                        Name = "张三",
                        Sex = "男",
                        Age = 50,
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Phone = "13245678945",
                        tempreture = 36,
                        Data = DateTime.Parse("2001-1-21")

                    },

                    new Students
                    {
                        Name = "花花",
                        Sex = "女",
                        Age = 20,
                        ReleaseDate = DateTime.Parse("2002-2-12"),
                        Phone = "13245678944",
                        tempreture = 36,
                        Data = DateTime.Parse("2022-1-21")

                    },

                    new Students
                    {
                        Name = "小明",
                        Sex = "男",
                        Age = 30,
                        ReleaseDate = DateTime.Parse("1982-2-12"),
                        Phone = "13245678945",
                        tempreture = 36,
                        Data = DateTime.Parse("2021-12-21")

                    }


                );
                context.SaveChanges();
            }
        }
    }
}
