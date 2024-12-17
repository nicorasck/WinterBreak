using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class TestReport
    {
        public int TestReportID {get; set;} // Primary Key
        public int PatientID {get; set;}    // Foreign Key => references to the entity of Patient
        public required string TestType {get; set;} // What sort of test it is
        public required string TestResult {get; set;}
    }
}