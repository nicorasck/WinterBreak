using System;
using Microsoft.EntityFrameworkCore;
using Models;

public class AppDbContext : DbContext
{
    public DbSet<Patient> Patients {get; set;}           // a list to store Patients.
    public DbSet<Employee> Employees {get; set;}         // a list to store Employees.
    public DbSet<Doctor> Doctors {get; set;}             // a list to store Doctors.
    public DbSet<Nurse> Nurses {get; set;}              // a list to store Nurses.
    public DbSet<Room> Rooms {get; set;}                // a list to store Rooms.
    public DbSet<Reception> Receptions {get; set;}      // a list tot store which employee will be in the reception.
    public DbSet<TestReport> TestReports {get; set;}    // a list to store TestReports.
    public DbSet<Invoice> Invoices {get; set;}          // a list to store Invoices.


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // The name of the DataBse is called "WinterBreak_HospitalSystem".
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=WinterBreak_HospitalSystem;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}