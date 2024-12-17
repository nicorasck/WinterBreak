using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Doctor
    {
        public int DoctorID {get; set;} // Primary Key
        public int EmployeeID {get; set;}   // FOreign Key => references the entity of EmployeeID.
        public required string Department {get; set;}
        public required string DoctorGrade {get; set;}  // what sort of qualification the doctor has
    }
}