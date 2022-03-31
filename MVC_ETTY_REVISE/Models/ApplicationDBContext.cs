using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace MVC_ETTY_REVISE.Models
{
    public class ApplicationDBContext:DbContext
    {  
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
       public  DbSet<Customer> GetCustomers { get; set; }
         public DbSet<Location>GetLocations { get; set; }
    }
}
