using System;
using Microsoft.EntityFrameworkCore;
using Models;

public class AppDbContext : DbContext
{
    public DbSet<Address> Addresses {get; set;}             // A list to store Addresses.
    public DbSet<Consultation> Consultations {get; set;}      // A list to store RoomPatients.cON
    public DbSet<Employee> Employees {get; set;}            // A list to store Employees.
    public DbSet<Invoice> Invoices {get; set;}              // A list to store Invoices.
    public DbSet<Patient> Patients {get; set;}              // A list to store Patients.
    public DbSet<Record> Records {get; set;}                // A list to Store Records.
    public DbSet<Room> Rooms {get; set;}                    // A list to store Rooms.
    public DbSet<TestReport> TestReports {get; set;}        // A list to store TestReports.

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // The name of the DataBase is called "WinterBreak_HospitalSystem".
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=WinterBreak_HospitalSystem;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}