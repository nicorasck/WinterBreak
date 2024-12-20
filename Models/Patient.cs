using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Patient
    {
        public int PatientID {get; set;}    // Primary Key
        public int RoomID {get; set;}       // Foreign Key => references the entity of Room. 
        public int AddressID {get; set;}    // Foreign Key => references the entity of Address.
        public required string FirstName {get; set;}
        public required string LastName {get; set;}
        public required DateOnly BirthYear {get; set;}
        public required Gender Gender {get; set;}       // Enum is used bc there are several of genders (see class for Address).
        public required string EmergencyContactName {get; set;}
        public required string EmergencyContactNumber {get; set;}
    }
}