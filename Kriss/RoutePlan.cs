using CargoTransportationSystem;
using System.Collections.Generic;
using System;

namespace TruckingSystem
{
    public class RoutePlan
    {
        public Vehicle Vehicle { get; set; }
        public List<Driver> Drivers { get; set; }
        public DateTime ArrivalDate { get; set; }
        public Order RelatedOrder { get; set; }

        public RoutePlan(Vehicle vehicle, List<Driver> drivers, DateTime arrivalDate, Order relatedOrder)
        {
            Vehicle = vehicle;
            Drivers = drivers;
            ArrivalDate = arrivalDate;
            RelatedOrder = relatedOrder;
        }
    }
}
