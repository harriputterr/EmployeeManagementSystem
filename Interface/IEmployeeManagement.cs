using MauiDesktopApplicaton.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDesktopApplicaton.Interface
{
    public interface IEmployeeManagement
    {
        int Add(EmployeeDetail employeeDetail);
        int Update(EmployeeDetail employeeDetail);
        int Delete(int EmployeeID);
        EmployeeDetail GetEmployeeDetail(int EmployeeID);
		EmployeeDetail GetEmployeeDetail(string username,string password);

		List<EmployeeDetail> GetAll();

        List<DepartmentDetail> GetAllDepartment();
    }
}
