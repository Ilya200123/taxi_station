using TaxiStation.Autos.Options;

namespace TaxiStation.Autos.AClassCars
{
    public class Zetta: AClassCar, IElectricCar
    {
        public Zetta(Driver driver, string color, string number, int year) : base(driver, color, number, year)
        {
            Model = "Zetta";
        }
    }
}