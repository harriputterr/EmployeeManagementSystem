using MauiDesktopApplicaton.EntityModel;
using MauiDesktopApplicaton.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MauiDesktopApplicaton.Data.EmployeeManagement;

namespace MauiDesktopApplicaton.Data
{
	//Implement all CURD(Create,Update.Read,Delete) methods Using Interface
	public class EmployeeManagement : IEmployeeManagement  
    {
        EmployeeContext DBContext = new EmployeeContext();
        //For read data of a specific employee by employeeID
        public EmployeeDetail GetEmployeeDetail(int Id)
        {
            try
            {
                var row = DBContext.employeeDetails.Where(model => model.EmployeeID == Id).FirstOrDefault();
                return row;
            }
            catch (Exception e)
            {
                return null;
            }

        }
        //Read data of all employees
        public List<EmployeeDetail> GetAll()
        {
            List<EmployeeDetail> data = new List<EmployeeDetail>();
            try
            {
                var row = DBContext.employeeDetails.ToList();
                if (row != null)
                {
                    data = row;
                }
            }

            catch (Exception e)
            {

            }
            return data;
        }
        //Read all departments data
        public List<DepartmentDetail> GetAllDepartment()
        {
            List<DepartmentDetail> data = new List<DepartmentDetail>();
            try
            {
                var row = DBContext.departmentDetails.ToList();
                if (row != null)
                {
                    data = row;
                }
            }

            catch (Exception e)
            {

            }
            return data;
        }
        //Read employee data based on name and password on login
		public EmployeeDetail GetEmployeeDetail(string username, string password)
		{
			return DBContext.employeeDetails.Where(model => model.FullName == username && model.Password == password).FirstOrDefault();
		}

        //Update employee data
		public int Update(EmployeeDetail updateTicket)
        {
            try
            {
                if (updateTicket.EmployeeID > 0)
                {
                    DBContext.Entry(updateTicket).State = System.Data.Entity.EntityState.Modified;
                }
                return DBContext.SaveChanges();
            }

            catch (Exception e)
            {
                return 0;
            }
        }
        //Add employee data
        public int Add(EmployeeDetail newTicket)
        {
            try
            {
                DBContext.employeeDetails.Add(newTicket);
                return DBContext.SaveChanges();
            }

            catch (Exception e)
            {
                return 0;

            }
        }
        //Delete employee data
        public int Delete(int Id)
        {
            try
            {
                var employee = DBContext.employeeDetails.Where(model => model.EmployeeID == Id).FirstOrDefault();
                DBContext.employeeDetails.Remove(employee);
                return DBContext.SaveChanges();
            }

            catch (Exception e)
            {
                return 0;
            }
        }


    }
}
