using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public enum WorkTitle
    {
        Doctor = 1, Nurse, Reception, Administrator
    }
    public class Employee
    {
        public int EmployeeID {get; set;}               // Primary Key, each Employee is unique.
        public int AddressID {get; set;}                // Foreign Key => references to the entity of Address.
        public required string FirstName {get; set;}
        public required string LastName {get; set;}
        public required DateOnly BirthYear {get; set;}
        public required Gender Gender {get; set;}       // Enum is used bc there are several of genders (see class for Address).
        public int PinCode {get; set;}                  // pin code (to get access in hospital system)
        public required int Salary {get; set;}
        public required WorkTitle WorkTitle {get; set;} // Enum is used here, to rang the titles.
    }
}