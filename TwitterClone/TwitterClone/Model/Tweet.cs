using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitterClone.Model
{
    public class Tweet
    {
        public int Id { get; set; }
        public string Person { get; set; }
        public string Message { get; set; }
        public DateTime DateTime { get; set; }
        public int Loves { get; set; }
        public int Retweets { get; set; }
    }
}
