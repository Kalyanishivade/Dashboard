using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baclground.Models;

public class EmployeeModel
{
    public string EmployeeCode { get; set; }
    public string Name { get; set; }
    public string Role { get; set; }
    public string Type { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Location { get; set; }
    public DateTime JoinedDate { get; set; }
    public DateTime DOB { get; set; }
    public string BloodGroup { get; set; }
    public string Manager { get; set; }
    public string Address { get; set; }
}
