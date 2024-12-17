using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Room
    {
        public int RoomID {get; set;}   // Primary Key => each room must be unique
        public required string RoomType {get; set;} // each room must describe what sort of room it is
        public required int RoomCapacity {get; set;}    // How many patients it can be in the room at the same tome
        public bool RoomIsAvailable {get; set;} // default is False
    }
}