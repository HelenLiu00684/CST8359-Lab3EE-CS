using Lab3EE.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3EE.Controllers
{
     // Handles workshop pages and RSVP requests.
     public class WorkshopsController : Controller
     {
          // Stores all workshop registrations in memory.
          private static List<Rsvp> registrations = new List<Rsvp>();

          // Displays the Workshop RSVP landing page.
          public IActionResult Index()
          {
               // Sends a simple page title to the View.
               ViewData["PageTitle"] = "Workshop RSVP";

               // Returns Views/Workshops/Index.cshtml.
               return View();
          }
          // Displays an empty RSVP form.
          [HttpGet]
          public IActionResult RsvpForm()
          {
               return View();
          }
          // Receives and processes the submitted RSVP form.
          [HttpPost]
          public IActionResult Confirm(Rsvp model)
          {
               // Adds the submitted RSVP to the in-memory list.
               registrations.Add(model);

               // Sends a confirmation message to the View.
               ViewData["Message"] =
                   $"Thanks for registering, {model.FullName}!";

               // Sends the complete Rsvp model to Confirm.cshtml.
               return View(model);
          }
          // Displays all workshop registrations.
          [HttpGet]
          public IActionResult Registrations()
          {
               // Sends the complete registration list to the View.
               return View(registrations);
          }
     }
}