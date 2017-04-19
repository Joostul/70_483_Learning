using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Model;
using TwitterClone.ViewModel;
using AutoMapper;

namespace TwitterClone.Controllers
{
    public class HomeController : Controller
    {
        private List<TweetViewModel> _tweets { get; set; }
        private readonly IMapper _mapper;

        public HomeController(IMapper Mapper)
        {
            _mapper = Mapper;

            var Tweets = new List<Tweet>()
            {
                new Tweet()
                {
                    Person = "JoostvanUitert",
                    Message = "Hello World",
                    DateTime = DateTime.Now,
                    Loves = 0,
                    Retweets = 0
                },
                new Tweet()
                {
                    Person = "JoostvanUitert",
                    Message = "Fuck you World",
                    DateTime = DateTime.Now,
                    Loves = 0,
                    Retweets = 0
                }
            };

            _tweets = _mapper.Map<List<Tweet>, List<TweetViewModel>>(Tweets);
        }

        public IActionResult Index()
        {
            return View(_tweets);
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
