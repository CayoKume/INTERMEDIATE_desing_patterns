using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I.S.P__Interface_Segregation_Principle_.Vehicles.Utils
{
    internal interface IMotorcycle
    {
        void ConfigureMotorcycle(string color, int year, double engine);
    }
}
