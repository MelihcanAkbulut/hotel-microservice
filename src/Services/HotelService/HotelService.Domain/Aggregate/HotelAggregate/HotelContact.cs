using HotelService.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelService.Domain.Aggregate.HotelAggregate
{
    public class HotelContact : BaseEntity, IAggregateRoot
    {
        public String Type { get; set; }
        public String Information { get; set; }

        protected HotelContact() { }

        public HotelContact(string type, string information)
        {
            Type = type;
            Information = information;
        }
    }
}
