using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I.S.P__Interface_Segregation_Principle_.Vehicles.Utils
{
    internal interface ICar
    {
        void ConfigureCar(string color, int year, double engine, int seats, int doors);
    }
}
