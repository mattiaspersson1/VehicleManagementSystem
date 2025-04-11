using System;

namespace VehicleManagementSystem.Models
{
    public abstract class Vehicle
    {
        private string brand;
        private string model;
        private int year;
        private double weight;

        public string Brand
        {
            get => brand;
            set
            {
                if (value.Length < 2 || value.Length > 20)
                    throw new ArgumentException("Brand must be between 2 and 20 characters.");
                brand = value;
            }
        }

        public string Model
        {
            get => model;
            set
            {
                if (value.Length < 2 || value.Length > 20)
                    throw new ArgumentException("Model must be between 2 and 20 characters.");
                model = value;
            }
        }

        public int Year
        {
            get => year;
            set
            {
                if (value < 1886 || value > DateTime.Now.Year)
                    throw new ArgumentException("Year must be between 1886 and current year.");
                year = value;
            }
        }

        public double Weight
        {
            get => weight;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Weight must be a positive number.");
                weight = value;
            }
        }

        public virtual void StartEngine() => Console.WriteLine("Starting vehicle...");
        public virtual void Stats() =>
            Console.WriteLine($"{Brand} {Model}, Year: {Year}, Weight: {Weight}kg");
    }

    public interface ICleanable
    {
        void Clean();
    }

    public class Car : Vehicle, ICleanable
    {
        public bool HasSunroof { get; set; }

        public override void StartEngine() => Console.WriteLine("Car engine starting...");
        public override void Stats()
        {
            base.Stats();
            Console.WriteLine($"Has Sunroof: {HasSunroof}");
        }

        public void Clean() => Console.WriteLine("Car is being cleaned.");
    }

    public class Truck : Vehicle, ICleanable
    {
        public double CargoCapacity { get; set; }

        public override void StartEngine() => Console.WriteLine("Truck engine rumbles to life.");
        public override void Stats()
        {
            base.Stats();
            Console.WriteLine($"Cargo Capacity: {CargoCapacity} kg");
        }

        public void Clean() => Console.WriteLine("Truck is being power-washed.");
    }

    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public override void StartEngine() => Console.WriteLine("Motorcycle roars to life.");
        public override void Stats()
        {
            base.Stats();
            Console.WriteLine($"Has Sidecar: {HasSidecar}");
        }
    }

    public class ElectricScooter : Vehicle
    {
        public int BatteryRange { get; set; }

        public override void StartEngine() => Console.WriteLine("Electric scooter buzzes quietly.");
        public override void Stats()
        {
            base.Stats();
            Console.WriteLine($"Battery Range: {BatteryRange} km");
        }
    }

    public class VehicleHandler
    {
        private List<Vehicle> vehicles = new List<Vehicle>();
        public void AddVehicle(Vehicle v) => vehicles.Add(v);
        public void ListVehicles()
        {
            foreach (var v in vehicles)
                v.Stats();
        }
    }
}
