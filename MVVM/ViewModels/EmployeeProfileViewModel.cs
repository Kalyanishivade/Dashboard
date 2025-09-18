using Baclground.Models;
using System;

namespace Baclground.MVVM.ViewModels;

public class EmployeeProfileViewModel
{
    public EmployeeModel Employee { get; set; }

    public EmployeeProfileViewModel()
    {
        Employee = new EmployeeModel
        {
            EmployeeCode = "KMP720",
            Name = "JAYA JAMNIK",
            Role = "HR RECRUITER | HR",
            Type = "Full Time",
            Phone = "N/A",
            Email = "jaya.jamnik@housiey.com",
            Location = "Pune",
            JoinedDate = new DateTime(2024, 8, 21),
            DOB = new DateTime(1999, 3, 21),
            BloodGroup = "AB+",
            Manager = "PINKY TAPARE",
            Address = "Mane building, infront of Sarita beauty parlour, near Ganesh Sahkari bank, Krishna chowk, new sangvi, Pune 411027, India"
        };
    }
}
