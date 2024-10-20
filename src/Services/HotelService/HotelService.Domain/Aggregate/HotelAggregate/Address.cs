using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelService.Domain.Aggregate.HotelAggregate
{
    public record Address
    {
        public String Province { get; set; }
        public String District { get; set; }
    }
}
