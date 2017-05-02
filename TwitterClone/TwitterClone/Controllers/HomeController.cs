using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Model;
using TwitterClone.ViewModel;
using AutoMapper;
using TwitterClone.Services;

namespace TwitterClone.Controllers
{
    public class HomeController : Controller
    {
        private IMockDataService _service;

        public HomeController(IMockDataService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Index(ListCreateTweetViewModel newTweet)
        {
            newTweet.CreateViewModel.DateTime = DateTime.Now;
            newTweet.CreateViewModel.Loves = 0;
            newTweet.CreateViewModel.Person = "JoostNew";
            newTweet.CreateViewModel.Retweets = 0;

            _service.AddNewTweet(newTweet.CreateViewModel);

            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {


            var viewtweets = _service.GetTwitterMockData();

            var sortedTweets = viewtweets.ListViewModel.TweetList.OrderByDescending(t => t.DateTime).ToList();

            viewtweets.ListViewModel.TweetList = sortedTweets;

            return View(viewtweets);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
