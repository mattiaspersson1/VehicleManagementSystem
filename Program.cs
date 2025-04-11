using System;
using System.Collections.Generic;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Errors;

class Program
{
    static void Main()
    {
        VehicleHandler handler = new VehicleHandler();

        try
        {
            var car = new Car { Brand = "Volvo", Model = "EX30", Year = 2025, Weight = 1800, HasSunroof = true };
            var truck = new Truck { Brand = "Scania", Model = "R500", Year = 2020, Weight = 8500, CargoCapacity = 12000 };
            var bike = new Motorcycle { Brand = "Yamaha", Model = "MT-07", Year = 2021, Weight = 200, HasSidecar = false };
            var scooter = new ElectricScooter { Brand = "Xiaomi", Model = "M365", Year = 2023, Weight = 15, BatteryRange = 30 };

            List<Vehicle> vehicles = new List<Vehicle> { car, truck, bike, scooter };

            foreach (var v in vehicles)
            {
                v.Stats();
                v.StartEngine();

                if (v is ICleanable cleanable)
                    cleanable.Clean();

                Console.WriteLine();
            }

            List<SystemError> errors = new List<SystemError>
            {
                new EngineFailureError(),
                new BrakeFailureError(),
                new TransmissionError()
            };

            Console.WriteLine("System Errors:");
            foreach (var error in errors)
            {
                Console.WriteLine(error.ErrorMessage());
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Validation error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}
