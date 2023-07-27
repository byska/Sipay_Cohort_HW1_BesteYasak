using AutoMapper;
using HW_Cohorts_1.DTOs.Order;
using HW_Cohorts_1.DTOs.User;
using HW_Cohorts_1.Entities;

namespace HW_Cohorts_1.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<OrderCreateDTO,Order>().ReverseMap();
            CreateMap<Order,OrderDTO>().ForMember(dest=>dest.UserName,opt=>opt.MapFrom(src=>src.user.FirstName+" "+src.user.LastName));

            CreateMap<User, UserCreateDTO>().ReverseMap();

            CreateMap<Order,OrderUpdateDto>().ReverseMap();
        }
    }
}
