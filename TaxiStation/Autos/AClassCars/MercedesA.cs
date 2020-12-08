using TaxiStation.Autos.Options;

namespace TaxiStation.Autos.AClassCars
{
    public class MercedesA : AClassCar, IAirConditioned
    {
        public MercedesA(Driver driver, string color, string number, int year) : base(driver, color, number, year)
        {
            CostForKm = 60;
            Model = "Mercedes";
        }
    }
}