using System;
using System.Collections.Generic;
using System.Linq;
using TaxiStation;
using TaxiStation.Autos;
using TaxiStation.Autos.AClassCars;
using Xunit;

namespace TaxiStationTest
{
    public class TaxiStationTests
    {
        [Fact]
        public void OrderOneCar()
        {
            List<PassengerCar> cars = new List<PassengerCar>();
            cars.Add(new Zetta(new Driver("qwerty",4), "red","a123bv",2020));
            TaxiStationManager taxiStation = new TaxiStationManager(cars);
            Assert.Equal(1,taxiStation.ShowAllFreeCars().Count);
            var carToOrder = taxiStation.ShowAllFreeCars().First();
            taxiStation.OrderCar(carToOrder);
            Assert.Empty(taxiStation.ShowAllFreeCars());
        }
    }
}