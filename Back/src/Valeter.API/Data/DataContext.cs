using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Valeter.API.Models;

namespace Valeter.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Costumer> Costumers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<FollowUp> FollowUps { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Parking> Parkings { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleManufacturer> VehicleManufacturers { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<Job> Washings { get; set; }
        public DbSet<JobStatus> WashingStatuses { get; set; }
        public DbSet<JobService> WashingTypes { get; set; }
        public DbSet<Test> Tests { get; set; }
    }
}