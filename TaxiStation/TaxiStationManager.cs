using System.Collections.Generic;
using System.Linq;
using TaxiStation.Autos;

namespace TaxiStation
{
    public class TaxiStationManager
    {
        public List<PassengerCar> cars { get; }

        public TaxiStationManager(List<PassengerCar> cars)
        {
            this.cars = cars;
            cars.ForEach(car => car.IsFree = true);
        }

        public void OrderCar(PassengerCar car)
        {
            cars.First(auto => auto.Equals(car)).IsFree = false;
        }

        public void RateTheTrip(FeedBack rate, PassengerCar car)
        {
            car.Driver.FeedBacks.Add(rate);
            car.IsFree = true;
        }

        public List<PassengerCar> ShowAllFreeCars()
        {
            return cars.Where(car => car.IsFree).ToList();
        }

    }
}