namespace O.C.P__Open_Close_Principle_
{
    internal class _Vehicle
    {
        private string color;
        private int year;
        private double engine;
        private int seats;
        private int doors;

        public _Vehicle (string color, int year, double engine, int seats, int doors)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;
            this.seats = seats;
            this.doors = doors;
        }

        public void Car ()
        {
            Console.WriteLine($"\nCriando um Carro da cor: {color}, ano: {year}, com motor: {engine}, com {doors} portas, e com {seats} assentos\n");
            StartVehicle();
        }

        public void Motorcycle()
        {
            Console.WriteLine($"\nCriando uma Moto da cor: {color}, ano: {year}, com {engine} cilindradas\n");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando o motor...");
        }
    }
}
