using System;
using System.Collections.Generic;

namespace CargoTransportationSystem
{
    public class Cargo
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public int Quantity { get; set; }
        public float Weight { get; set; }
        public float InsuranceValue { get; set; }

        public Cargo(string name, string unit, int quantity, float weight, float insuranceValue)
        {
            Name = name;
            Unit = unit;
            Quantity = quantity;
            Weight = weight;
            InsuranceValue = insuranceValue;
        }
    }

    public class Order
    {
        public string OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public Client Sender { get; set; }
        public string PickupAddress { get; set; }
        public string DeliveryAddress { get; set; }
        public float RouteLength { get; set; }
        public float Cost { get; set; }
        public List<Cargo> CargoItems { get; set; }

        public Order(DateTime orderDate, Client sender, string pickupAddress, string deliveryAddress, float routeLength, float cost, List<Cargo> cargoItems)
        {
            OrderDate = orderDate;
            Sender = sender;
            PickupAddress = pickupAddress;
            DeliveryAddress = deliveryAddress;
            RouteLength = routeLength;
            Cost = cost;
            CargoItems = cargoItems;
        }
    }
}
