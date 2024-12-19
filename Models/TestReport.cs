using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class TestReport
    {
        public int TestReportID {get; set;}             // Primary Key, unique for each Test Report.
        public int RoomID {get; set;}                   // Foreign Key => references to the entity of Room.
        public int PatientID {get; set;}                // Foreign Key => references to the entity of Patient
        public int RecordID {get; set;}                 // Foreign Key => references to the entity of Record.
        public required string TestType {get; set;}     // What sort of test it is
        public required string TestResult {get; set;}
    }
}