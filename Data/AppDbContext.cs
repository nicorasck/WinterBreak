using System;
using Microsoft.EntityFrameworkCore;
using Models;

public class AppDbContext : DbContext
{
    public DbSet<Employee> Employees {get; set;}            // A list to store Employees.
    public DbSet<Patient> Patients {get; set;}              // A list to store Patients.
    public DbSet<Address> Addresses {get; set;}             // A list to store Addresses.
    public DbSet<Room> Rooms {get; set;}                    // A list to store Rooms.
    public DbSet<RoomPatient> RoomPatients {get; set;}      // A list to store RoomPatients.
    public DbSet<TestReport> TestReports {get; set;}        // A list to store TestReports.
    public DbSet<Invoice> Invoices {get; set;}              // A list to store Invoices.
    public DbSet<Record> Records {get; set;}                // A list to Store Records.

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // The name of the DataBse is called "WinterBreak_HospitalSystem".
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=WinterBreak_HospitalSystem;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}