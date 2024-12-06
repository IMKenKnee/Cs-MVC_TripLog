// Kenny Hedlund
// Chapter 8 Trip Log
// COP.4813

using System.ComponentModel.DataAnnotations;

namespace _8_1_TripLog.Models
{
    public class AddPage2ViewModel
    {
        // Optional Phone number for accommodation
        public string AccommodationPhone { get; set; }
        // Optional Email for accommodation
        public string AccommodationEmail { get; set; }
    }
}