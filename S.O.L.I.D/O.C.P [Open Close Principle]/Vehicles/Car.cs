namespace O.C.P__Open_Close_Principle_.Vehicles
{
    internal class Car : Vehicle
    {
        private int seats;
        private int doors;

        public Car (string color, int year, double engine, int seats, int doors) : base(color, year, engine)
        {
            this.seats = seats;
            this.doors = doors;
            ConfigureCar();
        }

        public void ConfigureCar()
        {
            Console.WriteLine($"\nCriando um Carro da cor: {color}, do ano: {year}, com motor: {engine}, com {doors} portas, e com {seats} assentos\n");
            StartVehicle();
        }

        public override void StartVehicle()
        {
            Console.WriteLine("Ligando o motor do carro");
        }
    }
}
