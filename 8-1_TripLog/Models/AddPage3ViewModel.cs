// Kenny Hedlund
// Chapter 8 Trip Log
// COP.4813

using System.ComponentModel.DataAnnotations;

namespace _8_1_TripLog.Models
{
    public class AddPage3ViewModel
    {
        // Optional ToDo list options -> 3 in total
        public string ThingToDo1 { get; set; }
        public string ThingToDo2 { get; set; }
        public string ThingToDo3 { get; set; }
    }
}
