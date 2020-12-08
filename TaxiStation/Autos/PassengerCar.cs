namespace TaxiStation.Autos
{

    public abstract class PassengerCar
    {
        public int CountOfPassengers { get; protected set; }
        public double CostForKm { get; protected set; }
        public string Model { get; protected set; }
        public Driver Driver { get; }
        public string Color { get; }
        public string Number { get; }
        public int Year { get; }
        public bool IsFree { get; set; }
        public decimal CostOfCar { get; protected set; }
        public float FuelConsumption { get; protected set; }
        public int MaxSpeed { get; protected set; }

        public PassengerCar(Driver driver, string color, string number, int year)
        {
            Driver = driver;
            Color = color;
            Number = number;
            Year = Year;
        }

        public override string ToString()
        {
            return $"Автомобиль {Model}, цвет {Color}, номер {Number}. Водитель: {Driver.Name}.";
        }



    }
}