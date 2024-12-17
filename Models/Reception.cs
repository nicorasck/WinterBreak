using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Reception
    {
        public int ReceptionID {get; set;}  // Foreign Key => references to the entity of Employee.
    }
}