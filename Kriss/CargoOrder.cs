using CargoTransportationSystem;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckingSystem
{
    public class CargoOrder
    {
        public string OrderId { get; set; }
        public Client Client { get; set; }
        public List<Cargo> CargoItems { get; set; }
        public DateTime OrderDate { get; set; }
        public float RouteLength { get; set; }
        public float Cost { get; set; }

        // Конструктор, который принимает 7 параметров
        public CargoOrder(string orderId, string senderName, string pickupAddress, string recipientName, string deliveryAddress, float routeLength, float cost)
        {
            OrderId = orderId;
            Client = new IndividualClient(senderName, "", "", "", "", ""); // Пример, возможно, нужно создать клиент
            CargoItems = new List<Cargo>();  // Это может быть список грузов, передаваемых через форму
            OrderDate = DateTime.Now; // Можно передавать дату, если нужно
            RouteLength = routeLength;
            Cost = cost;
        }

        // Метод для подсчета общей стоимости (пример)
        public float CalculateTotalCost()
        {
            // Рассчитываем общую стоимость (например, умножив вес на 10)
            return CargoItems.Sum(c => c.Weight * 10);
        }
    }
}
