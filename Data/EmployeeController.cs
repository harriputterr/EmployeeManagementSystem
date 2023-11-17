using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiDesktopApplicaton.EntityModel;
using MauiDesktopApplicaton.Interface;

namespace MauiDesktopApplicaton.Data
{
    public class EmployeeController
    {
        int count = 3;
        private readonly IEmployeeManagement employeeManagement;
        public EmployeeController(IEmployeeManagement _employeeManagement)
        {
            employeeManagement= _employeeManagement;
        }

        //Get all data of employees 
        public Task<EmployeeDetail[]> GetAllEmployeesAsync()
        {

            return Task.FromResult(employeeManagement.GetAll().ToArray());
        }
        //Get all data of department
        public Task<DepartmentDetail[]> GetAllDepartmentsAsync()
        {

            return Task.FromResult(employeeManagement.GetAllDepartment().ToArray());
        }
        //Get specific employee data basis on employeeId
        public EmployeeDetail GetEmployeeDetail(int id)
        {
            return employeeManagement.GetEmployeeDetail(id);
        }
        //Create new employee
        public bool CreateEmployeeAsync(EmployeeDetail employeeDetail)
        {
           return employeeManagement.Add(employeeDetail)>0;
        }
        //Update employee
        public bool UpdateEmployeeAsync(EmployeeDetail employeeDetail)
        {
          return employeeManagement.Update(employeeDetail) > 0;
        }

        //Delete Employee
        public bool DeleteEmployeeAsync(int Id)
        {
            
            return employeeManagement.Delete(Id) > 0;
        }

    }
}
