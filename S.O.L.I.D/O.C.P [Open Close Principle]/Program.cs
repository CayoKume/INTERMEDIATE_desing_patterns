using O.C.P__Open_Close_Principle_.Vehicles;

namespace O.C.P__Open_Close_Principle_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                O Princípio aberto/fechado, dita que uma entidade, que pode ser uma classe, um módulo, ou uma função, deve ser fechada para
                modificação e aberta para extensão.

                Podemos então trabalhar com heranças, essas heranças poderão adicionar novas funcionalidades e recursos no sistema, porém
                não podemos alterar o que já foi implementado na classe pai, pois as classes filhas já à implementam.
            */

            Console.WriteLine("Digite se o Veiculo é CARRO ou MOTO");
            var vehicle = Console.ReadLine();

            #region Exemplo de como o OCP pode ser violado
            /*
                Nesse exemplo temos alguns problemas, como a violação do principio SRP, pois a classe _Vehicle exerce a funcação da criação de
                carros e motos, portanto a classe acaba violando também o pricipio OCP, pois caso haja a necessidade de alterar a classe Car,
                a classe Motorclycle também sofrerá alterações.
             
                if (vehicle.ToUpper() == "CARRO")
                {
                    _Vehicle _vehicle = new _Vehicle("Azul", 2022, 2.0, 5, 4);
                    _vehicle.Car();
                }
                else if (vehicle.ToUpper() == "MOTO")
                {
                    _Vehicle _vehicle = new _Vehicle("Branco", 2020, 300, 0, 0);
                    _vehicle.Motorcycle();
                }
                else
                    Console.WriteLine("Veiculo não disponível");
            */
            #endregion

            #region Exemplo da aplicação do OCP
            /*
                Para corrigir isso, criamos uma claase pai Vehicle que possui os atributos e métodos que as classe Car e Motorcycle possuem em comum,
                após isso criamos as classes filhas e extendemos a classe pai para elas. 
            
                As classes filhas então poderão adicionar novas funcionalidades e recursos ao sistema porem sem alterar uma a outra e sem alterar a
                classe pai.
            */
            if (vehicle.ToUpper() == "CARRO")
            {
                Car _vehicle = new Car("Azul", 2022, 2.0, 5, 4);
            }
            else
            {
                Motorcycle _vehicle = new Motorcycle("Branco", 2020, 300);
            }
            #endregion
        }
    }
}