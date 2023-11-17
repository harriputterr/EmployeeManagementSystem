using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDesktopApplicaton.EntityModel
{
	[Table("UserDetail")]
	public class UserDetail
	{
		[Key]
		public int UserID { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
	}
}
