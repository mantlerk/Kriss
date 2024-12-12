using System;

namespace CargoTransportationSystem
{
    public class Trip
    {
        public int TripId { get; set; } // Добавьте это свойство
        public string Destination { get; set; }
        public DateTime DepartureDate { get; set; }
        public string TripDate { get; set; }
        public string VehicleId { get; set; }
        public string DriverIds { get; set; }
        public string OrderId { get; set; }

        public Trip(string tripDate, string vehicleId, string driverIds, string orderId)
        {
            TripDate = tripDate;
            VehicleId = vehicleId;
            DriverIds = driverIds;
            OrderId = orderId;
        }
    }
}
