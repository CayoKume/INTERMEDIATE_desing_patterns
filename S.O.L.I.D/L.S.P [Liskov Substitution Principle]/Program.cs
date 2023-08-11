using L.S.P__Liskov_Substitution_Principle_.Clients;
using L.S.P__Liskov_Substitution_Principle_.Clients._Utils;
using L.S.P__Liskov_Substitution_Principle_.Clients.Utils;

namespace L.S.P__Liskov_Substitution_Principle_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                O Princípio de Liskov, dita que uma entidade filha herdada de uma classe pai, deve poder ser substituida por sua classe pai,
                sem que haja a quebra do código.

                Como exmeplo, podemos citar uma classe pai chamada Passaro que possui o método Voar, está mesma classe 
                pai, possui duas classes filhas, Pomba e Galinha.

                Ao instanciar a classe filha Pomba podemos passar como tipagem a classe pai, isso por si só é um exemplo direto do
                principio LSP, pois estamos substituindo a classe filha Pomba pela sua classe pai Passaro. Porém além disso, a herança torna-se
                validada já que a classe pomba é classificada como passaro e ela sabe voar.

                Já quando vamos instanciar a classe filha Galinha o principio é quebrado, pois a classe galinha é classificada como passaro mas 
                a mesma não sabe voar, portanto o método Voar, não deveria ser acessivél para essa classe filha.
            */

            Passaro pomba = new Pomba("Blue");
            Passaro galinha = new Galinha("Coco");

            Console.ReadLine();

            /*
                Para corrigirmos isso, podemos criar uma interface de _Passaro com a assinatura do método Voar e implementar a interface somente nas
                classes que devem possui-lo
            */

            _Passaro _pomba = new _Pomba("Blue");
            _Passaro _galinha = new _Galinha("Coco");
            Console.WriteLine("A galinha não sabe voar, e por isso não tem acesso ao método voar");
        }
    }
}