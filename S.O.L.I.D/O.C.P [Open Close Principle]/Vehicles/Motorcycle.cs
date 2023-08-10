namespace O.C.P__Open_Close_Principle_.Vehicles
{
    internal class Motorcycle : Vehicle
    {

        public Motorcycle(string color, int year, double engine) : base(color, year, engine)
        {
            ConfigureMotorcycle();
        }

        public void ConfigureMotorcycle()
        {
            Console.WriteLine($"\nCriando uma Moto da cor: {color}, do ano: {year}, e com {engine} cilindradas\n");
            StartVehicle();
        }

        public override void StartVehicle()
        {
            Console.WriteLine("Ligando o motor da moto");
        }
    }
}
