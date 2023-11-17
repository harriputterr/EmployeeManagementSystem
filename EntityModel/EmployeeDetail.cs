using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiDesktopApplicaton.EntityModel
{
    //mapping table in database with this class
    [Table("EmployeeDetail")]
    public class EmployeeDetail
    {
        public EmployeeDetail()
        {
        }

        public EmployeeDetail(int id, string fullName, string address, string contact, string email, string designation, int departmentId, DateTime dateOfJoin,
            string wageRate, string workedHour)
        {
            EmployeeID = id;
            FullName = fullName;
            Address = address;
            Contact = contact;
            Email = email;
            Designation = designation;
            DepartmentID = departmentId;
           DateOfJoin =  dateOfJoin;
        }
        //used for a primary key column (Primary key- column contains unique values)
        [Key]
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        public int? DepartmentID { get; set; }
        public DateTime? DateOfJoin { get; set; }
    }
}