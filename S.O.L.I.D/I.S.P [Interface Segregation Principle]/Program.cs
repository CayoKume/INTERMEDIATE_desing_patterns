using I.S.P__Interface_Segregation_Principle_.Vehicles;
using I.S.P__Interface_Segregation_Principle_.Vehicles._Utils;
using I.S.P__Interface_Segregation_Principle_.Vehicles.Utils;

namespace I.S.P__Interface_Segregation_Principle_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                O Princípio da segregação de interfaces, visa deixar cada interface com uma responsabilidade unica, retirando o acumulo de
                assinaturas de métodos desnecessários. fazendo assim com que os clientes não sejam forçados a implementar métodos que eles
                não utilizam.
                
                No Exemplo a seguir criamos a interfaces _IVehicle que possui as assinaturas ConfigureCar(), ConfigureMotorcycle(), StartVehicle()
                ferindo assim o principio ISP, pois ao implmentar a interface nas classes _Car e _Motorcycle, _Car será obrigada a implementar o método
                ConfigureMotorcycle(), e _Motorcycle será obrigada a implementar o método ConfigureCar(), mesmo que dentro delas não haja nenhuma funcionalidade 
                para esses métodos.
            */

            _Car _car = new _Car("Azul", 2022, 2.0, 5, 4);
            _Motorcycle _motorcycle = new _Motorcycle("Branco", 2020, 300);

            /*
                Para corrigir esse problema, criaremos duas novas interfaces, ICar que terá a assinatura ConfigureCar(), e IMotorcycle que terá a assinatura, 
                ConfigureMotorcycle().

                Desta forma a classe Car deverá implementar as interfaces IVehicle e ICar, e a classe Motorcycle deverá implementar as interfaces IVehicle e IMotorcycle,
                sendo assim a classe Car será obrigada a implementar somente os métodos ConfigureCar() e StartVehicle(), e a classe Motorcycle será obrigada a implementar
                somente os métodos ConfigureMotorcycle(), e StartVehicle().
            */

            Car car = new Car("Azul", 2022, 2.0, 5, 4);
            Motorcycle motorcycle = new Motorcycle("Branco", 2020, 300);
        }
    }
}