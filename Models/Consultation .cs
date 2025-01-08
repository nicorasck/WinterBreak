using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Consultation
    {
        public int ConsultationID {get; set;}                   // Primary Key
        public int PatientID {get; set;}                        // Foreign Key => references to the entity of Patent.
        public int RoomID {get; set;}                           // Foreign Key => references to the entity o Room.
        public int RecordID {get; set;}                         // Foreign Key => references to the entity of Record.
        public int EmployeeID {get; set;}                       // Foreign Key => references to the entity of Employee.
        public required DateTime ConsultationDate {get; set;}   // What Date the room was occupied.
        public string Notes {get; set;}                         // Can be NULL, not necessary to take notes.
    }
}