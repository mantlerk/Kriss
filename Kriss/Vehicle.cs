using System;

namespace CargoTransportationSystem
{
    public class Vehicle
    {
        public string NumberPlate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public float Capacity { get; set; }
        public string Purpose { get; set; }
        public int YearOfManufacture { get; set; }
        public int LastRepairYear { get; set; }
        public float Mileage { get; set; }

        public Vehicle(string numberPlate, string brand, string model, float capacity, string purpose, int yearOfManufacture, int lastRepairYear, float mileage)
        {
            NumberPlate = numberPlate;
            Brand = brand;
            Model = model;
            Capacity = capacity;
            Purpose = purpose;
            YearOfManufacture = yearOfManufacture;
            LastRepairYear = lastRepairYear;
            Mileage = mileage;
        }
    }
}
