namespace O.C.P__Open_Close_Principle_.Vehicles
{
    internal class Vehicle
    {
        protected string color;
        protected int year;
        protected double engine;

        public Vehicle (string color, int year, double engine)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;
        }

        public virtual void StartVehicle()
        {
            Console.WriteLine("Ligando o motor");
        }
    }
}
