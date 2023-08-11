namespace I.S.P__Interface_Segregation_Principle_.Vehicles._Utils
{
    internal class _Motorcycle : _IVehicle
    {
        private string color;
        private int year;
        private double engine;

        public _Motorcycle (string color, int year, double engine)
        {
            ConfigureMotorcycle(color, year, engine);
        }

        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
            throw new NotImplementedException();
        }

        public void ConfigureMotorcycle(string color, int year, double engine)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;

            Console.WriteLine($"\nCriando um Carro da cor: {color}, do ano: {year}, com motor: {engine}\n");

            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando o motor...");
        }
    }
}
