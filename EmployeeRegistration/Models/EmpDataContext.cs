using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeRegistration.Models
{
    public class EmpDataContext : DbContext
    {
        public EmpDataContext() : base("empreg")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EmpDataContext,
            EmployeeRegistration.Migrations.Configuration>("empreg"));
        }
        public virtual DbSet<Employee> employees { get; set; }
    }
}