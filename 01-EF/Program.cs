using _01_EF.Context;
using _01_EF.Entities;

namespace _01_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext context = new ITIDbContext();
            #region Insert
            Instructor Ins01 = new Instructor() { Name = "Islam", Bonus = 2000, Salary = 50000000, HourRate = 5, Address = "Alex" };
            Instructor Ins02 = new Instructor() { Name = "Hamobozo", Bonus = 2000, Salary = 50000000, HourRate = 5, Address = "SuadiArabia" };

            Console.WriteLine(context.Entry(Ins01).State); // Detached

            context.Add(Ins01);
            context.Add(Ins02);

            Console.WriteLine(context.Entry(Ins01).State); //Added

            context.SaveChanges();
            Console.WriteLine(context.Entry(Ins01).State); // Unchanged



            Student stu01 = new Student() { FName = "Islam", LName = "Mohamed", Address = "Alex", Age = 22 };


            Console.WriteLine(context.Entry(stu01).State); // Detached

            context.Add(stu01);

            Console.WriteLine(context.Entry(stu01).State); //Added

            context.SaveChanges();
            Console.WriteLine(context.Entry(stu01).State); // Unchanged



            Course course01 = new Course() { name = ".NET", description = "nothing", duration = 100 };



            Console.WriteLine(context.Entry(course01).State); // Detached

            context.Add(course01);

            Console.WriteLine(context.Entry(course01).State); //Added

            context.SaveChanges();
            Console.WriteLine(context.Entry(course01).State); // Unchanged



            Department dept01 = new Department() { Name = "ITI", HiringDate = DateTime.UtcNow };
            Console.WriteLine(context.Entry(dept01).State); // Detached

            context.Add(dept01);

            Console.WriteLine(context.Entry(dept01).State); //Added

            context.SaveChanges();
            Console.WriteLine(context.Entry(dept01).State); // Unchanged



            Topic top01 = new Topic() { Name = "Migrations" };


            Console.WriteLine(context.Entry(top01).State); // Detached

            context.Add(top01);
            Console.WriteLine(context.Entry(top01).State); //Added

            context.SaveChanges();
            Console.WriteLine(context.Entry(top01).State); // Unchanged


            #endregion


            #region Select
            var instructor = (from Ins in context.Instructors
                              where Ins.Id == 2
                              select Ins).FirstOrDefault();
            Console.WriteLine(instructor?.Name ?? "Empty");
            #endregion

            #region Update
            instructor.Name = "Eslam";
            Console.WriteLine(context.Entry(instructor).State);
            context.SaveChanges();
            #endregion

            #region Delete
            Console.WriteLine(context.Entry(instructor).State);
            context.Remove(instructor);

            Console.WriteLine(context.Entry(instructor).State);
            context.SaveChanges();

            Console.WriteLine(context.Entry(instructor).State);

            #endregion
        }
    }
}
