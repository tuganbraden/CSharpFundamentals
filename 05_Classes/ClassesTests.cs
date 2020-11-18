using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void CookieTests()
        {
            Cookie cookie = new Cookie();
            cookie.Name = "Snickerdoodle";
            cookie.HasNuts = false;

            Cookie kyle = new Cookie();
            kyle.Name = "Something else";
            kyle.GramsOfFlour = 10;

            Cookie snickerdoodle = new Cookie("Snickerdoodle", false, 11.5);
            Cookie newCookie = new Cookie("Peanut Butter", true, 150);
        }

        [TestMethod]
        public void VehicleTests()
        {
            Vehicle car = new Vehicle();
            car.Type = VehicleType.Car;

            Vehicle newCar = new Vehicle
            {
                Type = VehicleType.Car,
                Make = "Honda",
                Model = "Civic"
            };

            int x = 4;
        }
    }
}
