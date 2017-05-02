using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterClone.ViewModel;

namespace TwitterClone.Services
{
    public interface IMockDataService
    {
        ListCreateTweetViewModel GetTwitterMockData();
        void AddNewTweet(CreateViewModel tweet);
    }
}
