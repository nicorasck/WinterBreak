using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Patient
    {
        public int PatientID {get; set;}    // Primary Key
        public required string FirstName {get; set;}
        public required string LastName {get; set;}
        public required DateOnly BirthYear {get; set;}
        public required string Gender {get; set;}
        public required string PhoneNumber {get; set;}  // not necessary to be an integer!
        public string Email {get; set;} // not necessary with an E-mail
        public required string Street {get; set;}
        public required string ZipCode {get; set;}
        public required string City {get; set;}
    }
}