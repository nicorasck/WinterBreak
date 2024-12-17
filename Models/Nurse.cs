using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Nurse
    {
        public int EmployeeID {get; set;}   // FOreign Key => references the entity of Employee.
    }
}