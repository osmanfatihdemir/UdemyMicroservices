using AutoMapper;
using FreeCourseServices.OrderApplication.DTOs;
using FreeCourseServices.OrderDomain.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCourseServices.OrderApplication.Mapping
{
   public class CustomMapping:Profile
    {
        public CustomMapping()
        {
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<OrderItem, OrderItemDto>().ReverseMap();
            CreateMap<Address, AddressDto>().ReverseMap();
        }
    }
}
