using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Consultation
    {
        public int RoomID {get; set;}                       // Foreign Key => references to the entity o Room.
        public int PatientID {get; set;}                    // Foreign Key => references to the entity of Patent.
        public required DateTime AdmissionDate {get; set;}  // What Date the room was occupied.
        public required DateOnly DischargeDate {get; set;}  // What Date the room was discharged.
    }
}