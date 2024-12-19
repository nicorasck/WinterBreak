using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Record
    {
        public int TestReportID {get; set;} // Foreign Key => references to the entity of Test Report.
        public int RecordNumber {get; set;}     // Every Record/Journal has some number for each Patient.
        public int AppBookNumber {get; set;}    // Every AppBook has some number for each Patient.
    }
}