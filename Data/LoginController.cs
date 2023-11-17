
using MauiDesktopApplicaton.Interface;

namespace MauiDesktopApplicaton.Data
{
    public class LoginController :DefineLogin
    {
        public  bool IsLoggedIn =false;
        public  bool IsAdmin =false;
        private string _username;
        public  int _employeeID;
		private readonly IEmployeeManagement employeeManagement;

		public LoginController(IEmployeeManagement _employeeManagement)
        {
			employeeManagement = _employeeManagement;
		}
		//Validate Login user 
		public bool Login(string username,string password)
        {
            _username = username;
			if (username == "Admin" && password == "Admin")
			{
				IsLoggedIn = true;
				IsAdmin = true;
			}
			else
			{
				var emp = employeeManagement.GetEmployeeDetail(username, password);
				if (emp != null)
				{
					IsLoggedIn = true;
					_employeeID=emp.EmployeeID;
				}
			}
			return IsLoggedIn;
        }
		//Function to reset all values that was updated after login to make a user logout 
		public override void ResetAll()
		{
			IsLoggedIn=false;
			_employeeID = 0;
			IsAdmin=false;
			_username = "";
		}
		public override string GetLoginUser()
		{
			return _username;
		}
	}
}
