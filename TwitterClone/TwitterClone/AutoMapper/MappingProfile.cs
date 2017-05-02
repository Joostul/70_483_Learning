using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterClone.Model;
using TwitterClone.ViewModel;

namespace TwitterClone.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Tweet, ListCreateTweetViewModel>();
            CreateMap<ListCreateTweetViewModel, Tweet>()
                .ForMember(t => t.Id, opt => opt.Ignore());
        }
    }
}
