using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace Reports1
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options)
            : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:testsqlservermj.database.windows.net,1433;Initial Catalog = ProgramminClasses; Persist Security Info = False; UserID = dbadmin; Password = Qwer!234; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate =False; Connection Timeout = 30; ");
        }
    }

    public class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string companyName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new CustomerContext())
            {
                var customers = context.Customers
                    .Where(c => c.FirstName == "Baizhan" && c.LastName == "Dossanov" && c.CompanyName == "Samsung")
                    .ToList();

                foreach (var customer in customers)
                {
                    Console.WriteLine($"{customer.firstName} {customer.lastName} from {customer.companyName}");
                }
            }
            //using (var context = new CustomerContext(new DbContextOptionsBuilder<CustomerContext>().UseSqlServer(@"Server=tcp:testsqlservermj.database.windows.net,1433;Initial Catalog = ProgramminClasses; Persist Security Info = False; UserID = dbadmin; Password = Qwer!1234; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate =False; Connection Timeout = 30; " ));
            //{
            //    var customer = new Customer { firstName = FirstName, lastName = LastName, companyName = CompanyName };
            //    context.Customers.Add(customer);
            //    context.SaveChanges();
            //}
        }
    }
}