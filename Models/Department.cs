using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Three.Models
{
    public class Department
    {
        [Display(Name = "部门Id")]
        public int Id { get; set; }
        [Display(Name="部门名称")]
        public string Name { get; set; }
        [Display(Name = "部门地址")]
        public string Location { get; set; }
        [Display(Name = "员工人数")]
        public int EmployeeCount { get; set; }
    }
}
