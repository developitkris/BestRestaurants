using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;

namespace BestRestaurants.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            Restaurant newRestaurant = new Restaurant("mcdonalds", "seattle", 4, 6);
            newRestaurant.Save();
            // List<Restaurant> RestaurantList = Restaurant.GetAll();
            return View();
        }
    }
}
