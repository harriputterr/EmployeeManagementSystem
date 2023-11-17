﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDesktopApplicaton.EntityModel
{
    [Table("DepartmentDetail")]
    public class DepartmentDetail
    {
        [Key]
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
    }
}
