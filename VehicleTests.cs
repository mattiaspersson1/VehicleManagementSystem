using System;
using VehicleManagementSystem.Models;
using Xunit;

namespace VehicleManagementSystem.Tests
{
    public class VehicleTests
    {
        [Fact]
        public void Vehicle_Brand_Validation_ShouldThrow()
        {
            var ex = Assert.Throws<ArgumentException>(() =>
                new Car { Brand = "A", Model = "Test", Year = 2022, Weight = 1000 });
            Assert.Contains("Brand must be between", ex.Message);
        }

        [Fact]
        public void Vehicle_Year_Validation_ShouldThrow()
        {
            var ex = Assert.Throws<ArgumentException>(() =>
                new Car { Brand = "Volvo", Model = "XC60", Year = 1700, Weight = 1800 });
            Assert.Contains("Year must be", ex.Message);
        }

        [Fact]
        public void Vehicle_Weight_Validation_ShouldThrow()
        {
            var ex = Assert.Throws<ArgumentException>(() =>
                new Car { Brand = "Volvo", Model = "XC60", Year = 2020, Weight = -10 });
            Assert.Contains("Weight must be", ex.Message);
        }

        [Fact]
        public void Car_CanBeCleaned()
        {
            var car = new Car { Brand = "Volvo", Model = "XC60", Year = 2020, Weight = 2000 };
            car.Clean();
        }
    }
}
