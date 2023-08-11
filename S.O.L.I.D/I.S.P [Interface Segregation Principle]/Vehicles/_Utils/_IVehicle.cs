namespace I.S.P__Interface_Segregation_Principle_.Vehicles._Utils
{
    internal interface _IVehicle
    {
        void ConfigureCar(string color, int year, double engine, int seats, int doors);
        void ConfigureMotorcycle(string color, int year, double engine);
        void StartVehicle();
    }
}
