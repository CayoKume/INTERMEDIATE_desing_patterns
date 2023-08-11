namespace I.S.P__Interface_Segregation_Principle_.Vehicles.Utils
{
    internal class Car : ICar
    {
        private string color;
        private int year;
        private double engine;
        private int seats;
        private int doors;

        public Car(string color, int year, double engine, int seats, int doors)
        {
            ConfigureCar(color, year, engine, seats, doors);
        }

        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;
            this.seats = seats;
            this.doors = doors;

            Console.WriteLine($"\nCriando um Carro da cor: {color}, do ano: {year}, com motor: {engine}, com {doors} portas, e com {seats} assentos\n");

            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando o motor...");
        }
    }
}
