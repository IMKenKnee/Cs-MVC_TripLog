// Kenny Hedlund
// Chapter 8 Trip Log
// COP.4813

using Microsoft.AspNetCore.Mvc;
using _8_1_TripLog.Data;
using _8_1_TripLog.Models;

namespace _8_1_TripLog.Controllers
{
    public class HomeController : Controller
    {
        private readonly TripLogContext _context;

        public HomeController(TripLogContext context)
        {
            // Initialize database context interaction with the Trips table.
            _context = context;
        }

        // Display all trips Home page
        public IActionResult Index()
        {
            // Fetch trip information from database and pass them to Index
            var trips = _context.Trips.ToList();
            // Pass TempData messages to the view
            ViewData["Message"] = TempData["Message"];
            return View(trips);
        }

        // Start AddPage1 for entering trip data
        public IActionResult AddPage1()
        {
            // Empty trip object for input
            return View(new AddPage1ViewModel());
        }

        // POST request for AddPage1 data
        [HttpPost]
        public IActionResult AddPage1(AddPage1ViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Store entered data in TempData
                TempData["Destination"] = model.Destination;
                TempData["StartDate"] = model.StartDate.ToString();
                TempData["EndDate"] = model.EndDate.ToString();
                TempData["Accommodation"] = model.Accommodation;

                // If no accommodation value -> skip to AddPage3
                if (string.IsNullOrEmpty(model.Accommodation))
                {
                    return RedirectToAction("AddPage3");
                }
                // If accommodation !null -> load AddPage2
                return RedirectToAction("AddPage2");
            }
            // If the model is invalid -> display model again
            return View(model);
        }

        // Show AddPage2 for accommodation details
        public IActionResult AddPage2()
        {
            ViewData["SubTitle"] = $"Add Info for {TempData["Accommodation"]}";
            // Storing TempData values to keep persistent
            TempData.Keep("Destination");
            TempData.Keep("StartDate");
            TempData.Keep("EndDate");
            TempData.Keep("Accommodation");
            return View(new AddPage2ViewModel());
        }

        // POST request for AddPage2 data
        [HttpPost]
        public IActionResult AddPage2(AddPage2ViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Store page2 data in TempData
                TempData["AccommodationPhone"] = model.AccommodationPhone;
                TempData["AccommodationEmail"] = model.AccommodationEmail;

                // Keep page1 TempData entries
                TempData.Keep("Destination");
                TempData.Keep("StartDate");
                TempData.Keep("EndDate");
                TempData.Keep("Accommodation");

                // Load AddPage3 after storing data
                return RedirectToAction("AddPage3");
            }
            // If the model is invalid -> display model again
            return View(model);
        }

        public IActionResult AddPage3()
        {
            ViewData["SubTitle"] = $"Add Things to Do in {TempData["Destination"]}";
            // TempData for page3
            TempData.Keep("Destination");
            TempData.Keep("StartDate");
            TempData.Keep("EndDate");
            TempData.Keep("Accommodation");
            TempData.Keep("AccommodationPhone");
            TempData.Keep("AccommodationEmail");
            return View(new AddPage3ViewModel());
        }

        // POST request for AddPage3 data
        [HttpPost]
        public IActionResult AddPage3(AddPage3ViewModel model)
        {
            if (ModelState.IsValid)
            {
                // New trip object with all TempData and page3 data
                var trip = new Trip
                {
                    Destination = TempData["Destination"]?.ToString(),
                    StartDate = DateTime.Parse(TempData["StartDate"].ToString()),
                    EndDate = DateTime.Parse(TempData["EndDate"].ToString()),
                    Accommodation = TempData["Accommodation"]?.ToString(),
                    AccommodationPhone = TempData["AccommodationPhone"]?.ToString(),
                    AccommodationEmail = TempData["AccommodationEmail"]?.ToString(),
                    ThingToDo1 = model.ThingToDo1,
                    ThingToDo2 = model.ThingToDo2,
                    ThingToDo3 = model.ThingToDo3
                };

                // Save trip data to the local trips database
                _context.Trips.Add(trip);
                _context.SaveChanges();

                // Clear TempData values after saving data to Trips database
                TempData.Clear();

                TempData["Message"] = $"Trip to {trip.Destination} added successfully.";

                // Redirect to the Home page after saving
                return RedirectToAction("Index");
            }
            // If the model invalid -> display model again -> save all temp data to be used in page3
            TempData.Keep();
            return View(model);
        }
    }
}