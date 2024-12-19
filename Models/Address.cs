using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public enum Gender
    {
        Male = 1, Female, Queer, NonBinary, TheyThem, Transgender, Other
    }
    public class Address
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