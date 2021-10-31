using AutoMapper;
using Core.Entities.Concrete;
using Entities.DTOs;

namespace Business.Helpers
{
    public class AutoMapperHelper : Profile
    {
        public AutoMapperHelper()
        {
            CreateMap<User, UserForLoginDto>().ReverseMap();
        }
    }
}
