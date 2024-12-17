using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Record
    {
        public int RecordID {get; set;}     // Primary Key => Every Record/Journal belongs to a specific Patient.
        public int AppBookID {get; set;}    // Primary Key => Every AppBook belongs to a specific Patient.
    }
}