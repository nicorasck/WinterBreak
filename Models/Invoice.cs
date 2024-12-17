using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Invoice
    {
        public int InvoiceID {get; set;}    // Primary Key
        public int PatientID {get; set;}    // Foreign Key => references the entity of Patient.
    }
}