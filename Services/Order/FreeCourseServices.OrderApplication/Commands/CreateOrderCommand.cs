using FreeCourse.Shared.DTOs;
using FreeCourseServices.OrderApplication.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCourseServices.OrderApplication.Commands
{
   public class CreateOrderCommand:IRequest<Response<CreatedOrderDto>>
    {

        public string BuyerId { get; set; }
        public List<OrderItemDto> OrderItems { get; set; }
        public AddressDto Address { get; set; }

    }
}
