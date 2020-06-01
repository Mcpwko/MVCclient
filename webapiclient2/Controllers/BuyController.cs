using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using webapiclient2.Factory;
using webapiclient2.Models;
using webapiclient2.Utility;

namespace webapiclient2.Controllers
{
    public class BuyController : Controller
    {
        private readonly ILogger<BuyController> _logger;
        private readonly IOptions<MySettingsModel> appSettings;

        public BuyController(ILogger<BuyController> logger, IOptions<MySettingsModel> app)
        {
            appSettings = app;
            ApplicationSettings.WebApiUrl = appSettings.Value.WebApiBaseUrl;
            _logger = logger;
        }

        public async Task<IActionResult> BuyTicketAsync(int id)
        {
            var data = await ApiClientFactory.Instance.GetFlightSet(id);
            ViewBag.flightInfo = data;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BuyTicketAsync(Booking booking)
        {
            var newPassenger = await ApiClientFactory.Instance.PostPassengerSet(booking.Firstname, booking.Name);

            var data =  await ApiClientFactory.Instance.GetPassenger(booking.Firstname, booking.Name);

            //Create the Booking
            var newBooking = await ApiClientFactory.Instance.CreateBooking(booking.FlightNo, data.PersonId, booking.SalesPrice);

            return RedirectToAction("AllBooking", "Home");
        }
    }
}
