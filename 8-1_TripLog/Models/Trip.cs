// Kenny Hedlund
// Chapter 8 Trip Log
// COP.4813

using System.ComponentModel.DataAnnotations;

namespace _8_1_TripLog.Models
{
    public class Trip
    {
        // primary key identifier
        public int TripId { get; set; }

        // Required -> Destination of the trip
        [Required(ErrorMessage = "Please enter a destination.")]
        public string Destination { get; set; }

        // Required -> StartDate of the trip
        [Required(ErrorMessage = "Please enter a start date.")]
        public DateTime StartDate { get; set; }

        // Required -> EndDate of the trip
        [Required(ErrorMessage = "Please enter an end date.")]
        public DateTime EndDate { get; set; }

        // Optional -> Accommodation information
        public string Accommodation { get; set; }
        // Optional -> Accommodation Phone Number
        public string AccommodationPhone { get; set; }
        // Optional -> Accommodation Email
        public string AccommodationEmail { get; set; }
        // Optional -> ToDo List
        public string ThingToDo1 { get; set; }
        public string ThingToDo2 { get; set; }
        public string ThingToDo3 { get; set; }
    }
}
