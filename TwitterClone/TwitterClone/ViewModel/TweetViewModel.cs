using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterClone.Model;

namespace TwitterClone.ViewModel
{
    public class TweetViewModel
    {
        public string Person { get; set; }
        public string Message { get; set; }
        public DateTime DateTime { get; set; }
        public int Loves { get; set; }
        public int Retweets { get; set; }
    }
}
