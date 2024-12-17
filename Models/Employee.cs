using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Employee
    {
        public int EmployeeID {get; set;}   // Primary Key
        public required int PinCode {get; set;} // PK => unique pin code (to get access in hospital system)
        public required string FirstName {get; set;}
        public required string LastName {get; set;}
        public required string Gender {get; set;}
        public required string PhoneNumber {get; set;}
        public required string Email {get; set;}
        public required string Street {get; set;}
        public required string ZipCode {get; set;}
        public required string City {get; set;}
        public required string WorkTitle {get; set;}
    }
}