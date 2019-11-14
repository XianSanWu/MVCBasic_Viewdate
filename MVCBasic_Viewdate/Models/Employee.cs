using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCBasic_Viewdate.Models
{
    public class Employee
    {
        [Display(Name = "員工編號")] 
        public int Id { get; set; }
        [Display(Name = "員工姓名")] 
        public string Name { get; set; }
        [Display(Name = "員工電話")] 
        public string Phone { get; set; }
        [Display(Name = "員工信箱")] 
        public string Email { get; set; }

    }
}