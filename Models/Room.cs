using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public enum RoomType
    {
        EmergencyDepartment = 1, IntensiveCare, Surgical, Pediatric, MaternityAndLabor, Cardiology, Oncology, Orthopedic, Neurology, Rehabilitation, Psychiatric, Radiology 
    }
    public class Room
    {
        public int RoomID {get; set;}                  // Primary Key => each room must be unique
        public required string RoomType {get; set;}    // each room must describe what sort of room it is (Enum)
        public required int RoomCapacity {get; set;}   // How many patients it can be in the room at the same tome
        public bool IsAvailable {get; set;}        // default should be True
    }
}