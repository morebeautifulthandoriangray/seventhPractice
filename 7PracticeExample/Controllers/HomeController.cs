using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _7PracticeExample.Context;
using _7PracticeExample.Entities;
using _7PracticeExample.Models;

namespace _7PracticeExample.Controllers
{
    public class HomeController : Controller
    {
        private GuestContext _dbGuestContext = new GuestContext();
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning!" : "Good afternoon!";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guest)
        {
            if (ModelState.IsValid)
            {
                
                var guef = _dbGuestContext.Guests.FirstOrDefault<Guest>((client) => client.Phone.Equals(guest.Phone));
                if (guef == null)
                {
                    var newGuest = new Guest();
                    newGuest.Phone = guest.Phone;
                    newGuest.Name = guest.Name;
                    newGuest.Email = guest.Email;
                    newGuest.Agreement = guest.WillAttend.ToString();
                    _dbGuestContext.Guests.Add(newGuest);
                }
                else
                {
                    
                    
                    guef.Name = guest.Name;
                    guef.Email = guest.Email;
                    guef.Agreement = guest.WillAttend.ToString();

                    _dbGuestContext.Entry(guef).State = EntityState.Modified;
                }
                _dbGuestContext.SaveChanges();
                return View("Thanks", guest);
            }

            else
            {
                //Обнаружена ошибка проверки достоверности
                return View();
            }

        }
    }
}