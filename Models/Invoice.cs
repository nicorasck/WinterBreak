using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public enum PaymentStatus
    {
        Paid = 1, Pending, Cancelled, Overdue, PaymentReminder, DebtCollection
    }
    public class Invoice
    {
        public int InvoiceID {get; set;}                    // Primary Key, each Invoice is unique.
        public int PatientID {get; set;}                    // Foreign Key => references the entity of Patient.
        public required DateTime DateIssued {get; set;}     // When the Invoice/Bill was sent/created.
        public required string PaymentStatus {get; set;}    // Using enum for this.
        public int Amount {get; set;}                       // The Amount each Patient has to pay.
    }
}