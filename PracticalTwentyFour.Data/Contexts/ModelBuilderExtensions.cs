using Microsoft.EntityFrameworkCore;
using PracticalTwentyFour.Data.Entities;

namespace PracticalTwentyFour.Data.Contexts
{
    public static class ModelBuilderExtensions
    {
        //Data seeder for Employees entity
        public static void SeedEmployees(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                    new Employee() { Id = 1, Name = "Noopur Bhavsar", EmailAddress = "Noopur@gmail.com", Salary = 40000, JoiningDate = new DateTime(2012, 01, 01), IsDeleted = false, DepartmentId = 1 },
                    new Employee() { Id = 2, Name = "Shivam Patel", EmailAddress = "shivam@gmail.com", Salary = 50000, JoiningDate = new DateTime(2014, 01, 01), IsDeleted = false, DepartmentId = 2 },
                    new Employee() { Id = 3, Name = "Bhavin Kareliya", EmailAddress = "bhavin@gmail.com", Salary = 60000, JoiningDate = new DateTime(2016, 01, 01), IsDeleted = false, DepartmentId = 3 },
                    new Employee() { Id = 4, Name = "Jil Patel", EmailAddress = "jil@gmail.com", Salary = 60000, JoiningDate = new DateTime(2017, 01, 01), IsDeleted = false, DepartmentId = 3 },
                    new Employee() { Id = 5, Name = "Sales Manager", EmailAddress = "sales@gmail.com", Salary = 30000, JoiningDate = new DateTime(2016, 01, 01), IsDeleted = false, DepartmentId = 4 },
                    new Employee() { Id = 6, Name = "On-site Developer", EmailAddress = "on-site@gmail.com", Salary = 35000, JoiningDate = new DateTime(2020, 01, 01), IsDeleted = false, DepartmentId = 5 }
                );
        }

        //Data seeder for Departments entity
        public static void SeedDepartments(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                    new Department() { Id = 1, Name = "HR" },
                    new Department() { Id = 2, Name = "Admin" },
                    new Department() { Id = 3, Name = "IT" },
                    new Department() { Id = 4, Name = "Sales" },
                    new Department() { Id = 5, Name = "On-site" }
                );
        }
    }
}
