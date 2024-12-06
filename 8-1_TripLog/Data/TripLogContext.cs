// Kenny Hedlund
// Chapter 8 Trip Log
// COP.4813

using Microsoft.EntityFrameworkCore;
using _8_1_TripLog.Models;

namespace _8_1_TripLog.Data
{
    public class TripLogContext : DbContext
    {
        // Constructor to initialize context options
        public TripLogContext(DbContextOptions<TripLogContext> options) : base(options) { }

        // Represents Trips table in database
        public DbSet<Trip> Trips { get; set; }

        // Configure Trip entity and seed initial data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure properties for the Trip entity
            modelBuilder.Entity<Trip>(entity =>
            {
                // Seed data
                entity.HasData(
                    new Trip
                    {
                        TripId = 1, //Primary Key
                        Destination = "Washington", // Destination
                        StartDate = new DateTime(2024, 1, 1), // Dates
                        EndDate = new DateTime(2024, 1, 10), // Dates
                        Accommodation = "My Car", // Accommodation
                        AccommodationPhone = "123-456-7890", // Accommodation: Phone
                        AccommodationEmail = "LowMoney@Mazda.com", // Accommodation: E-mail
                        ThingToDo1 = "Drive", // ToDo list action 1
                        ThingToDo2 = "Eat", // ToDo list action 2
                        ThingToDo3 = "Look at stuff" // ToDo list action 3
                    },
                    new Trip
                    {
                        TripId = 2,
                        Destination = "Hawaii",
                        StartDate = new DateTime(2024, 2, 15),
                        EndDate = new DateTime(2024, 2, 25),
                        Accommodation = "Sleep Number Store",
                        AccommodationPhone = "987-654-3210",
                        AccommodationEmail = "info@sleepnumber.com",
                        ThingToDo1 = "Go To Beach",
                        ThingToDo2 = "Go To Volcano",
                        ThingToDo3 = "Karaoke"
                    }
                );
            });
        }
    }
}