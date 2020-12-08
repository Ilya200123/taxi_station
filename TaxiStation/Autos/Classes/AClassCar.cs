namespace TaxiStation.Autos
{
    public abstract class AClassCar : PassengerCar
    {
        public AClassCar(Driver driver, string color, string number, int year) : base(driver, color, number, year)
        {
            CountOfPassengers = 3;
            CostForKm = 50;
        }
    }
}