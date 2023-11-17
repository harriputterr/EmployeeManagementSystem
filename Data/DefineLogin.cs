using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDesktopApplicaton.Data
{
	public abstract class DefineLogin
	{
		public bool Login(string username, string password)
		{
			if (username == "Admin" && password == "Admin")
			{
				return true;
			}
			return false;
		}
		public abstract void ResetAll();
		public abstract string GetLoginUser();
	}
}
