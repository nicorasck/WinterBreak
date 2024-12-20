using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public enum Gender // Refers to Class for Employee and Patient.
    {
        Male = 1, Female, Queer, NonBinary, TheyThem, Transgender, Other
    }
    public class Address    // Normalizing for Employee and Patient.
    {
        public int AddressID {get; set;}                // each address is unique
        public required string PhoneNumber {get; set;}
        public required string Email {get; set;}
        public required string Street {get; set;}
        public required string ZipCode {get; set;}
        public required string City {get; set;}
        public string State {get; set;}
        public required string Country {get; set;}
    }
}