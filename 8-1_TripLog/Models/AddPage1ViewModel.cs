// Kenny Hedlund
// Chapter 8 Trip Log
// COP.4813

using System.ComponentModel.DataAnnotations;

namespace _8_1_TripLog.Models
{
    public class AddPage1ViewModel
    {
        // Destination of the trip -> required field with validation
        [Required(ErrorMessage = "Please enter a destination.")]
        public string Destination { get; set; }

        // Start Date of the trip -> required field with validation
        [Required(ErrorMessage = "Please enter a start date.")]
        public DateTime StartDate { get; set; }

        // End date of the trip -> required field with validation
        [Required(ErrorMessage = "Please enter an end date.")]
        public DateTime EndDate { get; set; }

        // Optional accommodations field
        public string? Accommodation { get; set; }
    }
}