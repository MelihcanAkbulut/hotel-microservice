using HotelService.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelService.Domain.Aggregate.HotelAggregate
{
    public class Hotel : BaseEntity, IAggregateRoot
    {
        public string FirmName { get; private set; }
        public string Description { get; private set; }
        public string NumberOfRoom { get; private set; }
        public DateTime InTime { get; private set; }
        public DateTime OutTime { get; private set; }
        public ICollection<HotelContact> HotelContacts { get; private set; }

        public Hotel()
        {
                
        }

        public Hotel(string firmName, string description, string numberOfRoom, DateTime ınTime, DateTime outTime, ICollection<HotelContact> hotelContacts)
        {
            FirmName = firmName;
            Description = description;
            NumberOfRoom = numberOfRoom;
            InTime = ınTime;
            OutTime = outTime;
            HotelContacts = hotelContacts;
        }

        public void AddHotelContact(string type, string information)
        {
            HotelContact hotelContact = new HotelContact(type, information);

            HotelContacts.Add(hotelContact);
        }
    }
}
