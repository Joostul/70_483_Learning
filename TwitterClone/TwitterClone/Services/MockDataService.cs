using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterClone.ViewModel;

namespace TwitterClone.Services
{
    public class MockDataService : IMockDataService
    {
        private ListCreateTweetViewModel _model;

        public MockDataService()
        {
            _model = new ListCreateTweetViewModel()
            {
                ListViewModel = new ListViewModel()
                {
                    TweetList = new List<CreateViewModel>()
                    {
                        new CreateViewModel()
                        {
                            Person = "JoostvanUitert",
                            Message = "Hello World",
                            DateTime = DateTime.Now,
                            Loves = 0,
                            Retweets = 0
                        },
                        new CreateViewModel()
                        {
                            Person = "JoostvanUitert",
                            Message = "Goodbye World",
                            DateTime = DateTime.Now,
                            Loves = 0,
                            Retweets = 0
                        },
                        new CreateViewModel()
                        {
                            Person = "JoostvanUitert",
                            Message = "Good to see you again World",
                            DateTime = DateTime.Now,
                            Loves = 0,
                            Retweets = 0
                        },
                        new CreateViewModel()
                        {
                            Person = "JoostvanUitert",
                            Message = "And again World",
                            DateTime = DateTime.Now,
                            Loves = 0,
                            Retweets = 0
                        },
                        new CreateViewModel()
                        {
                            Person = "JoostvanUitert",
                            Message = "Goodbye now then World",
                            DateTime = DateTime.MaxValue,
                            Loves = 0,
                            Retweets = 0
                        }
                    }
                },
                CreateViewModel = new CreateViewModel()
            };
        }

        public void AddNewTweet(CreateViewModel tweet)
        {
            _model.ListViewModel.TweetList.Add(tweet);
        }

        public ListCreateTweetViewModel GetTwitterMockData()
        {
            return _model;
        }
    }
}
