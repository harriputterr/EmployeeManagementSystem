using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace MauiDesktopApplicaton.EntityModel
{
    public class EmployeeContext : DbContext
    {   //Set connection string for  Connect sql database
        public static string strConnectionStringTemplate = @"Data Source =localhost; Initial Catalog=EmployeeManagement;Integrated Security=False;User Id=sa;Password=system123#;MultipleActiveResultSets=True";
        public EmployeeContext()
        : base(strConnectionStringTemplate)
        {
            Database.SetInitializer<EmployeeContext>(null);
        }

        public virtual DbSet<EmployeeDetail> employeeDetails { get; set; }
        public virtual DbSet<DepartmentDetail> departmentDetails { get; set; }
     
    }
}
